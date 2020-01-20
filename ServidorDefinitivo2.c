#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>
#include <mysql.h>
int contador, c;
int socket_invita,socket_invitado;
int sockets[100];
char temporal [100];
//Estructura para el acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
//pthread_mutex_lock(&mutex);
//pthread_mutex_unlock(&mutex);
typedef struct{
	char nom[30];
	int socket;
	int turno;
}TConectado;
typedef struct{
	TConectado jugadores [100];
	int num;
}Tconectados;     
Tconectados conect;
typedef struct{
	int socket_invita;
	int socket_invitado;
}TChat;
typedef struct{
	TChat chats [20];
	int num;
}TListaChats;
TListaChats lchats;
int DameConectados(Tconectados *con, char conectados[250]){
	int i;
	conectados[0]='\0';
	temporal[0]='\0';
	for (i=0; i< con->num; i++){
		sprintf (temporal,"%s%s/",temporal,con->jugadores[i].nom);
		sprintf (conectados, "%d/%s",i,temporal);
		//DEJO EL SPRINTF COMENTADO TEMPORALMENTE
		sprintf (conectados, "%s",temporal);
	}
	if (strlen (conectados)==0)   
		return -1; //no hay productos    
	else{  
		conectados[strlen(conectados)-1] = '\0'; // quitamos la ultima'/'   
		return 0;  
	} 
}
int BuscaConectados(Tconectados *con, char conectados[250], char nombre[50]){
	int i,j;
	j=-1;
	conectados[0]='\0';
	int encontrado =0;
	for (i=0; i<con->num && encontrado==0; i++){
		if(strcmp(con->jugadores[i].nom,nombre)==0){
			j=con->jugadores[i].socket;
			printf("Valor de socket buscado %d\n", j);
			encontrado=1;
		}
	}
	if (encontrado == 1)
		return j; //No se ha encontrado al jugador conectado
	else
		return j;
}
int addConectado(Tconectados *con, char nombre[20], int socket){
	pthread_mutex_lock(&mutex);    //Fijamos el thread para que no se interrumpa el proceso
	strcpy(con->jugadores[con->num].nom, nombre);
	con->jugadores[con->num].socket = socket;
	printf("Added user %s with socket %d, position %d\n", nombre, socket, con->num);
	con->num++;
	pthread_mutex_unlock(&mutex);  //Dejamos el thread libre de nuevo
}
int DameSocket(Tconectados * con, char nombre[20], int socket){
	int encontrado =0;
	int i;
	for (i=0; i< con->num && encontrado ==0; i++){
		if(strcmp(con->jugadores[i].nom,nombre)==0){
			socket = con->jugadores[i].socket;
			encontrado =1;
		}
	}
	return socket;
}
void *AtenderCliente (void *socket)
{					//Variables básicas para conectar
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	int socket_conn = * (int *) socket;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char nombre[50];
	int edad;
	char pass[80];
	char ciudad[30];
	char consulta[512];
	char respuesta[512];
	char notificacion[50];
	char misConectados[256];
	int ret,err;
	MYSQL *conn;
	int terminar =0;		//Estructura para almacenar resultados de consultas
	conn = mysql_init(NULL);		//Creamos una conexion al servidor MYSQL 
	if (conn==NULL){
		printf ("Error al crear la conexi\uffc3\uffb3n: %u %s\n",mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	conn = mysql_real_connect (conn, "shiva2.upc.es","root", "mysql", "G1_go",0, NULL, 0);		//inicializar la conexion
	if (conn==NULL){
		printf ("Error al inicializar la conexi\uffc3\uffb3n: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	while(terminar ==0)		// Entramos en un bucle para atender todas las peticiones de 
	{							//este cliente hasta que se desconecte
		// Ahora recibimos la petici?n
		ret=read(sock_conn,consulta, sizeof(consulta));
		// Tenemos que a?adirle la marca de fin de string para que no escriba lo que hay despues en el buffer
		consulta[ret]='\0';
		printf ("Peticion: %s\n",consulta);
		// vamos a ver que quieren
		char *p = strtok(consulta, "/");
		int codigo =  atoi (p);
		// Ya tenemos el c?digo de la petici?n
		if (codigo ==0){ //peticion de desconexion
			int i,encontrado;
			char *p = strtok(consulta, "/");
			strcpy(nombre,p);
			encontrado=0;
			for(i=0; i<conect.num;i++){
				if(strcmp(conect.jugadores[i].nom,nombre)==0){
					conect.jugadores[i]=conect.jugadores[i+1];
					encontrado=1;
				}
			}
			if(encontrado=1){
			DameConectados(&conect,misConectados);
			sprintf(respuesta, "0/%s\n", misConectados);
			write(sock_conn,respuesta, strlen(respuesta));
			}
			terminar=1;
		}
		else if(codigo ==1)  //obtener la contraseña sabiendo un nombre
		{
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			strcpy (consulta,"SELECT jugador.pass FROM jugador WHERE jugador.nombre = '");
			strcat (consulta, nombre);
			strcat (consulta,"'");
			err=mysql_query (conn, consulta); 		// hacemos la consulta 
			if (err!=0){
				printf ("Error al consultar datos de la base %u %s\n",mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			//recogemos el resultado de la consulta 
			sprintf(notificacion,"1/");
			if (row != NULL){
				// El resultado debe ser una matriz con una sola fila y una columna que contiene el nombre
				printf ("Contraseña de la persona: %s\n", row[0] );
				//write (sock_conn,row[0], strlen(row[0]));
				strcat(notificacion, row[0]);
			}
			else{
				printf ("No se han obtenido datos en la consulta\n");
				//CAMBIOS A HECHOS EN LA VERSION 4, AÑADIR LOS CODIGO/ A LA RESPUESTA
				strcat(notificacion, "-1");
				//fflush(stdin);
			}
			//Enviamos respuesta
			write(sock_conn,notificacion, strlen(notificacion));
			printf("Enviado por %d: %s\n", sock_conn, notificacion);
		}
		else if(codigo == 2){     //Obtenemos donde ha ganado el usuario
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			strcpy (consulta,"SELECT partida.lugar FROM partida WHERE partida.ganador = '"); 
			strcat (consulta, nombre);
			strcat (consulta,"'");
			// hacemos la consulta 
			err=mysql_query (conn, consulta); 
			if (err!=0){
				printf ("Error al consultar datos de la base %u %s\n",mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			resultado = mysql_store_result (conn); 			//recogemos el resultado de la consulta 
			row = mysql_fetch_row (resultado);
			if (row == NULL){
				printf ("No se han obtenido datos en la consulta\n");
				sprintf(respuesta, "%s", "2/-1");
			}
			else{
				// El resultado debe ser una matriz con una sola fila
				// y una columna que contiene el nombre
				printf ("%s ha ganado en %s\n", nombre, row[0]);
				//sprintf(respuesta,"%s","");
				sprintf(respuesta,"2/%s", row[0]);
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
		else if(codigo == 4){    //Log in del cliente
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			p =  strtok(NULL, "/");
			strcpy (pass, p);			
			strcpy (consulta, "SELECT jugador.nombre FROM jugador WHERE jugador.nombre = '");
			strcat (consulta, nombre);
			strcat (consulta, "' AND jugador.pass= '");
			strcat (consulta, pass);
			strcat (consulta, "'");
			err=mysql_query (conn, consulta);
			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			if(row == NULL){
				printf ("Los datos son incorrectos\n");
				sprintf(respuesta, "%s", "4/-1");
				//Enviamos respuesta
				write(sock_conn,respuesta, strlen(respuesta));
			}
			else{
				printf("%s se ha logueado correctamente\n", row[0]);
				sprintf(respuesta, "%s", "4");
				addConectado(&conect, nombre, sock_conn);
				//Enviamos una notificación cuando alguien se conecta creamos la lista de conectados
				strcpy(notificacion,respuesta);
				for(c=0; c<conect.num;c++){
					strcat(notificacion,"/");
					strcat(notificacion, conect.jugadores[c].nom);
				}
				printf("Se envia a todos %d conectados %s\n", conect.num, notificacion);
				for(c=0; c<conect.num;c++)
					write(sockets[c],notificacion, strlen(notificacion));
			}
		}
		else if(codigo == 5){   //Un usuario se esta registrando 
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			p =  strtok(NULL, "/");
			strcpy (pass, p);
			p =  strtok(NULL, "/");
			edad = atoi(p);
			p =  strtok(NULL, "/");
			strcpy (ciudad,p);
			printf("La edad es: %d \n", edad);
			strcpy (consulta, "Insert INTO jugador (nombre, pass, edad, ciudad) VALUES ('");
			strcat(consulta, nombre);
			strcat(consulta, "','");
			strcat(consulta, pass);
			strcat(consulta, "',");
			sprintf(consulta,"%s %d", consulta,edad);
			strcat(consulta, ",'");
			strcat(consulta, ciudad);
			strcat(consulta, "');");
			err=mysql_query (conn, consulta);
			if (err!=0){ //errr al regitrar{
				printf("Error introduciendo datos\n");
				exit (1);
			}
			resultado = mysql_store_result(conn);
			if (row == NULL){							//Se ha registrado el usuario
				printf("%s se ha registrado correctamente\n", nombre);
				sprintf(respuesta, "%s", "5/1");
			}
			else{										//No se ha podido registrar
				printf ("No te has registrado correctamente\n");
				sprintf(respuesta, "%s", "5/-1");
				// cerrar la conexion con el servidor MYSQL 
			}
		}
		else if(codigo == 6){ //Lista de conectados
			//printf("Respuesta lista conectados: %s\n",consulta);
			int res = DameConectados(&conect,misConectados);
			sprintf (respuesta, "6/%s",misConectados);
			printf("%s\n",respuesta);
			//Enviamos respuesta
			int j=0;
			for(j=0; j<conect.num; j++){
				write(sock_conn,respuesta, strlen(respuesta));
			}
		}
		else if(codigo == 8){
			char nombre1[20];
			p = strtok( NULL, "/");
			strcpy (nombre1, p);
			int res = DameConectados(&conect,misConectados);
			//sprintf (temporal,"%s%s/",temporal,con->jugadores[i].nom);
			if (res == -1){
				printf("No hay usuarios conectados\n");
				sprintf(respuesta, "8/%s", "0");
			}
			else{
				res = BuscaConectados(&conect, misConectados, nombre1);
				sprintf(respuesta,"8/%d/\n", res);
			}
			//Enviamos respuesta
			// Ya tenemos el nombre
			write (sock_conn,respuesta, strlen(respuesta));
		}
		else if(codigo == 9){
			char texto[100];
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			p = strtok( NULL, "/");
			strcpy(texto,p);
			sprintf(respuesta, "9/%s/%s\n",nombre, texto);
			for(c=0; c<conect.num;c++)
				write(sockets[c],respuesta, strlen(respuesta));
		}
		else if(codigo==10){
			char invitado[100];
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			p = strtok( NULL, "/");
			strcpy (invitado, p);
			socket_invita = DameSocket(&conect,nombre,sock_conn);
			socket_invitado = DameSocket(&conect,invitado,sock_conn);
			sprintf(respuesta, "10/%d/%s", socket_invitado,nombre);
			printf ("Respuesta: %s\n", respuesta);
			write(sockets[socket_invitado],respuesta, strlen(respuesta));
		}
		else if(codigo ==11){
			p=strtok(NULL, "/");
			char decision[20];
			strcpy(decision, p);
			if(decision == "si"){
				pthread_mutex_lock(&mutex);
				lchats.num++;
				pthread_mutex_unlock(&mutex);
			}
			sprintf(respuesta,"11/%s", decision);
			write(sockets[socket_invita], respuesta, strlen(respuesta));
		}
		else if(codigo == 12){
			int encontrado=0;
			char texto[100];
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			// Ya tenemos el nombre
			p = strtok( NULL, "/");
			strcpy(texto,p);
			sprintf(respuesta, "12/%s/%s\n",nombre, texto);
			for(c=0; c<lchats.num;c++){
				if(((strcmp(lchats->chats[c].socket_invita,nombre)==0) || (strcmp(lchats->chats[c].socket_invitado,nombre)==0))&& encontrado=0){
				write(sockets[lchats->chats[c].socket_invita], respuesta, strlen(respuesta));
				write(sockets[lchats->chats[c].socket_invitado], respuesta, strlen(respuesta));
				encontrado=1;
				}
			}
		}
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
}
int main(int argc, char *argv[]) 
{	
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	// INICIALITZACIONS
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)			// Obrim el socket		
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	serv_adr.sin_port = htons(50001);	// Establecemos el puerto de escucha ----------------------
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind\n");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen\n");
	pthread_t thread[10];
	//si va mal cambiar por pthread_t thread;
	//Bucle para atender a 5 clientes
	int cont;
	for(cont=0;cont<8;cont++){
		printf("Escuchando\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido conexion\n");
		sockets[cont] = sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		//Crear thread y decirle lo que tiene que hacer
		pthread_create(&thread[cont], NULL, AtenderCliente, &sockets[cont]);
	}	
	//pthread_join (thread[cont],NULL);
}

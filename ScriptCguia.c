#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
	
int main(int argc, char *argv[]) {
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	
	char Peticion[512];
	char Respuesta[512];
	
	if(( sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
		printf("Error1");
		exit(1);
	}
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	serv_adr.sin_port=htons(9000);
	
	if(bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0) {
		printf("error2");
		exit(1);
	}
	if(listen(sock_listen, 3) < 0) {
		printf("error3");
		exit(1);
	}
	int i;
	for (;;){
		printf("escuchando...\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("he recibido conexion");
		int terminar = 0;
		while (terminar==0){
			ret = read(sock_conn, Peticion, sizeof(Peticion));
			Peticion[ret]='\0';
			char *p = strtok(Peticion, "/");
			int codigo = atoi(p);
			p = strtok(NULL, "/");
			char nombre[20];
			strcpy(nombre, p);
			if (codigo == 0){
				terminar =1;
			}
			else if(codigo == 1){
				sprintf(Respuesta, "%d", strlen(nombre));
			}
			else if(codigo == 2){
				if (strcmp(nombre, "M") == 0)
					sprintf(Respuesta, "SI");
				else{
					sprintf(Respuesta, "NO");
				}
			}
			else{
				p = strtok(NULL, "/");
				float altura = atof(p);
				if (altura > 1.80)
					sprintf(Respuesta, "es alto");
				else{
					sprintf(Respuesta, "es bajo");
				}
			}
		}
		write(sock_conn, Respuesta, strlen(Respuesta));
		close(sock_conn);
	}
	
	close(sock_listen);
	
	return 0;
}
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<ctype.h>

struct Provincia {
	int codigo;
	char nombre[30];
	struct Provincia *siguiente;
};

struct Comunidad {
	int codigo;
	char nombre[30];
	char representante[25];
	int codigoProvincia;
	struct Comunidad *siguiente;
};

struct Habitante {
	char cedula[10];
	char apellido[15];
	char nombre[15];
	int codigoComunidad;
	struct Habitante *siguiente;
};

struct Consumo {
	int codigoComunidad;
	char cedula[10];
	int mes;
	double m3;
	double valor;
	struct Consumo *siguiente;
};

struct Provincia *listaProvincia=NULL;
struct Comunidad *listaComunidad=NULL;
struct Habitante *listaHabitante=NULL;
struct Consumo *listaConsumo=NULL;

void cargarArchivos() {
	FILE *f;
	int cod, codP, codC, mes;
	double m3, val;
	char nom[30] = "";
	char ced[10] = "";
	char ape[15] = "";
	char nomb[15] = "";
	char rep[25] = "";
	char tipo[1] = "";
	struct Provincia *p = NULL;
	struct Comunidad *c = NULL;
	struct Habitante *h = NULL;
	struct Consumo *m = NULL;

	f = fopen("datos.txt", "r");
	while (!feof(f))
	{
		fflush(stdin);
		fscanf(f, "%s", tipo, sizeof(tipo));
		if (strcmp(tipo, "P") == 0) {
			fscanf(f, "%d:%s\n", &cod, nom, sizeof(nom));
			fflush(stdin);
			p = (struct Provincia*)malloc(sizeof(struct Provincia));
			p->codigo = cod;
			strcpy(p->nombre, nom);
			p->siguiente = NULL;

			if (listaProvincia == NULL) {
				listaProvincia = p;
			}
			else
			{
				struct Provincia *temporal;
				struct Provincia *anterior;
				temporal = listaProvincia;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = p;
			}
		}
		if (strcmp(tipo, "C") == 0) {
			fscanf(f, "%d:%s:%s%d\n", &cod, nom, rep, &codP);
			fflush(stdin);
			c = (struct Comunidad*)malloc(sizeof(struct Comunidad));
			c->codigo = cod;
			strcpy(c->nombre, nom);
			strcpy(c->representante, rep);
			c->codigoProvincia = codP;
			c->siguiente = NULL;

			if (listaComunidad == NULL) {
				listaComunidad = c;
			}
			else
			{
				struct Comunidad *temporal;
				struct Comunidad *anterior;
				temporal = listaComunidad;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = c;
			}
		}
		if (strcmp(tipo, "H") == 0) {
			fscanf(f, "%s:%s:%s%d\n", ced, ape, nomb, &codC);
			fflush(stdin);
			h = (struct Habitante*)malloc(sizeof(struct Habitante));
			strcpy(h->cedula, ced);
			strcpy(h->apellido, ape);
			strcpy(h->nombre, nomb);
			h->codigoComunidad = codC;
			h->siguiente = NULL;

			if (listaHabitante == NULL) {
				listaHabitante = h;
			}
			else
			{
				struct Habitante *temporal;
				struct Habitante *anterior;
				temporal = listaHabitante;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = h;
			}
		}
		if (strcmp(tipo, "M") == 0) {
			fscanf(f, "%d:%s:%d:%lf:%lf\n", &codC, ced, &mes, &m3, &val);
			fflush(stdin);
			m = (struct Consumo*)malloc(sizeof(struct Consumo));
			m->codigoComunidad = codC;
			strcpy(m->cedula, ced);
			m->mes = mes;
			m->m3 = m3;
			m->valor = val;
			m->siguiente = NULL;

			if (listaConsumo == NULL) {
				listaConsumo = m;
			}
			else
			{
				struct Consumo *temporal;
				struct Consumo *anterior;
				temporal = listaConsumo;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = m;
			}
		}
	}
	fclose(f);


	printf("\n\n\n");
	printf("\n     ********************************");
	printf("\n       Datos Cargados desde Archivo ");
	printf("\n     ********************************\n\n\n");
	system("pause");

}

void guardarArchivos() {
	FILE *f;
	struct Provincia *p;
	struct Comunidad *c;
	struct Habitante *h;
	struct Consumo *m;

	// Guardar Provincia
	f = fopen("datos.txt", "w");
	p = listaProvincia;
	while (p != NULL)
	{
		fprintf(f, "P\n");
		fprintf(f, "%d:%s\n", p->codigo, p->nombre);
		fflush;
		//if (p->siguiente != NULL) fprintf(f, "\n");
		p = p->siguiente;
	}
	
	// Guardar Comunidad
	c = listaComunidad;
	while (c != NULL)
	{
		fprintf(f, "C\n");
		fprintf(f, "%d:%s:%s:%d\n", c->codigo, c->nombre, c->representante, c->codigoProvincia);
		fflush;
		//if (c->siguiente != NULL) fprintf(f, "\n");
		c = c->siguiente;
	}
	
	// Guardar Habitante
	h = listaHabitante;
	while (h != NULL)
	{
		fprintf(f, "H\n");
		fprintf(f, "%s:%s:%s:%d\n", h->cedula, h->apellido, h->nombre, h->codigoComunidad);
		fflush;
		//if (h->siguiente != NULL) fprintf(f, "\n"); 
		h = h->siguiente;
	}

	// Guardar Consumo
	m = listaConsumo;
	while (m != NULL)
	{
		fprintf(f, "M\n");
		fprintf(f, "%d:%s:%d:%lf:%lf\n", m->codigoComunidad, m->cedula, m->mes, m->m3, m->valor);
		fflush;
		//if (m->siguiente != NULL) fprintf(f, "\n");
		m = m->siguiente;
	}
	fclose(f);

	system("cls");
	printf("\n\n\n");
	printf("\n     ==============================");
	printf("\n       Datos Guardados en Archivo ");
	printf("\n     ==============================\n\n\n");
	system("pause");
}

void menuProvincia() {
	int opcion, cod, se_encontro, contador;
	char nom[30];
	struct Provincia *p;
	do
	{
		system("cls");
		printf("\n ============================");
		printf("\n  MANTENIMIENTO DE PROVINCIA");
		printf("\n ============================");
		printf("\n 1. Registrar Provincia");
		printf("\n 2. Modificar Provincia");
		printf("\n 3. Eliminar Provincia");
		printf("\n 4. Listar Provincias");
		printf("\n 5. Regresar");
		printf("\n\n   Introduzca Opcion (1-5): ");
		scanf_s("%d", &opcion);
		switch (opcion)
		{
		case 1:
			printf("\n Registre el codigo de provincia: ");
			scanf_s("%d", &cod);
			fflush(stdin);
			printf("\n Registre el nombre de provincia: ");
			scanf_s("%s", nom, sizeof(nom));
			fflush(stdin);
			p = (struct Provincia*)malloc(sizeof(struct Provincia));
			p->codigo = cod;
			strcpy(p->nombre, nom);
			p->siguiente = NULL;

			if (listaProvincia == NULL) {
				listaProvincia = p;
			}
			else
			{
				struct Provincia *temporal;
				struct Provincia *anterior;
				temporal = listaProvincia;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = p;
			}
			printf("\n ->Provincia Creada!!\n\n");
			system("pause");
			break;
		case 2:
			printf("\n Ingrese el codigo de provincia a modificar: ");
			scanf_s("%d", &cod);
			se_encontro = 0;

			p = listaProvincia;
			while (p != NULL)
			{
				if (cod == p->codigo)
				{
					printf("\n Nombre Actual: %s", p->nombre);
					printf("\n Ingrese Nuevo nombre de provincia: ");
					scanf_s("%s", nom, sizeof(nom));
					strcpy(p->nombre , nom);
					printf("\n ->Provincia Actualizada!!\n\n");
					se_encontro = 1;
				}
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se modifico ninguna provincia. Codigo no encontrado!\n\n");
			}
			system("pause");
			break;
		case 3:
			printf("\n Ingrese el codigo de provincia a eliminar: ");
			scanf_s("%d", &cod);
			se_encontro = 0;
			contador = 1;
			struct Provincia *anterior;

			p = listaProvincia;
			while (p != NULL)
			{
				if (cod == p->codigo)
				{
					if (contador == 1) {
						if (p->siguiente != NULL) {
							listaProvincia = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							listaProvincia = NULL;
						}
					}
					if (contador>1)
					{
						if (p->siguiente != NULL) {
							anterior->siguiente = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							anterior->siguiente = NULL;
							p->siguiente = NULL;
						}
					}
					printf("\n ->Provincia Eliminada!!\n\n");
					se_encontro = 1;
				}
				contador = contador + 1;
				anterior = p;
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se elimino ninguna provincia. Codigo no encontrado!\n\n");
			}
			system("pause");
			break;
		case 4:
			printf("\n Listado de Provincias\n");
			p = listaProvincia ;
			while (p != NULL)
			{
				printf("Codigo: %d, Nombre: %s\n", p->codigo , p->nombre);
				p = p->siguiente;
			}
			printf("\n ---------------------------\n\n");
			system("pause");
			break;
		}
	} while (opcion != 5);
}

void menuComunidad() {
	int opcion, cod, codPro, se_encontro, contador;
	char nom[30];
	char rep[30];
	struct Comunidad *p;
	do
	{
		system("cls");
		printf("\n ============== == ==========");
		printf("\n  MANTENIMIENTO DE COMUNIDAD");
		printf("\n ============== == ==========\n");
		printf("\n 1. Registrar Comunidad");
		printf("\n 2. Modificar Comunidad");
		printf("\n 3. Eliminar Comunidad");
		printf("\n 4. Listar Comunidades");
		printf("\n 5. Regresar");
		printf("\n\n   Introduzca Opcion (1-5): ");
		scanf_s("%d", &opcion);
		switch (opcion)
		{
		case 1:
			fflush(stdin);
			printf("\n Registre el codigo de la comunidad: ");
			scanf_s("%d", &cod);
			fflush(stdin);
			printf("\n Registre el nombre de la comunidad: ");
			scanf_s("%s", nom, sizeof(nom));
			fflush(stdin);
			printf("\n Registre el nombre del representante: ");
			scanf_s("%s", rep, sizeof(rep));
			fflush(stdin);
			printf("\n Registre el codigo de la provincia: ");
			scanf_s("%d", &codPro);
			fflush(stdin);
			p = (struct Comunidad*)malloc(sizeof(struct Comunidad));
			p->codigo = cod;
			strcpy(p->nombre, nom);
			strcpy(p->representante, rep);
			p->codigoProvincia = codPro;
			p->siguiente = NULL;

			if (listaComunidad == NULL) {
				listaComunidad = p;
			}
			else
			{
				struct Comunidad *temporal;
				struct Comunidad *anterior;
				temporal = listaComunidad;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = p;
			}
			printf("\n ->Comunidad Creada!!\n\n");
			system("pause");
			break;
		case 2:
			fflush(stdin);
			printf("\n Ingrese el codigo de comunidad a modificar: ");
			scanf_s("%d", &cod);
			fflush(stdin);
			se_encontro = 0;

			p = listaComunidad;
			while (p != NULL)
			{
				if (cod == p->codigo)
				{
					printf("\n Nombre Actual: %s", p->nombre);
					printf("\n Ingrese Nuevo nombre de comunidad: ");
					scanf_s("%s", nom, sizeof(nom));
					fflush(stdin);
					printf("\n Representante Actual: %s", p->representante);
					printf("\n Registre el nombre del representante: ");
					scanf_s("%s", rep, sizeof(rep));
					fflush(stdin);
					printf("\n Codigo de Provincia Actual: %d", p->codigoProvincia);
					printf("\n Registre el codigo de la provincia: ");
					scanf_s("%d", &codPro);
					fflush(stdin);
					strcpy(p->nombre, nom);
					strcpy(p->representante, rep);
					p->codigoProvincia = codPro;
					printf("\n ->Comunidad Actualizada!!\n\n");
					se_encontro = 1;
				}
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se modifico ninguna comunidad. Codigo no encontrado!\n\n");
			}
			system("pause");
			break;
		case 3:
			printf("\n Ingrese el codigo de comunidad a eliminar: ");
			scanf_s("%d", &cod);
			se_encontro = 0;
			contador = 1;
			struct Comunidad *anterior;

			p = listaComunidad;
			while (p != NULL)
			{
				if (cod == p->codigo)
				{
					if (contador == 1) {
						if (p->siguiente != NULL) {
							listaComunidad = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							listaComunidad = NULL;
						}
					}
					if (contador>1)
					{
						if (p->siguiente != NULL) {
							anterior->siguiente = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							anterior->siguiente = NULL;
							p->siguiente = NULL;
						}
					}
					printf("\n ->Comunidad Eliminada!!\n\n");
					se_encontro = 1;
				}
				contador = contador + 1;
				anterior = p;
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se elimino ninguna comunidad. Codigo no encontrado!\n\n");
			}
			system("pause");
			break;
		case 4:
			printf("\n Listado de Comunidades\n");
			p = listaComunidad;
			while (p != NULL)
			{
				printf("Codigo: %d, Nombre: %s, Representante: %s, Codigo de Provincia: %d\n", p->codigo, p->nombre, p->representante, p->codigoProvincia);
				p = p->siguiente;
			}
			printf("\n ---------------------------\n\n");
			system("pause");
			break;
		}
	} while (opcion != 5);
}

void menuHabitante() {
	int opcion, cod, se_encontro, contador;
	char ced[10];
	char ape[25];
	char nom[25];
	struct Habitante *p;
	do
	{
		system("cls");
		printf("\n ============== == ==========");
		printf("\n  MANTENIMIENTO DE HABITANTE");
		printf("\n ============== == ==========\n");
		printf("\n 1. Registrar Habitante");
		printf("\n 2. Modificar Habitante");
		printf("\n 3. Eliminar Habitante");
		printf("\n 4. Listar Habitante");
		printf("\n 5. Regresar");
		printf("\n\n   Introduzca Opcion (1-5): ");
		scanf_s("%d", &opcion);
		switch (opcion)
		{
		case 1:
			fflush(stdin);
			printf("\n Registre la cedula del habitante: ");
			scanf_s("%s", ced, sizeof(ced));
			fflush(stdin);
			printf("\n Registre el apellido del habitante: ");
			scanf_s("%s", ape, sizeof(ape));
			fflush(stdin);
			printf("\n Registre el nombre del habitante: ");
			scanf_s("%s", nom, sizeof(nom));
			fflush(stdin);
			printf("\n Registre el codigo de la comunidad: ");
			scanf_s("%d", &cod);
			fflush(stdin);
			p = (struct Habitante*)malloc(sizeof(struct Habitante));
			strcpy(p->cedula, ced);
			strcpy(p->apellido, ape);
			strcpy(p->nombre, nom);
			p->codigoComunidad = cod;
			p->siguiente = NULL;

			if (listaHabitante == NULL) {
				listaHabitante = p;
			}
			else
			{
				struct Habitante *temporal;
				struct Habitante *anterior;
				temporal = listaHabitante;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = p;
			}
			printf("\n ->Habitante Creado!!\n\n");
			system("pause");
			break;
		case 2:
			fflush(stdin);
			printf("\n Ingrese la cedula del habitante a modificar: ");
			scanf_s("%s", ced, sizeof(ced));
			fflush(stdin);
			se_encontro = 0;

			p = listaHabitante;
			while (p != NULL)
			{
				if (ced == p->cedula)
				{
					printf("\n Apellido Actual: %s", p->apellido);
					printf("\n Registre el apellido del habitante: ");
					scanf_s("%s", ape, sizeof(ape));
					fflush(stdin);
					printf("\n Nombre Actual: %s", p->nombre);
					printf("\n Registre el nombre del habitante: ");
					scanf_s("%s", nom, sizeof(nom));
					fflush(stdin);
					printf("\n Codigo de la Comunidad Actual: %s", p->codigoComunidad);
					printf("\n Registre el codigo de la comunidad: ");
					scanf_s("%d", &cod);
					fflush(stdin);
					strcpy(p->apellido, ape);
					strcpy(p->nombre, nom);
					p->codigoComunidad = cod;
					printf("\n ->Habitante Actualizada!!\n\n");
					se_encontro = 1;
				}
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se modifico ningun habitante. Cedula no encontrada!\n\n");
			}
			system("pause");
			break;
		case 3:
			printf("\n Ingrese la cedula del habitante a eliminar: ");
			scanf_s("%s", ced, sizeof(ced));
			se_encontro = 0;
			contador = 1;
			struct Habitante *anterior;

			p = listaHabitante;
			while (p != NULL)
			{
				if (ced == p->cedula)
				{
					if (contador == 1) {
						if (p->siguiente != NULL) {
							listaHabitante = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							listaHabitante = NULL;
						}
					}
					if (contador>1)
					{
						if (p->siguiente != NULL) {
							anterior->siguiente = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							anterior->siguiente = NULL;
							p->siguiente = NULL;
						}
					}
					printf("\n ->Habitante Eliminada!!\n\n");
					se_encontro = 1;
				}
				contador = contador + 1;
				anterior = p;
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se elimino ningun habitante. Cedula no encontrada!\n\n");
			}
			system("pause");
			break;
		case 4:
			printf("\n Listado de Habitantees\n");
			p = listaHabitante;
			while (p != NULL)
			{
				printf("Cedula: %s, Apellido: %s, Nombre: %s, Codigo de Provincia: %d\n", p->cedula, p->apellido, p->nombre, p->codigoComunidad);
				p = p->siguiente;
			}
			printf("\n ---------------------------\n\n");
			system("pause");
			break;
		}
	} while (opcion != 5);
}

void menuConsumo() {
	int opcion, cod, mes, se_encontro, contador;
	char ced[10];
	double m3;
	struct Consumo *p;
	do
	{
		system("cls");
		printf("\n ==========================");
		printf("\n  MANTENIMIENTO DE CONSUMO");
		printf("\n ==========================\n");
		printf("\n 1. Registrar Consumo");
		printf("\n 2. Modificar Consumo");
		printf("\n 3. Eliminar Consumo");
		printf("\n 4. Listar Consumo");
		printf("\n 5. Regresar");
		printf("\n\n   Introduzca Opcion (1-5): ");
		scanf_s("%d", &opcion);
		switch (opcion)
		{
		case 1:
			fflush(stdin);
			printf("\n Registre el codigo de la comunidad: ");
			scanf_s("%d", &cod);
			fflush(stdin);
			printf("\n Registre la cedula del consumo: ");
			scanf_s("%s", ced, sizeof(ced));
			fflush(stdin);
			printf("\n Registre el mes del consumo: ");
			scanf_s("%d", &mes);
			fflush(stdin);
			printf("\n Registre los metros cubicos (m3) del consumo: ");
			scanf_s("%lf", &m3);
			fflush(stdin);
			p = (struct Consumo*)malloc(sizeof(struct Consumo));
			p->codigoComunidad = cod;
			strcpy(p->cedula, ced);
			p->mes = mes;
			p->m3 = m3;
			p->valor = 0;
			p->siguiente = NULL;

			if (listaConsumo == NULL) {
				listaConsumo = p;
			}
			else
			{
				struct Consumo *temporal;
				struct Consumo *anterior;
				temporal = listaConsumo;
				while (temporal != NULL)
				{
					anterior = temporal;
					temporal = temporal->siguiente;
				}
				anterior->siguiente = p;
			}
			printf("\n ->Consumo Creado!!\n\n");
			system("pause");
			break;
		case 2:
			fflush(stdin);
			printf("\n Registre el codigo de la comunidad a modificar: ");
			scanf_s("%d", &cod);
			fflush(stdin);
			printf("\n Ingrese la cedula del consumo a modificar: ");
			scanf_s("%s", ced, sizeof(ced));
			fflush(stdin);
			se_encontro = 0;

			p = listaConsumo;
			while (p != NULL)
			{
				if ((cod == p->codigoComunidad) && (ced == p->cedula))
				{
					printf("\n Mes del Consumo Actual: %s", p->mes);
					printf("\n Registre el mes del consumo: ");
					scanf_s("%d", &mes);
					fflush(stdin);
					printf("\n Metros Cubicos del Consumo Actual: %lf", p->m3);
					printf("\n Registre los metros cubicos (m3) del consumo: ");
					scanf_s("%lf", &m3);
					fflush(stdin);
					p->mes = mes;
					p->m3 = m3;
					printf("\n ->Consumo Actualizado!!\n\n");
					se_encontro = 1;
				}
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se modifico ningun consumo. Codigo de Comunidad o Cedula no encontrada!\n\n");
			}
			system("pause");
			break;
		case 3:
			fflush(stdin);
			printf("\n Registre el codigo de la comunidad a eliminar: ");
			scanf_s("%d", &cod);
			fflush(stdin);
			printf("\n Ingrese la cedula del consumo a eliminar: ");
			scanf_s("%s", ced, sizeof(ced));
			fflush(stdin);
			se_encontro = 0;
			contador = 1;
			struct Consumo *anterior;

			p = listaConsumo;
			while (p != NULL)
			{
				if ((cod == p->codigoComunidad) && (ced == p->cedula))
				{
					if (contador == 1) {
						if (p->siguiente != NULL) {
							listaConsumo = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							listaConsumo = NULL;
						}
					}
					if (contador>1)
					{
						if (p->siguiente != NULL) {
							anterior->siguiente = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							anterior->siguiente = NULL;
							p->siguiente = NULL;
						}
					}
					printf("\n ->Consumo Eliminada!!\n\n");
					se_encontro = 1;
				}
				contador = contador + 1;
				anterior = p;
				p = p->siguiente;
			}
			if (se_encontro == 0)
			{
				printf("\n ->No se elimino ningun consumo. Codigo de Comunidad o Cedula no encontrada!\n\n");
			}
			system("pause");
			break;
		case 4:
			printf("\n Listado de Consumos\n");
			p = listaConsumo;
			while (p != NULL)
			{
				printf("Codigo de la Comunidad: %d, Cedula: %s, Mes: %d, M3 Consumidos: %lf, Valor Consumo: %lf\n", p->codigoComunidad, p->cedula, p->mes, p->m3, p->valor);
				p = p->siguiente;
			}
			printf("\n ---------------------------\n\n");
			system("pause");
			break;
		}
	} while (opcion != 5);
}

void calcularConsumo() {

}

void ListadoHabitantes() {

}

void ListadoConsumos() {

}

void main()
{
	int opcion, n, encontro, contador;
	int veces = 1;
	char nom[30];

	// Recuperamos la información guardada en los archivos y lo cargamos en las estructuras
	cargarArchivos();

	do
	{
		system("cls");
		printf("\n =======================================");
		printf("\n   PROYECTO INTEGRADOR CONSUMO DE AGUA");
		printf("\n =======================================");
		printf("\n 1. Mantenimiento de Provincia");
		printf("\n 2. Mantenimiento de Comunidad");
		printf("\n 3. Mantenimiento de Habitante");
		printf("\n 4. Mantenimiento de Consumo");
		printf("\n -----------------------------");
		printf("\n 5. Calcular los valores de consumo");
		printf("\n 6. Listado de Habitantes y Comunidad");
		printf("\n 7. Listado de Consumos por Habitantes y Mes");
		printf("\n 8. Salir");
		
		printf("\n\n   Introduzca Opcion (1-8): ");
		scanf_s("%d", &opcion);
		switch (opcion)
		{
		case 1:
			menuProvincia();
			break;
		case 2:
			menuComunidad();
			break;
		case 3:
			menuHabitante();
			break;
		case 4:
			menuConsumo();
			break;
		case 5:
			calcularConsumo();
			break;
		case 6:
			ListadoHabitantes();
			break;
		case 7:
			ListadoConsumos();
			break;
		}
		
	} while (opcion != 8);

	// Guardamos los datos de las listas en los archivos
	guardarArchivos();
}
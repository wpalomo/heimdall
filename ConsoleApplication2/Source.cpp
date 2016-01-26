#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<ctype.h>

struct Provincia {
	int cod_prov;
	char nomb_pro[30];
	struct Provincia *siguiente;
};

struct Provincia *InicioProvincia;
struct Provincia *p;
struct Provincia *tmp;
struct Provincia *anterior;

void main()
{
	int opcion, n, encontro, contador;
	int veces = 1;
	char nom[30];
	do
	{
		system("cls");
		printf("\n 1. Registrar Provincia:");
		printf("\n 2. Modificar Provincia:");
		printf("\n 3. Eliminar Provincia:");
		printf("\n 4. Listar Provincias:");
		printf("\n 5. Salir");
		printf("\n\n   Introduzca Opcion (1-4): ");
		scanf_s("%d", &opcion);
		switch (opcion)
		{
		case 1:
			printf("\n Registre el codigo de provincia: ");
			scanf_s("%d", &n);
			printf("\n Registre el nombre de provincia: ");
			scanf_s("%s", nom, sizeof(nom));
			p = (struct Provincia*)malloc(sizeof(struct Provincia));
			p->cod_prov = n;
			strcpy(p->nomb_pro, nom);
			p->siguiente = NULL;

			if (veces == 1) {
				InicioProvincia = p;
			}
			else
			{
				tmp = InicioProvincia;
				while (tmp != NULL)
				{
					anterior = tmp;
					tmp = tmp->siguiente;
				}
				anterior->siguiente = p;
			}
			veces = veces + 1;
			printf("Provincia Creada!\n\n");
			break;

		case 2:
			printf("\n Ingrese el codigo de provincia a modificar: ");
			scanf_s("%d", &n);
			encontro = 0;

			p = InicioProvincia;
			while (p != NULL)
			{
				if (n == p->cod_prov)
				{
					printf("\n Ingrese nombre de provincia: ");
					scanf_s("%s", nom, sizeof(nom));
					strcpy(p->nomb_pro, nom);
					printf("\n Provincia Actualizada!\n\n");
					encontro = 1;
				}
				p = p->siguiente;
			}
			if (encontro == 0)
			{
				printf("\n No se modifico ninguna provincia. Codigo no encontrado!\n\n");
			}
			break;

		case 3:
			printf("\n Ingrese el codigo de provincia a eliminar: ");
			scanf_s("%d", &n);
			encontro = 0;
			contador = 1;

			p = InicioProvincia;
			while (p != NULL)
			{
				if (n == p->cod_prov)
				{
					if (contador == 1) {
						if (p->siguiente != NULL) {
							InicioProvincia = p->siguiente;
							p->siguiente = NULL;
						}
						else
						{
							InicioProvincia = NULL;
							veces = 1;
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
					printf("\n Provincia Eliminada!\n\n");
					encontro = 1;
				}
				contador = contador + 1;
				anterior = p;
				p = p->siguiente;
			}
			if (encontro == 0)
			{
				printf("\n No se elimino ninguna provincia. Codigo no encontrado!\n\n");
			}
			break;

		case 4:
			printf("\n Listado de Provincias\n");
			p = InicioProvincia;
			while (p != NULL)
			{
				printf("Codigo: %d, Nombre: %s\n", p->cod_prov, p->nomb_pro );
				p = p->siguiente;
			}
			printf("\n ---------------------------\n\n");
			break;
		}
		system("pause");
	} while (opcion != 5);
}
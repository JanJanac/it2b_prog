#include <stdio.h>

void trojuhelnik(int vyska, char znak, int kolik) {
	for (int k = 0; k < kolik; k++) {
		for (int i = 1; i <= vyska; i++) {
			for (int l = 0; l < i; l++) {
				printf(" %c", znak);
			}
		printf("\n");
		}
	}
	
}	

void stojan(int stojanvyska, char stojanznak) {
	for (int i = 0; i < stojanvyska;  i++) {
		printf(" %c\n", stojanznak);
	}
	printf(" %c %c %c", stojanznak, stojanznak, stojanznak);
}

int main() {

	int uzivatelvyska;
	char uzivatelznak;
	int uzivatelkolik;

	int uzivatelstojanvyska;
	char uzivatelstojanznak;

	printf("Zadej znak z ktereho chces stromek: ");
	scanf_s(" %c", &uzivatelznak);

	printf("Zadej jak vysoky chces jeden trojuhelnik stromku: ");
	scanf_s(" %d", &uzivatelvyska);

	printf("Zadej kolik chces trojuhelniku stromku: ");
	scanf_s(" %d", &uzivatelkolik);

	printf("Zadej znak z ktereho chces stojanu: ");
	scanf_s(" %c", &uzivatelstojanznak);

	printf("Zadej vysku stojanu: ");
	scanf_s(" %d", &uzivatelstojanvyska);

	trojuhelnik(uzivatelvyska, uzivatelznak, uzivatelkolik);
	stojan(uzivatelstojanvyska, uzivatelstojanznak);

	return 0;
}
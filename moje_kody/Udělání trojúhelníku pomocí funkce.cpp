#include <stdio.h>

void trojuhelnik(int vyska, char znak) {
	for (int i = 1; i <= vyska; i++) {
		for (int l = 0; l < i; l++) {
			printf(" %c", znak);
		}
		printf("\n");
	}
}	

int main() {

	int uzivatelvyska;
	char uzivatelznak;

	printf("Zadej znak z ktereho chces trojuhelnik: ");
	scanf_s(" %c", &uzivatelznak);

	printf("Zadej jak vysoky chces trojuhelnik: ");
	scanf_s(" %d", &uzivatelvyska);

	trojuhelnik(uzivatelvyska, uzivatelznak);

	return 0;
}
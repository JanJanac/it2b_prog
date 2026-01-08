#include <stdio.h>

void prestupnyRok(int rok) {
	int ctyri = rok % 4;
	int sto = rok % 100;
	int ctyrista = rok % 400;

	if (ctyri == 0) {
		if (sto == 0 && ctyrista != 0) {
			printf("Rok neni prestupny");
		} else {
			printf("Rok je prestupny");
		}
	} else {
		printf("Rok neni prestupny");
	}
}


int main() {

	prestupnyRok(2025);

	return 0;
}
#include <stdio.h>
#include <string.h>

int main() {

	char heslo[40];
	int pocetp = 0;
	int pocetP = 0;
	int pocetc = 0;
	int pocetz = 0;

	printf("Zadej svoje heslo:");
	scanf_s(" %39s", heslo, 39);

	int delka = strlen(heslo);

	for (int i = 0; i != delka; i++) {
		if ('A' <= heslo[i] && heslo[i] <= 'Z') {
			pocetP++;
		}
		if ('a' <= heslo[i] && heslo[i] <= 'z') {
			pocetp++;
		}
		if ('0' <= heslo[i] && heslo[i] <= '9') {
			pocetc++;
		}
		if (heslo[i] == '#' || heslo[i] == '.' || heslo[i] == ',' || heslo[i] == '/' || heslo[i] == '&' || heslo[i] == '|' || heslo[i] == '-' || heslo[i] == '_') {
			pocetz++;
		}
	}

	if (pocetP >= 2 && pocetp >= 3 && pocetc >= 1 && pocetz >= 1) {
		printf("Heslo je dostatecne silne");
	} else {
		printf("Heslo neni dostatecne silne");
	}

return 0;
}
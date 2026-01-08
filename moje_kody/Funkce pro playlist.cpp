#include <stdio.h>

int playlistDelka (int pole[], int delka) {
	int soucet = 0;
	for (int i = 0; i < delka; i++) {
		soucet += pole[i];
	}
	return soucet;
}

float playlistPrumer(int pole[], int delka) {
	int soucet = playlistDelka(pole, delka);
	return (float)soucet / delka;
}

int main() {

	int pole[] = {126, 189, 55, 302};

	printf("delka: %d \n", playlistDelka(pole, 4));
	printf("prumer: %.2f \n", playlistPrumer(pole, 4));

	return 0;
}
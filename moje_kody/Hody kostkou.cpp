#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {

	int kostky;
	int pocetstran;

	printf("Zadej kolik kostek chces: \n");
	scanf_s(" %d", &kostky);

	printf("Zadej kolik stran ma mit kostka: \n");
	scanf_s(" %d", &pocetstran);

	srand(time(NULL));

	for (int i = 1; i <= kostky; i++) {
		int cislo = rand() % pocetstran + 1;
		printf("Kostka %d: %d \n", i, cislo);
	}

return 0;

}
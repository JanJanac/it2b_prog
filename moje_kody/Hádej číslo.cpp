#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
	
	printf("Hadej cislo od 1 do 100\n");

	srand(time(NULL));
	int cislo = rand() % 101 + 1;

	int hadej = 0;
	
	for (int pokus = 0; hadej != cislo; pokus++) {
		printf("Zadej cislo: \n");
		scanf_s("%d", &hadej);

		if (hadej < cislo) {
			printf("Hadane cislo je vetsi\n");
		} else if (hadej > cislo) {
			printf("Hadane cislo je mensi\n");
		} else {
			printf("Gratuluji, uhadnul si cislo.\nNa %d. pokusu.\nHadane cislo bylo: %d\n", pokus, cislo);
		}
	}

return 0;

}
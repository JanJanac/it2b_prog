#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>

int main() {

	int pocetmax = 0;
	int nejcastejsi = 0;
	int soucet = 0;
	int nejhorznamka = 1;
	int nejlepznamka = 5;
	int znamky [10];
	srand(time(NULL));

	printf("Tvoje znamky:\n");

	for (int i = 0; i < 10; i++) {
		znamky[i] = rand() % 5 + 1;
		printf(" %d\n", znamky[i]);
		if (znamky[i] < nejlepznamka) {
			nejlepznamka = znamky[i];
		}
		if (znamky[i] > nejhorznamka) {
			nejhorznamka = znamky[i];
		}
		
		soucet = soucet + znamky[i];
		
		int pocet = 0;

		for (int j = 0; j < 10; j++) {
			if (znamky[i] == znamky[j]) {
				pocet++;
			}
			
			if (pocet > pocetmax) {
				pocetmax = pocet;
				nejcastejsi = znamky[i];
			}
		}
	}



	float prumer = (float) soucet / 10;

	printf("Nejlepsi znamka je: %d \n", nejlepznamka);
	printf("Nejhorsi znamka je: %d \n", nejhorznamka);
	printf("Tvuj prumer je: %.2f \n", prumer);
	printf("Tvoje znamka na vysvedceni je: %.0f \n", round(prumer));
	printf("Nejcastejsi znamka je: %d a vyskytla se: %dx\n", nejcastejsi, pocetmax);

	return 0;

}


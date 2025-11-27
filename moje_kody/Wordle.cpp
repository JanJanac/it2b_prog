#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main() {

	char slovo[6];
	int pocethadani = 0;
	char hadani[6];

	printf("Zadej slovo o 5 pismenach, ktere bude hadat druhy hrac: ");
	scanf_s(" %5s", slovo, 6);

	system("cls");

	printf("Slovo bylo zadane, hadej \n");

	while (1) {
		pocethadani++;

		printf("%d. Pokus, zadej slovo: ", pocethadani);
		scanf_s(" %5s", hadani, 6);

		if (strcmp(slovo, hadani) == 0) {
			printf("Gratuluji, uhodl jsi slovo '%s' po %d pokusech!\n", slovo, pocethadani);
			break;
		}
		
		for (int i = 0; i < 5; i++) {
			if (hadani[i] == slovo[i]) {
				printf("%c - spravne pismeno na spravnem miste\n", hadani[i]);
			}
			else if (strchr(slovo, hadani[i]) != NULL) {
				printf("%c - spravne pismeno na spatnem miste\n", hadani[i]);
			}
			else {
				printf("%c - spatne pismeno\n", hadani[i]);
			}
		}

		printf("\n");

	}

return 0;
}
#include <stdio.h>
#include <string.h>

int main() {

	char slovo[100];

	printf("Zadej slovo a ja ho zacenzuruju:");
	scanf_s(" %99s", &slovo);

	int delka = strlen(slovo);

	for (int i = 0; i < delka; i++) {
		if (i % 2) {
			printf("#");
		} else {
			printf(" %c", slovo[i]);
		}
	}

	return 0;
}
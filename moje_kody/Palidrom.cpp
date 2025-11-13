#include <stdio.h>
#include <string.h>

int main() {

	char str[40];
	int pocet = 0;

	printf("Zadej slovo: \n");
	scanf_s(" %39s", str, 39);

	int delka = strlen(str);

	for (int i = 0; i != delka; i++) {
		if (str[i] == str[delka - i - 1]) {
			pocet++;
		}
	}

	if (pocet == delka) {
		printf("Je to palidrom");
	}else {
		printf("Neni to palidrom");
	}

	return 0;
}
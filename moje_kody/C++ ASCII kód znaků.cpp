#include <stdio.h>
#include <string.h>

int main() {

	char vstup[40];

	printf("Zadej znaky pro vypsani ASCII kodu:");
	scanf_s(" %39s", vstup, 39);

	int delka = strlen(vstup);

	for (int i = 0; i < strlen(vstup); i++) {
		printf(" %c : %d\n", vstup[i], vstup[i]);
	}

return 0;
}
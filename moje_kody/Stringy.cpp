#include <stdio.h>

int main() {

	char pozdrav[] = "Ahoj";
	int delka = 0;
	char znak;
	int vyskyt = 0;

	printf("Zadej libovolny znak: ");
	scanf_s(" %c", &znak);

	while (pozdrav[delka] != '\0') {
		if (pozdrav[delka] == znak) {
			vyskyt++;
		} 
		delka++;
	}
	
	if (vyskyt > 0) {
		printf("Znak je ve stringu");
	} else {
		printf("Znak neni ve stringu");
	}


	while (pozdrav[delka] != '\0') {
		delka++;
	}

	printf("\nDelka stringu: %d", delka);
	printf("\nString byl: %s", pozdrav);
	
	return 0;
}
#include <stdio.h>
#include <string.h>

int main() {

	char znak;

	printf("Zadej jakykoliv znak:");
	scanf_s(" %c", &znak);

	if (65 <= znak && znak <= 90) {
		printf("Znak %c je velke pismeno", znak);
	}
	else {
		printf("Znak %c neni velke pismeno", znak);
	}

return 0;
}

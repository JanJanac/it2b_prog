#include <stdio.h>

float soucet(float x, float y) {
	return x + y;
}

void vypisPole(int pole[], int delka) {
	for (int i = 0; i < delka; i++) {
		printf("%d ", pole[i]);
	}
}

int main() {

	float vysledek = soucet(4, 3.5);
	printf("%f\n", vysledek);

	int pole[] = { 12, 55, 14, -8, 0 };
	int delka_pole = 5;

	vypisPole(pole, delka_pole);

	return 0;
}
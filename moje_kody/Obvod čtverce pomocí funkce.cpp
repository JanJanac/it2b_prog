#include <stdio.h>

float obvod(float a) {
	return 4 * a;
}

int main() {

	float delka;

	printf("Zadej delku strany:");
	scanf_s(" %f", &delka);

	printf("Obvod ctverce je: %f", obvod(delka));

	return 0;
}
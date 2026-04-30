#include <stdio.h>

float objemValce(float polomer, float vyska) {
	float obsahPodstavy = 3.14 * polomer * polomer;
	return vyska * obsahPodstavy;
}

int main() {

	float vyska;
	float polomer;

	printf("Zadej vysku valce:");
	scanf_s(" %f", &vyska);

	printf("Zadej polomer valce:");
	scanf_s(" %f", &polomer);

	printf("Objem valce je: %f", objemValce(polomer , vyska));

	return 0;
}
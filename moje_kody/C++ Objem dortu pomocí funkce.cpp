# include <stdio.h>

float objemValce(float polomer, float vyska) {
	float obsahPodstavy = 3.14 * polomer * polomer;
	return vyska * obsahPodstavy;
}

int main() {

	int patra;
	float vyska[40];
	float polomer[40];
	float objem_dortu = 0;

	printf("Zadej kolik pater ma dort: ");
	scanf_s("%d", &patra);

	for (int i = 0; i < patra; i++) {
		printf("Zadej polomer %d. patra: ", i + 1);
		scanf_s("%f", &polomer[i]);

		printf("Zadej vysku %d. patra: ", i + 1);
		scanf_s("%f", &vyska[i]);

		objem_dortu = objem_dortu + objemValce(polomer[i], vyska[i]);
	}

	printf("Objem dortu je: %.2f", objem_dortu);

	return 0;
}
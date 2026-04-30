#include <stdio.h>

int odpocet(int hodiny, int minuty, int sekundy) {
	int cas = hodiny * 60 * 60 + minuty * 60 + sekundy;
	return (24 * 60 * 60) - cas;
}

int main() {

	int h;
	int m;
	int s;
	
	printf("Zadej kolik je hodin:");
	scanf_s(" %d", &h);

	printf("Zadej kolik je minut:");
	scanf_s(" %d", &m);

	printf("Zadej kolik je sekund:");
	scanf_s(" %d", &s);

	printf("Do pulnoci zbyva %d sekund", odpocet(h, m, s));

	return 0;
}
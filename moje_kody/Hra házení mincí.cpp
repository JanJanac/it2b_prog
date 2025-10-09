#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
	
	int ucet = 500;
	int sazka;
	int sazka_m;
	int hod = 1;
	int konverzace;
	int padnuti;
	srand(time(NULL));

	printf("Zdravim te, zabloudili poutniku.\nPrejes si u nas zahrat jednu hru?\n");
	printf("Jestli si prejes zahrat stiskni 0 jestli ne stiskni 1.\n");
	scanf_s("%d", &konverzace);

	if (konverzace == 1) {
		printf("Okay, respektuji tvoje rozhodnuti\nPreji krasny zbytek cesty.\n");
		return 1;
	} else {
	}
	
	printf("Jsem rad ze sis vybral u nas hrat.\nNase hra spociva v tom, ze ja budu hazet minci a ty budes hadat jestli padne PANNA nebo OREL.\n");
	printf("Tvuj ucet na zacatku obsahuje 500kc.\nPokazde kdyz se trefis dostanes dvojnasobek toho co jsi vsadil, jestli ze se netrefis o vsazene penize prijdes.\nTakze zaciname.\n");
	
	while (hod == 1) {

		 if (ucet == 0) {
			 printf("Na ucte mas 0kc, tedy nemuzes pokracovat\n");

			 return 0;
		 }

		printf("Prejes si vadit na PANU (0) nebo ORLA (1)?\n");
		scanf_s("%d", &sazka_m);
	
		printf("Kolik si prejes vsadit?\n");
		scanf_s("%d", &sazka);
	
		printf("Pro hod minci zadej 1, pokud si pres skoncit zadej 0.\n");
		scanf_s("%d", &hod);
	
		padnuti = rand() % 2;

		if (padnuti == 0) {
			printf("Padla PANA\n");
		} else {
			printf("Padl OREL\n");
		}

		if (padnuti == sazka_m) {
			ucet = sazka + ucet;
			printf("Gratuluji, trefil ses.\nTvoji sazku zdvojnasobujeme.\n");
			printf("Stav tveho uctu je ted: %d\n", ucet);
		} else {
			ucet = ucet - sazka;
			printf("Bohuzel ses netrefil.\nSvoji sazku ztracis\n");
			printf("Stav tveho uctu je ted: %d\n", ucet);
		}
		
	}
	
return 0;

}
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {

	int arr[] = { 'a','b','c','d','e' };
	srand(time(NULL));
	int nahoda = rand() % 5;

	printf("Tvuj nahodny prvek je: %c", arr[nahoda]);

	return 0;
}
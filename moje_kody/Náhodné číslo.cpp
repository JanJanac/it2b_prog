#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
	srand(time(NULL));

	int cislo = rand() % 100 + 1;

	printf("Nahodne cislo: %d", cislo);

return 0;

}
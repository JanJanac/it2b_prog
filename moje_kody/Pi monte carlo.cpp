#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>

int main() {

	int bodyvkruhu = 0;
	srand(time(NULL));
	float x;
	float y;
	int body = 0;

	for (int i = 0; i < 1000000; i++) {
		x = ((float)rand() / RAND_MAX);
		y = ((float)rand() / RAND_MAX);

		if (x * x + y * y < 1) {
			bodyvkruhu++;
		}
		body++;
	}

	double pi = (double) bodyvkruhu / body * 4;
	printf("Cislo pi: %f ", pi);

	return 0;

}

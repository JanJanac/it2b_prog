#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>

int main() {

  srand(time(NULL));
  int teplota[10];
  int soucet = 0;
  int podmrazem = 0;

  printf("Namerene teploty: ");

  for (int i = 0; i < 10; i++) {
    teplota[i] = rand() % 21 - 10;
    printf("%d  ", teplota[i]);

    if (teplota[i] < 0) {
      podmrazem++;
    }

    soucet = soucet + teplota[i];
  }

  float prumer = (float) soucet / 10;

  printf("\nPrumerna teplota: %.1f °C\n", prumer);
  printf("Pocet mereni pod bodem mrazu: %d", podmrazem);

  return 0;

}
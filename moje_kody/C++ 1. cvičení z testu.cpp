#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>

int main() {

  srand(time(NULL));
  int pokusu = 0;
  int hod1 = 10;
  int hod2 = 9;

    printf("Hody: \n");

  while (hod1 != hod2) {
    hod1 = rand() % 6 + 1;
    hod2 = rand() % 6 + 1;

    printf("%d, %d\n", hod1, hod2);
    pokusu++;
  }

  printf("Padla dvojice: %d, %d\n", hod1, hod2);
  printf("Pocet pokusu do dvojce: %d", pokusu);

  return 0;

}
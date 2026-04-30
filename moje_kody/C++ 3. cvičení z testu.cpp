#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <time.h>

int main() {

  srand(time(NULL));
  int y[3];
  int x[3];
  int vysledekuzivatel[3];
  int spravne = 0;

  for (int i = 0; i < 3; i++) {
    y[i] = rand() % 101;
    x[i] = y[i] * y[i];

    printf("\nVypocitej odmocninu cisla: %d \n", x[i]);
    printf("Zadej svuj vysledek:");
    scanf_s(" %d", &vysledekuzivatel[i]);

    if (y[i] == vysledekuzivatel[i]) {
      spravne++;
    }
  }

  printf("\n Spravne: %d/3", spravne);

  return 0;

}

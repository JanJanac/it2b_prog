#include <stdio.h>

void ramecek(int s, int v) {
    if (s < 2 || v < 2) {
        printf("CHYBA\n");
        return;
    }

    for (int i = 0; i < s; i++) {
        printf("#");
    }

    for (int j = 0; j < v - 2; j++) {
        printf("\n#");
        for (int k = 0; k < s - 2; k++) {
            printf(" ");
        }
        printf("#");
    }

    printf("\n");

    for (int l = 0; l < s; l++) {
        printf("#");
    }

    printf("\n");
}


int main() {

    ramecek(5, 4);
    ramecek(2, 3);
    ramecek(1, 4);
    ramecek(6, 1);

    return 0;
}
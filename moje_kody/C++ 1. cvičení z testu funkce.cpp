#include <stdio.h>

int soucetDelitelu(int n) {

    int soucet = 0;
    if (n <= 0)
        return 0;

    for (int i = 1; i <= n; i++) {
        if (n % i == 0)
            soucet = soucet + i;
    }
    return soucet;

}

int dokonaleCislo (int n) {
    if (n * 2 == soucetDelitelu(n)) {
        return 1;
    }
    return 0;
}


int main() {

    printf(" %d \n", soucetDelitelu(1));
    printf(" %d \n", soucetDelitelu(6));
    printf(" %d \n", soucetDelitelu(12));
    printf(" %d \n", soucetDelitelu(4));

    printf(" %d \n", dokonaleCislo(5));
    printf(" %d \n", dokonaleCislo(6));
    printf(" %d \n", dokonaleCislo(28));
    printf(" %d \n", dokonaleCislo(496));
    printf(" %d \n", dokonaleCislo(7));

    return 0;
}
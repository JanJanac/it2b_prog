# include <stdio.h>

float objemValce(float polomer, float vyska) {
    float obsahPodstavy = 3.14 * polomer * polomer;
    return vyska * obsahPodstavy;
}

float objemDortu(int patra, float polomer[], float vyska[]) {
    float objem_dortu = 0;
    for (int i = 0; i < patra; i++) {
        objem_dortu += objemValce(polomer[i], vyska[i]);
    }
    return objem_dortu;
}

int main() {

    return 0;
}
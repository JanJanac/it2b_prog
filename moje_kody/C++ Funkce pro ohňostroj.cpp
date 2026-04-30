#include <stdio.h>

void ohnostroj (char znak1, char znak2, int opakovani) {
	for (int i = 0; i < opakovani; i++) {
		printf("  %c  \n", znak1);
		printf("%c %c %c\n", znak1, znak2, znak1);
		
	}
	printf("  %c  \n", znak1);
}


int main() {

	ohnostroj('#', '-', 5);

	return 0;
}
#include <stdio.h>
#include <string.h>

int main() {

	char str1[40];
	char str2[40];
	int i = 0;

	printf("Zadej prvni string: \n");
	scanf_s(" %39s", str1, 39);

	printf("Zadej druhy string: \n");
	scanf_s(" %39s", str2, 39);

	while (str1[i] == str2[i] && str1[i] !='\0' && str2[i] != '\0') {
		i++;
	}

	int delka1 = strlen(str1);
	int delka2 = strlen(str2);

	if (i == delka1 == delka2) {
		printf("Stringy se rovnaji");
	} else {
		printf("Stringy se nerovnaji");
	}

	return 0;
}
﻿#include <stdio.h>
#include <string.h>

void reverseString(char str[]);

int main()
{
    char str[100];

    printf("Enter a string: ");
    fgets(str, sizeof(str), stdin);

    // Remove the newline character from fgets
    str[strcspn(str, "\n")] = 0;

    reverseString(str);

    printf("Reversed string: %s\n", str);

    return 0;
}

void reverseString(char str[])
{
    int start = 0;
    int end = strlen(str) - 1;
    char temp;

    while (start < end)
    {
        temp = str[start];
        str[start] = str[end];
        str[end] = temp;

        start++;
        end--;
    }
}

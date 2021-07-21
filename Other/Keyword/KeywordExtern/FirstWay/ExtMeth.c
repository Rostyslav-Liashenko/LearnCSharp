#include <stdlib.h>

int __declspec(dllexport) AbsMax(int a, int b)
{
    return abs(a) < abs(b) ? abs(b) : abs(a);
}

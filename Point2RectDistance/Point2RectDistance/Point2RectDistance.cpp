#include <iostream>
#include <iomanip>
#include "Rectangle.h"
int main()
{
	Rect rect;
	rect.maxX = 8;
	rect.minX = 5;
	rect.maxY = 4;
	rect.minY = 2;
	float distance = DistanceToRect(3,2, rect);
	std::cout << std::setprecision(3) << distance;
	return 0;
}


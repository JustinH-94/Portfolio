#include "Rectangle.h"
#include<iostream>
#include <math.h>
Rect rect;
float DistanceToRect(float x, float y, Rect& rect) {
	float dX, dY;
	if (rect.minX > x) {
		dX = rect.minX - x;
	}
	else if (rect.maxX < x) {
		dX = x - rect.maxX;
	}
	else {
		dX = 0;
	}

	if (rect.minY > y) {
		dY = rect.minY - y;
	}
	else if (rect.maxY < y) {
		dY = y - rect.maxY;
	}
	else {
		dY = 0;
	}
	return sqrt((dX * dX) + (dY * dY));
}
struct Rect {
	float minX;
	float minY;
	float maxX;
	float maxY;
};

float DistanceToRect(float x, float y, Rect& rect);
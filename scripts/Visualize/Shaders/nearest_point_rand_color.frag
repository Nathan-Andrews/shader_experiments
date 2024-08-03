#version 330 core
in vec2 ourPosition;
out vec4 FragColor;
uniform vec2 pointCenters[100];
uniform int pointCount;
uniform vec4 color1;
uniform vec4 color2;

vec4 blend(float blendFactor) {
    float blendFactorInverse = 1 - blendFactor;

    float r = color1[0] * blendFactor + color2[0] * blendFactorInverse;
    float g = color1[1] * blendFactor + color2[1] * blendFactorInverse;
    float b = color1[2] * blendFactor + color2[2] * blendFactorInverse;
    float a = color1[3] * blendFactor + color2[3] * blendFactorInverse;

    return vec4(r,g,b,a);
}

void main() {
    int nearestIndex = 0;
    float nearestDistance = 1.1;

    for (int i = 0; i < pointCount; i++) {
        float currentDistance = length(ourPosition - pointCenters[i]);

        if (currentDistance < nearestDistance) {
            nearestDistance = currentDistance;
            nearestIndex = i;
        }
    }

    float blendFactor = nearestIndex * 1.0 / pointCount;

    FragColor = blend(blendFactor);
}
using Rendering;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;


class Program {
    public static void Main(string[] args) {
        // options:
        // "nearest_point_rand_color", "nearest_point_gradient_fill", "nearest_point_edge_distance", "second_nearest_point"
        string shadername = "second_nearest_point";
        int pointCount = 100;
        float maxParticleSpeed = 0.000025f;


        // Vector4 color1 = new(0.286f, 0.471f, 0.941f, 1.0f);
        // Vector4 color2 = new(0.471f, 0.796f, 1.0f, 1.0f);
        // Vector4 color1 = new(0.1f, 0.1f, 0.1f, 1.0f);
        // Vector4 color2 = new(1.0f, 0.494f, 0.51f, 1.0f);
        Vector4 color1 = new(0.961f, 0.588f, 0.831f,1.0f);
        Vector4 color2 = new(0.639f, 0.361f, 0.839f, 1.0f);
        // Vector4 color1 = new(1f, 0.89f, 0.459f,1.0f);
        // Vector4 color2 = new(1f, 0.412f, 0.459f, 1.0f);

        using (var window = new PointVisualizer(800, 800, "Nearest Point Visualization",shadername)) {
            window._pointCount = pointCount;
            window._maxParticleSpeed = maxParticleSpeed;
            window._color1 = color1;
            window._color2 = color2;
            window.Run();
        }
    }
}
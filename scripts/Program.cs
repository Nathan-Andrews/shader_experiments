using Rendering;

class Program {
    public static void Main(string[] args) {
        // options:
        string shadername = "nearest_point_rand_color"; // "nearest_point_rand_color", "nearest_point_graident_fill", "nearest_point_edge_distance", "second_nearest_point"

        using (var window = new PointVisualizer(800, 800, "Nearest Point Visualization",shadername)) {
            window.Run();
        }
    }
}
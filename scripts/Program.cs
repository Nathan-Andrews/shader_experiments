using Rendering;

class Program {
    public static void Main(string[] args) {
        using (var window = new NearestPointRender(800, 800, "Nearest Point Visualization","nearest_point_2nd_fill")) {
            window.Run();
        }
    }
}
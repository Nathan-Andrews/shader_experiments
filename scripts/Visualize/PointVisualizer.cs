using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;


namespace Rendering {
    public class PointVisualizer : Visualize
    {

        private int _pointShaderProgram;
        private int _pointVertexArrayObject;
        private PointSet _points;
        string _shaderName;

        public Vector4 _color1;
        public Vector4 _color2;

        public int _pointCount = 100;
        public float _maxParticleSpeed = 0.0001f; 


        public PointVisualizer(int width, int height, string title, string shaderName) : base(width, height, title) {
            _shaderName = shaderName;
            _points = new();
        }

        protected override void OnLoad() {
            base.OnLoad();

            _points = new(_pointCount,_maxParticleSpeed);

            // Load and compile shaders
            _pointShaderProgram = CreateShaderProgram("scripts/Visualize/Shaders/point.vert", $"scripts/Visualize/Shaders/{_shaderName}.frag");

            _pointVertexArrayObject = CreateAndBindVAO();

            UnbindTexture();

            SetClearColor();
        }

        private void UpdateUniforms () {
            // Set point uniform variables
            int centerLocation = GL.GetUniformLocation(_pointShaderProgram, "pointCenters");
            GL.Uniform2(centerLocation, _points._pointPositions.Length, ref _points._pointPositions[0].X);

            int countLocation = GL.GetUniformLocation(_pointShaderProgram,"pointCount");
            GL.Uniform1(countLocation,_points._pointCount);

            int color1Location = GL.GetUniformLocation(_pointShaderProgram,"color1");
            GL.Uniform4(color1Location,_color1);

            int color2Location = GL.GetUniformLocation(_pointShaderProgram,"color2");
            GL.Uniform4(color2Location,_color2);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            _points.ApplyForces();

            ClearScreen();

            // Render points on top of the boundry background
            GL.UseProgram(_pointShaderProgram);
            GL.BindVertexArray(_pointVertexArrayObject);

            UpdateUniforms();

            GL.DrawArrays(PrimitiveType.TriangleStrip, 0, 4);

            SwapBuffers();
        }

        protected override void OnUnload()
        {
            base.OnUnload();

            GL.DeleteVertexArray(_pointVertexArrayObject);
            GL.DeleteProgram(_pointShaderProgram);;
        }
    }

    public class PointSet {
        public Vector2[] _pointPositions;
        public Vector2[] _pointForces;
        public int _pointCount = 100;
        public float _maxForceMagnitude = 0.0001f;

        public PointSet (int pointCount = 100, float maxForceMagnitude = 0.0001f) {
            _pointCount = pointCount;
            _maxForceMagnitude = maxForceMagnitude;

            _pointPositions = new Vector2[_pointCount];
            _pointForces = new Vector2[_pointCount];

            Parallel.For(0, _pointCount, (i) => {
                _pointPositions[i] = RandomCoordinate();
                _pointForces[i] = RandomCoordinate() * _maxForceMagnitude;
            });
        }

        public void ApplyForces() {
            Parallel.For(0, _pointCount, (i) => {
                _pointPositions[i] += _pointForces[i];
            });
        }
        
        private static Vector2 RandomCoordinate() {
            return new Vector2((float)(Random.Shared.NextDouble() - 0.5) * 2.1f, (float) (Random.Shared.NextDouble() - 0.5) * 2.1f);
        }
    }
}
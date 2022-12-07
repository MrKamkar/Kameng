namespace Kameng
{
    class FieldOfView
    {
        public Canvas scene = new Canvas(new Size(10, 10));
        public Shape camera = new Shape(new Size(5, 5));

        public void Draw()
        {
            for (int y = 0; y < camera.size.height; y++)
            {
                char[] buffer = scene.surface[camera.position.y + y].ToCharArray();
                for (int x = 0; x < camera.size.width; x++)
                {
                    buffer[x] = scene.surface[camera.position.y + y].ToCharArray()[camera.position.x + x];
                }
                camera.surface[y] = new string(buffer);
            }
        }
    }
}

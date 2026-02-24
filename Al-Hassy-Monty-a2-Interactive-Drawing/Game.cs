// Include the namespaces (code libraries) you need below.
using System;
using System.Diagnostics.Metrics;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        // Shades colors (New colors = Purple, Pink)
        Color[] shadesColors = [Color.Black, Color.Red, Color.Cyan, Color.Green, Color.Yellow, 
                                new Color(128, 0, 128), new Color(255, 192, 203)];


        // Remaining facial feature colors

        // Eyebrow
        Color brown = new Color(150, 75, 0);

        // Eye colors (Maroon, Turqoise, Orange)
        Color[] eyeColors = [new Color(128, 0, 0), new Color(64, 224, 208), new Color(255, 165, 0)];

        // Random locations for stars
        int randomXCoords = Random.Integer(30, 770);
        int randomYCoords = Random.Integer(30, 370);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Shades up, stomach out.");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            if (Input.IsMouseButtonDown(MouseInput.Left)) 
            {
                  // Draw eyes
                drawEye(200, 200);
                drawEye(500, 200);

                // Draw EyeBrows
                drawEyeBrow(185, 180);
                drawEyeBrow(485, 180);

                

                for (int stars = 0; stars < 15; stars += 1)
                {
                    drawStars(randomXCoords, randomYCoords);
                }

                    Draw.FillColor = Color.Black;
                Draw.Rectangle(200, 400, 400, 100);

                //Draw.Rectangle(250, 450);
            }
            else
            {
                Draw.FillColor = shadesColors[0];
                drawShades(320, 220);
                Draw.FillColor = Color.Black;
                Draw.Rectangle(200, 500, 400, 50);
            }
        }

        void drawShades(int x, int y)
        {
            Draw.Rectangle(x, y, 160, 40);
            Draw.Circle(x - 70, y - 2, 100);
            Draw.Circle(x + 210, y - 2, 100);
        }
        void drawEyeBrow(int x, int y)
        {
            Draw.FillColor = (brown);
            Draw.Rectangle(x, y, 125, 40);

        }
        void drawEye(int x, int y)
        {
              // Draw eye shape
            Draw.LineSize = 3;
            Draw.LineColor = (Color.Black);
            Draw.FillColor = (Color.White);
            Draw.Square(x, y, 100);

            // Draw inner eye
            Draw.FillColor = eyeColors[0];
            Draw.Circle(x + 50, y + 50, 45);
            Draw.FillColor = eyeColors[1];
            Draw.Circle(x + 50, y + 50, 35);
            Draw.FillColor = eyeColors[2];
            Draw.Circle(x + 50, y + 50, 25);
        }

        void drawStars(int x, int y)
        {
            Draw.FillColor = Color.Yellow;
            Draw.Ellipse(x, y, 10, 35);
            Draw.Ellipse(x, y, 35, 10);
        }

    }

}

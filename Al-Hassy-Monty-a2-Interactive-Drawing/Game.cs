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

        int shadeStateColor = 0;
        int shadeCoordY = 110;

        // Remaining facial feature colors

        // Color for eyebrow 
        Color brown = new Color(150, 75, 0);

        // Eye colors (Maroon, Turqoise, Orange)
        Color[] eyeColors = [new Color(128, 0, 0), new Color(64, 224, 208), new Color(255, 165, 0)];

        // Array to store values random locations for stars

        int[] randomXCoords = new int[15];
        int[] randomYCoords = new int[15];

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


            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                for (int i = 0; i < 15; i++)
                {
                    randomXCoords[i] = Random.Integer(30, 770);
                    randomYCoords[i] = Random.Integer(30, 370);
                }
       
            }
                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    // Draw eyes
                    drawEye(200, 200);
                    drawEye(500, 200);

                    // Draw EyeBrows
                    drawEyeBrow(185, 180);
                    drawEyeBrow(485, 180);

                    // Shades on interacive output
                    for (int i = 0; i < 7; i++)
                    {
                        Draw.FillColor = shadesColors[i];
                        drawShades(320, shadeCoordY - i * 15);
                    }
           
                     // Stars across screen randomly
                for (int i = 0; i < 15; i++)
                {
                    drawStars(randomXCoords[i], randomYCoords[i]);
                }

                    // Draw Mouth Graphic
                    Draw.FillColor = Color.Black;
                    Draw.Rectangle(200, 400, 400, 100);

                    // Draw Vomit graphic
                    Draw.FillColor = Color.LightGray;
                    Draw.Rectangle(250, 450, 300, 150);
                    Draw.FillColor = Color.Green;
                    Draw.Rectangle(250, 500, 300, 150);
                    Draw.FillColor = new Color(0, 100, 0);
                    Draw.Rectangle(250, 550, 300, 150);

                    //Draw.Rectangle(250, 450);
                }
                else
                {
                    // Draw shades
                    Draw.FillColor = shadesColors[0];
                    drawShades(320, 220);
                    Draw.FillColor = Color.Black;
                    Draw.Rectangle(200, 500, 400, 50);
                }
            
        }

             // Compound function draws shades graphic 
        void drawShades(int x, int y)
        {
            Draw.Rectangle(x, y, 160, 40);
            Draw.Circle(x - 70, y - 2, 100);
            Draw.Circle(x + 210, y - 2, 100);
        }

              // Function draws eyebrow
        void drawEyeBrow(int x, int y)
        {
            Draw.FillColor = (brown);
            Draw.Rectangle(x, y, 125, 40);

        }

           // Compound function draws full eye
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

            // Compound function draws star
        void drawStars(int x, int y)
        {
            Draw.FillColor = Color.Yellow;
            Draw.Ellipse(x, y, 10, 35);
            Draw.Ellipse(x, y, 35, 10);
        }

    }

}

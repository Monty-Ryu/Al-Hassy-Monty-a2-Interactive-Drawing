// Include the namespaces (code libraries) you need below.
using System;
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

            // Shades colors
        Color purple = new Color(128, 0, 128);
        Color pink = new Color(255, 192, 203);
        Color[] shadesColors = [Color.Black, Color.Red, Color.Cyan, Color.Yellow, purple, pink];



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Shades up, stomach out.")
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }

        void drawShades(int x, int y)
        {
            Draw.Circle(x - 150, y, 100);
            Draw.Rectangle(x, y, 120, 60);
            Draw.Circle(x + 150, y, 100);
        }
    }

}

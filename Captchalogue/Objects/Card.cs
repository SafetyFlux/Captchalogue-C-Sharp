using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Captchalogue.Utilities;

namespace Captchalogue.Objects
{
    class Card
    {
        // Initialize variables
        private bool[,] holes = new bool[8, 6];
        private string code;

        // Default constructor
        public Card()
        {
            code = "00000000";
            UpdateHoles();
        }

        // Constructor
        public Card(string newCode)
        {
            code = newCode;
            UpdateHoles();
        }

        // Update the holes in the card based on the code
        public void UpdateHoles()
        {
            holes = CaptchaConverter.CodeToHoles(code);
        }

        // Update the code based on the holes in the card
        public void UpdateCode()
        {
            code = CaptchaConverter.HolesToCode(holes);
        }

        // Invert a card (a.k.a. use the NOT operation)
        public void InvertCard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    holes[i, j] = !holes[i, j];
                }
            }

            UpdateCode();
        }

        // Get the code
        public string GetCode()
        {
            return code;
        }

        // Set the code
        public void SetCode(string newCode)
        {
            code = newCode;
            UpdateHoles();
        }

        // Get the holes
        public bool[,] GetHoles()
        {
            return holes;
        }

        // Set the holes
        public void SetHoles(bool[,] newHoles)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    holes[i, j] = newHoles[i, j];
                }
            }
            UpdateCode();
        }
    }
}

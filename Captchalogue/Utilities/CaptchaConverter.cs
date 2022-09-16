using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captchalogue.Utilities
{
    static class CaptchaConverter
    {
        // Initialize array of digits
        private static readonly char[] digitList = new char[] {
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F',
        'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
        'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
        'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '?', '!'
        };

        // Verify that a code is valid
        public static bool CodeIsValid(string code)
        {
            // Code is invalid if the length is not 8
            if (code.Length != 8)
            {
                return false;
            }

            // Code is invalid if it contains characters not within the digit list
            char[] digits = code.ToArray();
            foreach (char d in digits)
            {
                if (Array.IndexOf(digitList, d) == -1)
                {
                    return false;
                }
            }

            return true;
        }

        // Verify that a digit is valid
        public static bool DigitIsValid(char digit)
        {
            if (Array.IndexOf(digitList, digit) == -1)
                return false;
            else
                return true;
        }

        // Convert a code into a set of holes
        public static bool[,] CodeToHoles(string code)
        {
            char[] digits = code.ToArray();
            bool[,] holes = new bool[8, 6];

            for (int i = 0; i < 8; i++)
            {
                bool[] row = DigitToHoles(digits[i]);

                for (int j = 0; j < 6; j++)
                {
                    holes[i, j] = row[j];
                }
            }

            return holes;
        }

        // Convert a set of holes into a code
        public static string HolesToCode(bool[,] holes)
        {
            string code = "";

            for (int i = 0; i < 8; i++)
            {
                bool[] row = new bool[6];

                for (int j = 0; j < 6; j++)
                {
                    row[j] = holes[i, j];
                }

                code += HolesToDigit(row);
            }

            return code;
        }

        // Convert a digit into a row of holes
        public static bool[] DigitToHoles(char digit)
        {
            int digitIndex = Array.IndexOf(digitList, digit);
            if (digitIndex == -1)
            {
                digitIndex = 0;
            }

            bool[] holes = IntegerToBinary(digitIndex);

            return holes;
        }

        // Convert a row of holes into a digit
        public static char HolesToDigit(bool[] holes)
        {
            int digitIndex = BinaryToInteger(holes);

            return digitList[digitIndex];
        }

        // Convert an integer into binary (array of booleans)
        public static bool[] IntegerToBinary(int integer)
        {
            bool[] binary = new bool[6];

            for (int i = 0; i < binary.Length; i++)
            {
                int sub = (int)Math.Pow(2, 5 - i);
                if (integer - sub >= 0)
                {
                    binary[i] = true;
                    integer -= sub;
                }
                else
                {
                    binary[i] = false;
                }
            }

            return binary;
        }

        // Convert binary into an integer
        public static int BinaryToInteger(bool[] binary)
        {
            int integer = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                int sub = (int)Math.Pow(2, 5 - i);
                if (binary[i])
                {
                    integer += sub;
                }
            }

            return integer;
        }
    }
}

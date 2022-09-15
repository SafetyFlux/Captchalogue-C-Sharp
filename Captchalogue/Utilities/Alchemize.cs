using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Captchalogue.Objects;

namespace Captchalogue.Utilities
{
    static class Alchemize
    {
        // Perform the AND operation
        public static void OperationAND(Card card1, Card card2, Card result)
        {
            bool[,] alcHoles1 = card1.GetHoles();
            bool[,] alcHoles2 = card2.GetHoles();
            bool[,] resultHoles = new bool[8, 6];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (alcHoles1[i, j] && alcHoles2[i, j])
                        resultHoles[i, j] = true;
                    else
                        resultHoles[i, j] = false;
                }
            }

            result.SetHoles(resultHoles);
        }

        // Perform the OR operation
        public static void OperationOR(Card card1, Card card2, Card result)
        {
            bool[,] alcHoles1 = card1.GetHoles();
            bool[,] alcHoles2 = card2.GetHoles();
            bool[,] resultHoles = new bool[8, 6];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (alcHoles1[i, j] || alcHoles2[i, j])
                        resultHoles[i, j] = true;
                    else
                        resultHoles[i, j] = false;
                }
            }

            result.SetHoles(resultHoles);
        }

        /*
                                    NON-CANON OPERATIONS
                                                                                  */

        // Perform the XOR operation
        public static void OperationXOR(Card card1, Card card2, Card result)
        {
            bool[,] alcHoles1 = card1.GetHoles();
            bool[,] alcHoles2 = card2.GetHoles();
            bool[,] resultHoles = new bool[8, 6];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (alcHoles1[i, j] != alcHoles2[i, j])
                        resultHoles[i, j] = true;
                    else
                        resultHoles[i, j] = false;
                }
            }

            result.SetHoles(resultHoles);
        }

        // Perform the NAND operation
        public static void OperationNAND(Card card1, Card card2, Card result)
        {
            bool[,] alcHoles1 = card1.GetHoles();
            bool[,] alcHoles2 = card2.GetHoles();
            bool[,] resultHoles = new bool[8, 6];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (alcHoles1[i, j] && alcHoles2[i, j])
                        resultHoles[i, j] = false;
                    else
                        resultHoles[i, j] = true;
                }
            }

            result.SetHoles(resultHoles);
        }

        // Perform the NOR operation
        public static void OperationNOR(Card card1, Card card2, Card result)
        {
            bool[,] alcHoles1 = card1.GetHoles();
            bool[,] alcHoles2 = card2.GetHoles();
            bool[,] resultHoles = new bool[8, 6];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (alcHoles1[i, j] || alcHoles2[i, j])
                        resultHoles[i, j] = false;
                    else
                        resultHoles[i, j] = true;
                }
            }

            result.SetHoles(resultHoles);
        }

        // Perform the XNOR operation
        public static void OperationXNOR(Card card1, Card card2, Card result)
        {
            bool[,] alcHoles1 = card1.GetHoles();
            bool[,] alcHoles2 = card2.GetHoles();
            bool[,] resultHoles = new bool[8, 6];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (alcHoles1[i, j] == alcHoles2[i, j])
                        resultHoles[i, j] = true;
                    else
                        resultHoles[i, j] = false;
                }
            }

            result.SetHoles(resultHoles);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Captchalogue.Utilities;
using Captchalogue.Objects;

namespace Captchalogue
{
    public partial class App : Form
    {
        // Initialize Card objects
        private Card alcCard1 = new Card();
        private Card alcCard2 = new Card();
        private Card mainCard = new Card();

        // Initialize code strings
        string code1, code2;

        public App()
        {
            InitializeComponent();
        }

        private void ValidateCodes()
        {
            code1 = alcCode1.Text;
            code2 = alcCode2.Text;
            if (CaptchaConverter.CodeIsValid(code1))
            {
                alcCard1.SetCode(alcCode1.Text);
            }
            if (CaptchaConverter.CodeIsValid(code2))
            {
                alcCard2.SetCode(alcCode2.Text);
            }
        }

        private void UpdateResult()
        {
            resultCode.Text = mainCard.GetCode();
        }

        // AND (&&) button click
        private void OperAND_Click(object sender, EventArgs e)
        {
            ValidateCodes();
            Alchemize.OperationAND(alcCard1, alcCard2, mainCard);
            UpdateResult();
        }

        // OR (||) button click
        private void OperOR_Click(object sender, EventArgs e)
        {
            ValidateCodes();
            Alchemize.OperationOR(alcCard1, alcCard2, mainCard);
            UpdateResult();
        }

        // XOR (^^) button click
        private void OperXOR_Click(object sender, EventArgs e)
        {
            ValidateCodes();
            Alchemize.OperationXOR(alcCard1, alcCard2, mainCard);
            UpdateResult();
        }

        // NAND (~&) button click
        private void OperNAND_Click(object sender, EventArgs e)
        {
            ValidateCodes();
            Alchemize.OperationNAND(alcCard1, alcCard2, mainCard);
            UpdateResult();
        }

        // NOR (~|) button click
        private void OperNOR_Click(object sender, EventArgs e)
        {
            ValidateCodes();
            Alchemize.OperationNOR(alcCard1, alcCard2, mainCard);
            UpdateResult();
        }

        // XNOR (~^) button click
        private void OperXNOR_Click(object sender, EventArgs e)
        {
            ValidateCodes();
            Alchemize.OperationXNOR(alcCard1, alcCard2, mainCard);
            UpdateResult();
        }
    }
}

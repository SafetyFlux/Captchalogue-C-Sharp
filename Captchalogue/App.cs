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
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            FillMainDigits();
        }

        private Card mainCard = new Card();

        private void FillMainDigits()
        {
            TextBox[] mainCode = new TextBox[8] { mainDigit1, mainDigit2, mainDigit3, mainDigit4,
                                                mainDigit5, mainDigit6, mainDigit7, mainDigit8 };
            char[] digits = mainCard.GetCode().ToCharArray();
            
            for (int i = 0; i < 8; i++)
            {
                mainCode[i].Text += digits[i];
            }
        }

        private void MainDigit_Clicked(object sender, EventArgs e)
        {
            if (sender is TextBox digit)
                digit.Text = "";
        }

        private void MainDigit_Entered(object sender, EventArgs e)
        {
            if (sender is TextBox digit && digit.Text != "")
            {
                TextBox[] mainCode = new TextBox[8] { mainDigit1, mainDigit2, mainDigit3, mainDigit4,
                                                mainDigit5, mainDigit6, mainDigit7, mainDigit8 };
                string newCode = "";

                char d = digit.Text.ToCharArray()[0];
                if (!CaptchaConverter.DigitIsValid(d))
                    digit.Text = "";

                foreach (TextBox txt in mainCode)
                {
                    newCode += txt.Text;
                }

                if (CaptchaConverter.CodeIsValid(newCode)) {
                    mainCard.SetCode(newCode);
                }
            }
        }
    }
}

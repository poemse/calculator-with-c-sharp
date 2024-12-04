using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
//using poemse.com;
//poemse.com/2020/11/30/%d9%85%d8%a7%d8%b4%db%8c%d9%86-%d8%ad%d8%b3%d8%a7%d8%a8-c-%d9%be%db%8c%d8%b4%d8%b1%d9%81%d8%aa%d9%87-%d8%a8%d8%ae%d8%b4-1/  

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            oldProgram.Text = "";
        }

        double inputsOld = 0;
        double inputSum = 0;
        string check = "";
        string ejraAmalgar = "no";
        bool checkAmalgarChenge = false;

        

        private void btnNum1_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum1.Text);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum2.Text);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum3.Text);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum4.Text);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum5.Text);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum6.Text);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum7.Text);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum8.Text);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum9.Text);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnNum0.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            addition(lbltxt.Text, btnDot.Text);
        }

        //addition is a function for reducing codes.

        //First condition: Checks if the input is not zero and decimal point or if you pressed the equal button, the new value is just typed

        //Second condition: If the value is zero and the decimal point is pressed, zero and decimal point are printed

        //Third condition: If these are not present, two numbers are joined together, for example 23
        private void addition(string init1 , string init2)
        {
            if (init1 == "0" && init2 != "." || ejraAmalgar == "ok")
            {
                lbltxt.Text =  init2;
            }
            else if (init1 == "0" && init2 == ".")
            {
                lbltxt.Text = "0" + init2;
            }
            else
            {
                lbltxt.Text = init1 + init2;
            }
            ejraAmalgar = "no";

            checkAmalgarChenge = true;
        }



        private void btnMosavi_Click(object sender, EventArgs e)
        {
            funcShowProgram("=", Convert.ToDouble(lbltxt.Text));

            if(check == "+")
            {
                lbltxt.Text = "" + (inputSum + Convert.ToDouble(lbltxt.Text));
            }
            else if(check == "*"){
                lbltxt.Text = "" + (inputSum * Convert.ToDouble(lbltxt.Text));
            }
            else if (check == "/")
            {
                lbltxt.Text = "" + (inputSum / Convert.ToDouble(lbltxt.Text));
            }
            else if (check == "-")
            {
                lbltxt.Text = "" + (inputSum - Convert.ToDouble(lbltxt.Text));
            }

            inputsOld = Convert.ToDouble(lbltxt.Text);
            checkAmalgarChenge = true;
            inputSum = 0;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (checkAmalgarChenge == true)
            {
                mohasebe("+");
            }
            funcShowProgram("+", inputsOld);
            check = "+";
        }

        private void btnZarb_Click(object sender, EventArgs e)
        {
            if (checkAmalgarChenge == true)
            {
                mohasebe("*");
            }
            funcShowProgram("*", inputsOld);
            check = "*";
        }

        private void btnTaghsim_Click(object sender, EventArgs e)
        {
            if (checkAmalgarChenge == true)
            {
                mohasebe("/");
            }
            funcShowProgram("/", inputsOld);
            check = "/";
        }

        private void btnMenha_Click(object sender, EventArgs e)
        {
            if (checkAmalgarChenge == true)
            {
                mohasebe("-");
            }
            funcShowProgram("-", inputsOld);
            check = "-";
        }

        private void mohasebe(string avalcheck)
        {

            inputsOld = Convert.ToDouble(lbltxt.Text);
            if(check == "") { check = avalcheck; }
            if (check == "+")
            {
                if (inputSum == 0)
                {
                    lbltxt.Text = "" + (inputsOld);
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
                else
                {
                    lbltxt.Text = "" + (inputSum + Convert.ToDouble(lbltxt.Text));
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
            }
            else if (check == "*")
            {
                if (inputSum == 0)
                {
                    lbltxt.Text = "" + (inputsOld);
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
                else
                {
                    lbltxt.Text = "" + (inputSum * Convert.ToDouble(lbltxt.Text));
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
            }
            else if (check == "/")
            {
                if (inputSum == 0)
                {
                    lbltxt.Text = "" + (inputsOld);
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
                else
                {
                    lbltxt.Text = "" + (inputSum / Convert.ToDouble(lbltxt.Text));
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
            }
            else if (check == "-")
            {
                if (inputSum == 0)
                {
                    lbltxt.Text = "" + (inputsOld);
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
                else
                {
                    lbltxt.Text = "" + (inputSum - Convert.ToDouble(lbltxt.Text));
                    inputSum = Convert.ToDouble(lbltxt.Text);
                }
            }
        }

        private void funcShowProgram(string amalgar,double inputsOlds)
        {
            ejraAmalgar = "ok";

            if (oldProgram.Text.Contains("=")) {
                oldProgram.Text = "";
            }

            if(oldProgram.Text == "")
            {
                oldProgram.Text = inputsOld + " " + amalgar;
            }
            else if(checkAmalgarChenge == false)
            {
                oldProgram.Text = oldProgram.Text.Substring(0, oldProgram.Text.Length - 2);
                oldProgram.Text = oldProgram.Text + " " + amalgar;
            }
            else
            {
                oldProgram.Text = oldProgram.Text + " " + inputsOlds + " " + amalgar ;
            }



            checkAmalgarChenge = false;

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            oldProgram.Text = "";
            inputsOld = 0;
            inputSum = 0;
            lbltxt.Text = "0";
        }

        private void oldProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Save...");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Work");
        }

        private void btnDarsad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Work");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Work");
        }


        //Console.WriteLine This value in the Visual Studio console prints the value we need, it is the best way to debug

        //keyData specifies the buttons that were pressed

        //PerformClick is the command to call the desired click

        //animation is a function used to change the color

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Console.WriteLine(keyData);

            if (keyData == (Keys.NumPad1))
            {
                btnNum1.PerformClick();
                animation(btnNum1);
                return true;
            }else if (keyData == (Keys.NumPad2))
            {
                btnNum2.PerformClick();
                animation(btnNum2);
                return true;
            }
            else if (keyData == (Keys.NumPad3))
            {
                btnNum3.PerformClick();
                animation(btnNum3);
                return true;
            }
            else if (keyData == (Keys.NumPad4))
            {
                btnNum4.PerformClick();
                animation(btnNum4);
                return true;
            }
            else if (keyData == (Keys.NumPad5))
            {
                btnNum5.PerformClick();
                animation(btnNum5);
                return true;
            }
            else if (keyData == (Keys.NumPad6))
            {
                btnNum6.PerformClick();
                animation(btnNum6);
                return true;
            }
            else if (keyData == (Keys.NumPad7))
            {
                btnNum7.PerformClick();
                animation(btnNum7);
                return true;
            }
            else if (keyData == (Keys.NumPad8))
            {
                btnNum8.PerformClick();
                animation(btnNum8);
                return true;
            }
            else if (keyData == (Keys.NumPad9))
            {
                btnNum9.PerformClick();
                animation(btnNum9);
                return true;
            }
            else if (keyData == (Keys.NumPad0))
            {
                btnNum0.PerformClick();
                animation(btnNum0);
                return true;
            }
            else if (keyData == (Keys.Subtract))
            {
                btnMenha.PerformClick();
                animation(btnMenha);
                return true;
            }
            else if (keyData == (Keys.Add))
            {
                btnPlus.PerformClick();
                animation(btnPlus);
                return true;
            }
            else if (keyData == (Keys.Return))
            {
                btnMosavi.PerformClick();
                animation(btnMosavi);
                return true;
            }
            else if (keyData == (Keys.Decimal))
            {
                btnDot.PerformClick();
                animation(btnDot);
                return true;
            }
            else if (keyData == (Keys.Multiply))
            {
                btnZarb.PerformClick();
                animation(btnZarb);
                return true;
            }
            else if (keyData == (Keys.Divide))
            {
                btnTaghsim.PerformClick();
                animation(btnTaghsim);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void animation(Button btn)
        {
            Color save = btn.BackColor;
            btn.BackColor = Color.BlueViolet;
            Task.Delay(300).Wait();
            btn.BackColor = save;
        }

        private void btnNum1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

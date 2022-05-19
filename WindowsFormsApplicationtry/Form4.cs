using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationtry
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Restbtn_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = " ";
            listBox1.SelectedItem = null;
            listBox2.SelectedItem = null;
        }

        private void Convertbtn_Click_1(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == listBox2.SelectedItem)
            {
                textBox2.Text = textBox1.Text;
            }

            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a number you wish to convert", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                textBox2.Text = double.Parse(textBox1.Text).ToString();
            }
            catch 
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //distance

            if (listBox1.SelectedItem == "Feet" && listBox2.SelectedItem == "Inches")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 12).ToString();
            }

            if (listBox1.SelectedItem == "Inches" && listBox2.SelectedItem == "Feet")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 12).ToString();
            }

            if (listBox1.SelectedItem == "Yard" && listBox2.SelectedItem == "Feet")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 3).ToString();
            }

            if (listBox1.SelectedItem == "Feet" && listBox2.SelectedItem == "Yard")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 3).ToString();
            }

            if (listBox1.SelectedItem == "Yard" && listBox2.SelectedItem == "Inches")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 36).ToString();
            }

            if (listBox1.SelectedItem == "Inches" && listBox2.SelectedItem == "Yard")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 36).ToString();
            }

            if (listBox1.SelectedItem == "Mile" && listBox2.SelectedItem == "Inches")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 63360).ToString();
            }

            if (listBox1.SelectedItem == "Inches" && listBox2.SelectedItem == "Mile")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 63360).ToString();
            }

            if (listBox1.SelectedItem == "Mile" && listBox2.SelectedItem == "Feet")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 5280).ToString();
            }

            if (listBox1.SelectedItem == "Feet" && listBox2.SelectedItem == "Mile")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 5280).ToString();
            }

            if (listBox1.SelectedItem == "Mile" && listBox2.SelectedItem == "Yard")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 1760).ToString();
            }

            if (listBox1.SelectedItem == "Yard" && listBox2.SelectedItem == "Mile")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 1760).ToString();
            }

            if (listBox1.SelectedItem == "Inches" && listBox2.SelectedItem == "Meters")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 39.370).ToString();
            }

            if (listBox1.SelectedItem == "Meters" && listBox2.SelectedItem == "Inches")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 39.370).ToString();
            }

            if (listBox1.SelectedItem == "Meters" && listBox2.SelectedItem == "Feet")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 3.2808).ToString();
            }

            if (listBox1.SelectedItem == "Feet" && listBox2.SelectedItem == "Meters")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 3.2808).ToString();
            }

            if (listBox1.SelectedItem == "Meters" && listBox2.SelectedItem == "Yard")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 1.0936).ToString();
            }

            if (listBox1.SelectedItem == "Yard" && listBox2.SelectedItem == "Meters")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 1.0936).ToString();
            }

            if (listBox1.SelectedItem == "Meters" && listBox2.SelectedItem == "Miles")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 0.00062137).ToString();
            }

            if (listBox1.SelectedItem == "Miles" && listBox2.SelectedItem == "Meters")
            {

                textBox2.Text = (double.Parse(textBox1.Text) / 0.00062137).ToString();
            }


            // temperature
            if (listBox1.SelectedItem == "Celsius" && listBox2.SelectedItem == "Faharanheit")
            {
                textBox2.Text = (((9 * double.Parse(textBox1.Text)) / 5) + 32).ToString();
            }

            if (listBox1.SelectedItem == "Celsius" && listBox2.SelectedItem == "Kelvin")
            {

                textBox2.Text = (double.Parse(textBox1.Text) + 273.15).ToString();
            }

            if (listBox1.SelectedItem == "Faharanheit" && listBox2.SelectedItem == "Celsius")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) - 32) * 5 / 9).ToString();
            }

            if (listBox1.SelectedItem == "Faharanheit" && listBox2.SelectedItem == "Kelvin")
            {

                textBox2.Text = (((double.Parse(textBox1.Text) - 32) * 5 / 9) + 273.15).ToString();
            }

            if (listBox1.SelectedItem == "Kelvin" && listBox2.SelectedItem == "Celsius")
            {

                textBox2.Text = (double.Parse(textBox1.Text) - 273.15).ToString();
            }

            if (listBox1.SelectedItem == "Kelvin" && listBox2.SelectedItem == "Faharanheit")
            {

                textBox2.Text = (((double.Parse(textBox1.Text) - 273.15) * 9 / 5) + 32).ToString();
            }

            //volume
            if (listBox1.SelectedItem == "Liter" && listBox2.SelectedItem == "Milliliters")
            {

                textBox2.Text = (double.Parse(textBox1.Text) * 1000).ToString();
            }

            if (listBox1.SelectedItem == "Liter" && listBox2.SelectedItem == "Cubic meter")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) / 1000)).ToString();
            }

            if (listBox1.SelectedItem == "Milliliters" && listBox2.SelectedItem == "Liter")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) / 1000)).ToString();
            }

            if (listBox1.SelectedItem == "Milliliters" && listBox2.SelectedItem == "Cubic meter")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) / 1e+6)).ToString();
            }

            if (listBox1.SelectedItem == "Cubic meter" && listBox2.SelectedItem == "Liter")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) * 1000)).ToString();
            }

            if (listBox1.SelectedItem == "Cubic meter" && listBox2.SelectedItem == "Milliliters")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) * 1e+6)).ToString();
            }



            //Weigt
            if (listBox1.SelectedItem == "Kilogram" && listBox2.SelectedItem == "Gram")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) * 1000)).ToString();
            }

            if (listBox1.SelectedItem == "Kilogram" && listBox2.SelectedItem == "Milligram")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) * 1000000)).ToString();
            }

            if (listBox1.SelectedItem == "Gram" && listBox2.SelectedItem == "Kilogram")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) / 1000)).ToString();
            }

            if (listBox1.SelectedItem == "Gram" && listBox2.SelectedItem == "Milligram")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) * 1000)).ToString();
            }

            if (listBox1.SelectedItem == "Milligram" && listBox2.SelectedItem == "Gram")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) / 1000)).ToString();
            }

            if (listBox1.SelectedItem == "Milligram" && listBox2.SelectedItem == "Kilogram")
            {

                textBox2.Text = ((double.Parse(textBox1.Text) / 1000000)).ToString();
            }




            //number
            if (listBox1.SelectedItem == "Decimal" && listBox2.SelectedItem == "Binary")
            {
                try
                {
                    int number = Convert.ToInt32(textBox1.Text);
                    textBox2.Text = Convert.ToString(number, 2);
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }

               
            }

            if (listBox1.SelectedItem == "Decimal" && listBox2.SelectedItem == "Octal")
            {
                try
                {
                    int decimalNumber = int.Parse(textBox1.Text);
                    textBox2.Text = Convert.ToString(decimalNumber, 8);
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
               
            }

            if (listBox1.SelectedItem == "Decimal" && listBox2.SelectedItem == "Hex")
            {
                try
                {
                    string input = textBox1.Text;
                    string outputHex = int.Parse(input).ToString("X");
                    textBox2.Text = outputHex;
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
               
            }

            if (listBox1.SelectedItem == "Binary" && listBox2.SelectedItem == "Decimal")
            {
                try
                {
                    textBox2.Text = Convert.ToInt32((textBox1.Text), 2).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }

               
            }

            if (listBox1.SelectedItem == "Binary" && listBox2.SelectedItem == "Octal")
            {
                try
                {
                    string val = textBox1.Text;
                    int convertnumber = Convert.ToInt32(val, 2);
                    textBox2.Text = Convert.ToString(convertnumber, 8);
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }

               
            }

            if (listBox1.SelectedItem == "Binary" && listBox2.SelectedItem == "Hex")
            {
                try
                {
                    string val = textBox1.Text;
                    textBox2.Text = Convert.ToInt32(val, 2).ToString("X");
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }             
            }

            if (listBox1.SelectedItem == "Octal" && listBox2.SelectedItem == "Decimal")
            {
                try
                {
                    textBox2.Text = Convert.ToInt32((textBox1.Text), 8).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
               
            }

            if (listBox1.SelectedItem == "Octal" && listBox2.SelectedItem == "Binary")
            {
                try
                {
                    textBox2.Text = Convert.ToString(Convert.ToInt32((textBox1.Text), 8), 2);
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
               
            }

            //

            if (listBox1.SelectedItem == "Octal" && listBox2.SelectedItem == "Hex")
            {
                try
                {
                    string val = textBox1.Text;
                    textBox2.Text = Convert.ToInt32(val, 8).ToString("X");
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
               
            }

            if (listBox1.SelectedItem == "Hex" && listBox2.SelectedItem == "Decimal")
            {
                try
                {
                    string s = textBox1.Text;
                    long n = Int64.Parse(s, System.Globalization.NumberStyles.HexNumber);
                    textBox2.Text = n.ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
             }

            if (listBox1.SelectedItem == "Hex" && listBox2.SelectedItem == "Binary")
            {
                try
                {
                    textBox2.Text = Convert.ToString(Convert.ToInt32((textBox1.Text), 16), 2);
                }
                
                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
            }

            if (listBox1.SelectedItem == "Hex" && listBox2.SelectedItem == "Octal")
            {
                try
                {
                    textBox2.Text = Convert.ToString(Convert.ToInt32((textBox1.Text), 16), 8);
                }

                catch
                {
                    MessageBox.Show("Invalid number format enterd. Please enter valid number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Text = " ";
                }
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 300;
                mouseY = MousePosition.Y - 160;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

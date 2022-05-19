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
    public partial class Form2 : Form
    {
        
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;
        
        public Form2()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Backspace.Enabled = true;
            Button b = (Button)sender;
            if(b.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
                    equation.Text = result.Text;
            }
            else
                result.Text = result.Text + b.Text;
                equation.Text = result.Text;
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                Backspace.Enabled = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                Backspace.Enabled = true;
                equation.Text = value + " " + operation;
            }       
        }

        private void equal_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;             
            }
            Backspace.Enabled = false;
            try
            {
                value = Int32.Parse(result.Text);
            }
            catch
            {
                //MessageBox.Show("Invalid operation format enterd. Please check what you enterd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //result.Clear();
            }
           
            operation = "";
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            
                if (result.Text.Length > 0)
                {
                   try
                    {
                    result.Text = result.Text.Remove(result.Text.Length - 1, 1);
                    equation.Text = equation.Text.Remove(equation.Text.Length - 1, 1);
                }
                   catch
                    {
                    MessageBox.Show("Invalid keypress enterd. Please check courser point", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                }
                   
                }

                if (result.Text == "")
                {
                    result.Text = "0";
                    equation.Text = "0";
                }                           
        }

    private void plusOrnegative_Click(object sender, EventArgs e)
        {
            if(result.Text == "")
            {
                result.Text = "-";
            } 
            else
            {
                result.Text = "-" + result.Text;
            }
        }


        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)Keys.Back)
                
            {
                Backspace.PerformClick();
            }

            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    Seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    devide.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;              
            }
        }

        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 500;
                mouseY = MousePosition.Y - 140;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}

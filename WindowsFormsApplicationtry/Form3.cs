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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 500;
                mouseY = MousePosition.Y - 140;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Backspace.Enabled = true;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
                equation.Text = result.Text;
            }
            else
                result.Text = result.Text + b.Text;
            equation.Text = result.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {

            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);
                equation.Text = equation.Text.Remove(equation.Text.Length - 1, 1);
            }

            if (result.Text == "")
            {
                result.Text = "0";
                equation.Text = "0";
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                if (b.Name == "sqrt")
                    result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                equal.PerformClick();
                operation_pressed = true;

                Backspace.Enabled = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else if(b.Name == "sqrt")
            {
                result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                value = Math.Sqrt(Double.Parse(result.Text));
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
                case "Mod":
                    result.Text = (value % Double.Parse(result.Text)).ToString();
                    break;
                case "Exp":
                    result.Text = Math.Pow(value, Double.Parse(result.Text)).ToString();
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
                MessageBox.Show("Invalid operation format enterd. Please enter valid operation format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result.Clear();
                equation.Text = "";
            }
            operation = "";
        }

        private void plusOrNegative_Click(object sender, EventArgs e)
        {
            if (result.Text == "")
            {
                result.Text = "-";
            }
            else
            {
                result.Text = "-" + result.Text;
            }
        }

        private void Log_Click(object sender, EventArgs e)
        {
            double klog = Double.Parse(result.Text);
            equation.Text = Convert.ToString("log" + "(" + (result.Text) + ")");
            klog = Math.Log10(klog);
            result.Text = System.Convert.ToString(klog);
        }

        private void pi_Click(object sender, EventArgs e)
        {
            result.Text = "3.141592654";
        }

        private void rootTwo_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            double iSinh = Double.Parse(result.Text);
            equation.Text = Convert.ToString("Sinh " + (result.Text));
            iSinh = Math.Sinh(iSinh);
            result.Text = Convert.ToString(iSinh);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                double iSin = Double.Parse(result.Text);
                equation.Text = Convert.ToString("Sin " + (result.Text));
                iSin = Math.Sin(iSin * (Math.PI/180f));
                result.Text = Convert.ToString(iSin);
            }
            catch
            {

            }
        }

        private void cube_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text)
                * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double iCos = Double.Parse(result.Text);
            equation.Text = Convert.ToString("Cos " + (result.Text));
            iCos = Math.Cos(iCos * (Math.PI/180f));
            result.Text = Convert.ToString(iCos);
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            double iCosh = Double.Parse(result.Text);
            equation.Text = Convert.ToString("Cosh " + (result.Text));
            iCosh = Math.Cosh(iCosh);
            result.Text = Convert.ToString(iCosh);
        }

        private void over_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(result.Text));
            result.Text = System.Convert.ToString(a);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double iTan = Double.Parse(result.Text);
            equation.Text = Convert.ToString("Tan " + (result.Text));
            iTan = Math.Tan(iTan * (Math.PI/180f));
            result.Text = Convert.ToString(iTan);
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            double iTanh = Double.Parse(result.Text);
            equation.Text = Convert.ToString("Tanh " + (result.Text));
            iTanh = Math.Tanh(iTanh);
            result.Text = Convert.ToString(iTanh);
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double klog = Double.Parse(result.Text);
            equation.Text = Convert.ToString("ln" + "(" + (result.Text) + ")");
            klog = Math.Log(klog);
            result.Text = System.Convert.ToString(klog);
        }

        private void PrsentTage_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(result.Text) / Convert.ToDouble(100);
            result.Text = System.Convert.ToString(a);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

    }
}

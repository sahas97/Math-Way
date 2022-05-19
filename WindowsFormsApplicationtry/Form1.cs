using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationtry
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            Thread thred = new Thread(new ThreadStart(formRun));
            thred.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thred.Abort();
            panelSlider.Width = 0;
            customizeDesing();           
            Control.SetIntial(this);       
        }

        private void formRun()
        {
            Application.Run(new Splash());
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
       

        private void customizeDesing()
        {
            panelfileMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelfileMenu.Visible == true)
                panelfileMenu.Visible = false; 
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }else
            {
                subMenu.Visible = false;
            }
        }

        private void standerd_btn_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.MdiParent = this;
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            f1.Show();
        }

        private void science_btn_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.MdiParent = this;
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(14, 14, 14);  
        }

        private void unit_btn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           timer1.Start();
           hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            f4.Show();
        }

        private void Filebtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panelfileMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Close();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Control.DoFullscreen(this);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Control.Minimize(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Control.DoMaximize(this, btn);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (panelSlider.Width == 152)
            {              
                panelSlider.Width = 0;
                timer1.Stop();
                //this.Refresh();
            }
            else
            {            
                panelSlider.Width = 152;
                timer1.Stop();
                //this.Refresh();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                mouseX = MousePosition.X - 400;
                mouseY = MousePosition.Y - 30;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.MdiParent = this;
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.MdiParent = this;
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            f1.Show();
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            hideSubMenu();
        }

       

        private void Exibtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Close();

        }

        private void Closeallbtn_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            panelSlider.Width = 0;
            pictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout f5 = new FormAbout();
            f5.MdiParent = this;
            panelSlider.Width = 0;
            hideSubMenu();
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            f5.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (dialog == DialogResult.No)
                {
               
                e.Cancel = true;
                hideSubMenu();
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}

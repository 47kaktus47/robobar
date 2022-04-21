using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robobar
{
    public partial class Form2 : Form
    {
        public Form4 fr4set;
        public Form2()
        {
            InitializeComponent();
            back_1.Click += back_1_Click;
        }
        private void back_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {   
            
        }

        private void Go_made_1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label2.Text);
            if (r > 0)
            {
                r--;
                label2.Text = Convert.ToString(r);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label2.Text);
            r++;
            label2.Text = Convert.ToString(r);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label3.Text);
            if (r > 0)
            {
                r--;
                label3.Text = Convert.ToString(r);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label3.Text);
            r++;
            label3.Text = Convert.ToString(r);
        }

        private void button6_Click(object sender, EventArgs e)
        {
             int r = int.Parse(label5.Text);
            if (r > 0)
            {
                r--;
                label5.Text = Convert.ToString(r);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label5.Text);
            r++;
            label5.Text = Convert.ToString(r);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label7.Text);
            r++;
            label7.Text = Convert.ToString(r);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label7.Text);
            if (r > 0)
            {
                r--;
                label7.Text = Convert.ToString(r);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label19.Text);
            if (r > 0)
            {
                r--;
                label19.Text = Convert.ToString(r);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label19.Text);
            r++;
            label19.Text = Convert.ToString(r);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label21.Text);
            if (r > 0)
            {
                r--;
                label21.Text = Convert.ToString(r);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label21.Text);
            r++;
            label21.Text = Convert.ToString(r);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label23.Text);
            if (r > 0)
            {
                r--;
                label23.Text = Convert.ToString(r);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label23.Text);
            r++;
            label23.Text = Convert.ToString(r);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label29.Text);
            r++;
            label29.Text = Convert.ToString(r);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label29.Text);
            if (r > 0)
            {
                r--;
                label29.Text = Convert.ToString(r);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label9.Text);
            if (r > 0)
            {
                r--;
                label9.Text = Convert.ToString(r);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label9.Text);
            r++;
            label9.Text = Convert.ToString(r);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label11.Text);
            r++;
            label11.Text = Convert.ToString(r);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label11.Text);
            if (r > 0)
            {
                r--;
                label11.Text = Convert.ToString(r);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label13.Text);
            if (r > 0)
            {
                r--;
                label13.Text = Convert.ToString(r);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label13.Text);
            r++;
            label13.Text = Convert.ToString(r);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label15.Text);
            r++;
            label15.Text = Convert.ToString(r);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label15.Text);
            if (r > 0)
            {
                r--;
                label15.Text = Convert.ToString(r);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label17.Text);
            if (r > 0)
            {
                r--;
                label17.Text = Convert.ToString(r);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label17.Text);
            r++;
            label17.Text = Convert.ToString(r);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label35.Text);
            if (r > 0)
            {
                r--;
                label35.Text = Convert.ToString(r);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label35.Text);
            r++;
            label35.Text = Convert.ToString(r);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label33.Text);
            r++;
            label33.Text = Convert.ToString(r);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label33.Text);
            if (r > 0)
            {
                r--;
                label33.Text = Convert.ToString(r);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label31.Text);
            if (r > 0)
            {
                r--;
                label31.Text = Convert.ToString(r);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label31.Text);
            r++;
            label31.Text = Convert.ToString(r);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label27.Text);
            r++;
            label27.Text = Convert.ToString(r);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label27.Text);
            if (r > 0)
            {
                r--;
                label27.Text = Convert.ToString(r);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label25.Text);
            if (r > 0)
            {
                r--;
                label25.Text = Convert.ToString(r);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int r = int.Parse(label25.Text);
            r++;
            label25.Text = Convert.ToString(r);
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }
    }
}

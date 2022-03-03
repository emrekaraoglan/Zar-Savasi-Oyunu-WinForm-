using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Zar : Form
    {
        public Zar()
        {
            InitializeComponent();
        }

        int tp1=0;
        int tp2 = 0;

        Random dice = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = dice.Next(1, 7);
            int b = dice.Next(1, 7);

            label3.Text = a.ToString();
            label4.Text = b.ToString();

            tp1 = tp1 + a + b;
            label6.Text = tp1.ToString();

           if (a==1)
            {
                pictureBox1.Visible=true;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (a == 2)
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (a == 3)
            {
                pictureBox5.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (a == 4)
            {
                pictureBox7.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (a == 5)
            {
                pictureBox9.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox11.Visible = false;
            }

            if (a == 6)
            {
                pictureBox11.Visible=true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
            }

            if (b == 1)
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (b == 2)
            {
                pictureBox4.Visible = true;
                pictureBox2.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (b == 3)
            {
                pictureBox6.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (b == 4)
            {
                pictureBox8.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (b == 5)
            {
                pictureBox10.Visible=true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox12.Visible = false;
            }

            if (b == 6)
            {
                pictureBox12.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            button1.Enabled = true;

            int c = dice.Next(1,7);
            int d = dice.Next(1,7);

            label10.Text = c.ToString();
            label9.Text = d.ToString();

            tp2 = tp2 + c + d;
            label7.Text = tp2.ToString();

            if (c == 1)
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (c == 2)
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (c == 3)
            {
                pictureBox5.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (c == 4)
            {
                pictureBox7.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
            }

            if (c == 5)
            {
                pictureBox9.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox11.Visible = false;
            }

            if (c == 6)
            {
                pictureBox11.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
            }

            if (d == 1)
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (d == 2)
            {
                pictureBox4.Visible = true;
                pictureBox2.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (d == 3)
            {
                pictureBox6.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (d == 4)
            {
                pictureBox8.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox10.Visible = false;
                pictureBox12.Visible = false;
            }

            if (d == 5)
            {
                pictureBox10.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox12.Visible = false;
            }

            if (d == 6)
            {
                pictureBox12.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox10.Visible = false;
            }

            if (Convert.ToInt32(label7.Text) > 100 && Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                MessageBox.Show("2.Oyuncu Kazandı!");
            }

            if (Convert.ToInt32(label6.Text) > 100 && Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                MessageBox.Show("1.Oyuncu Kazandı!");
            }

        }

        private void Zar_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}

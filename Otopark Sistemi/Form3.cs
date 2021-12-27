using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Sistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
            for(int i =0; i < Form1.doluAracSayac - 1; i++)
            {
                if (Form1.diziOtopark[i, 9] == "A1") // dizi elemanının ilgili değeri A1 ise 
                {
                    Form2.aracSayici = i; //değeri form2 de kullanılacak
                    button7.BackColor = Color.Red; // arkaplan rengini kırmızı yap
                    button7.Text = Form1.diziOtopark[i, 5]; // texti plaka olarak yaz
                }
                else if(Form1.diziOtopark[i, 9] == "A2")
                {
                    Form2.aracSayici = i;
                    button6.BackColor = Color.Red;
                    button6.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "A3")
                {
                    Form2.aracSayici = i;
                    button5.BackColor = Color.Red;
                    button5.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "A4")
                {
                    Form2.aracSayici = i;
                    button4.BackColor = Color.Red;
                    button4.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "A5")
                {
                    Form2.aracSayici = i;
                    button3.BackColor = Color.Red;
                    button3.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "B1")
                {
                    Form2.aracSayici = i;
                    button8.BackColor = Color.Red;
                    button8.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "B2")
                {
                    Form2.aracSayici = i;
                    button9.BackColor = Color.Red;
                    button9.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "B3")
                {
                    Form2.aracSayici = i;
                    button10.BackColor = Color.Red;
                    button10.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "B4")
                {
                    Form2.aracSayici = i;
                    button11.BackColor = Color.Red;
                    button11.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "B5")
                {
                    Form2.aracSayici = i;
                    button12.BackColor = Color.Red;
                    button12.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "C1")
                {
                    Form2.aracSayici = i;
                    button13.BackColor = Color.Red;
                    button13.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "C2")
                {
                    Form2.aracSayici = i;
                    button14.BackColor = Color.Red;
                    button14.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "C3")
                {
                    Form2.aracSayici = i;
                    button15.BackColor = Color.Red;
                    button15.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "C4")
                {
                    Form2.aracSayici = i;
                    button16.BackColor = Color.Red;
                    button16.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "C5")
                {
                    Form2.aracSayici = i;
                    button17.BackColor = Color.Red;
                    button17.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "D1")
                {
                    Form2.aracSayici = i;
                    button18.BackColor = Color.Red;
                    button18.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "D2")
                {
                    Form2.aracSayici = i;
                    button19.BackColor = Color.Red;
                    button19.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "D3")
                {
                    Form2.aracSayici = i;
                    button20.BackColor = Color.Red;
                    button20.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "D4")
                {
                    Form2.aracSayici = i;
                    button21.BackColor = Color.Red;
                    button21.Text = Form1.diziOtopark[i, 5];
                }
                else if (Form1.diziOtopark[i, 9] == "D5")
                {
                    Form2.aracSayici = i;
                    button22.BackColor = Color.Red;
                    button22.Text = Form1.diziOtopark[i, 5];
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 bilgiler = new Form2();
            bilgiler.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Red) //button rengi kırmızı ise işlem yapar
            {
                Form2 bilgiler = new Form2(); // form2 ye geçir sağlanır
                bilgiler.Show();
                this.Hide();
            }
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Red)
            {
                Form2 bilgiler = new Form2();
                bilgiler.Show();
                this.Hide();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

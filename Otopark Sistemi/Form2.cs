using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Otopark_Sistemi
{
   
    public partial class Form2 : Form
    {
        public static int aracSayici = 0;//yazdırılacak aracın sayacını tutar
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = Form1.diziOtopark[aracSayici, 1];
            textBox2.Text = Form1.diziOtopark[aracSayici, 2];
            textBox3.Text = Form1.diziOtopark[aracSayici, 3];
            textBox4.Text = Form1.diziOtopark[aracSayici, 4];
            textBox5.Text = Form1.diziOtopark[aracSayici, 5];
            textBox6.Text = Form1.diziOtopark[aracSayici, 6];
            textBox7.Text = Form1.diziOtopark[aracSayici, 7];
            textBox8.Text = Form1.diziOtopark[aracSayici, 8];
            comboBox1.Text = Form1.diziOtopark[aracSayici, 9];

            if(Form1.doluAracSayac==21)
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + (Form1.doluAracSayac-1); //son elemansa yani dizi doluysa
            else
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + Form1.doluAracSayac; //dizi dolu değil ise

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 yerler = new Form3();
            yerler.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Enabled = true; //fiyatlandırma kısmını aktif eder
            button1.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.doluAracSayac == 21) //arac sayısı 20 ise
                MessageBox.Show("Otopark Doludur!");
            else
            {
                int bosYer=1; //boş yer kontrolü
                for(int i = 0; i < Form1.doluAracSayac-1; i++)
                {
                    if(comboBox1.Text == Form1.diziOtopark[i, 9]) //eşleşme varsa o yer doludur
                    {
                        bosYer = 0;
                    }
                }
                if (bosYer == 1) // boş ver varsa
                {
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 1] = textBox1.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 2] = textBox2.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 3] = textBox3.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 4] = textBox4.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 5] = textBox5.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 6] = textBox6.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 7] = textBox7.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 8] = textBox8.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 9] = comboBox1.Text;
                    Form1.diziOtopark[Form1.doluAracSayac - 1, 0] = Convert.ToString(Form1.doluAracSayac);

                    Form1.doluAracSayac++;
                    if (Form1.doluAracSayac == 21)
                        textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + (Form1.doluAracSayac - 1);
                    else
                        textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + Form1.doluAracSayac;
                    MessageBox.Show("Araç Başarıyla Kaydedildi.");
                }
                else
                {
                    MessageBox.Show("Otopark Yeri Doludur Başka Yer Seç!");
                }
                
            }
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (aracSayici <= Form1.doluAracSayac-2) //bir sonraki değeri gösterir
            {
                if (aracSayici < 19)
                {
                    aracSayici++;
                    textBox1.Text = Form1.diziOtopark[aracSayici, 1];
                    textBox2.Text = Form1.diziOtopark[aracSayici, 2];
                    textBox3.Text = Form1.diziOtopark[aracSayici, 3];
                    textBox4.Text = Form1.diziOtopark[aracSayici, 4];
                    textBox5.Text = Form1.diziOtopark[aracSayici, 5];
                    textBox6.Text = Form1.diziOtopark[aracSayici, 6];
                    textBox7.Text = Form1.diziOtopark[aracSayici, 7];
                    textBox8.Text = Form1.diziOtopark[aracSayici, 8];
                    comboBox1.Text = Form1.diziOtopark[aracSayici, 9];
                }
                if (Form1.doluAracSayac == 21)
                    textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + (Form1.doluAracSayac - 1);
                else
                    textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + Form1.doluAracSayac;
                
            }
            if (aracSayici == Form1.doluAracSayac - 1)
                textBox9.Text = Form1.doluAracSayac + " / " + Form1.doluAracSayac;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (aracSayici >= 1)
            {
                aracSayici--; //bir önceki değeri gösterir
                textBox1.Text = Form1.diziOtopark[aracSayici, 1];
                textBox2.Text = Form1.diziOtopark[aracSayici, 2];
                textBox3.Text = Form1.diziOtopark[aracSayici, 3];
                textBox4.Text = Form1.diziOtopark[aracSayici, 4];
                textBox5.Text = Form1.diziOtopark[aracSayici, 5];
                textBox6.Text = Form1.diziOtopark[aracSayici, 6];
                textBox7.Text = Form1.diziOtopark[aracSayici, 7];
                textBox8.Text = Form1.diziOtopark[aracSayici, 8];
                if (Form1.doluAracSayac == 21)
                    textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + (Form1.doluAracSayac - 1);
                else
                    textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + Form1.doluAracSayac;
                comboBox1.Text = Form1.diziOtopark[aracSayici, 9];
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aracSayici = 0; // ilk elemanı gösterir
            textBox1.Text = Form1.diziOtopark[aracSayici, 1];
            textBox2.Text = Form1.diziOtopark[aracSayici, 2];
            textBox3.Text = Form1.diziOtopark[aracSayici, 3];
            textBox4.Text = Form1.diziOtopark[aracSayici, 4];
            textBox5.Text = Form1.diziOtopark[aracSayici, 5];
            textBox6.Text = Form1.diziOtopark[aracSayici, 6];
            textBox7.Text = Form1.diziOtopark[aracSayici, 7];
            textBox8.Text = Form1.diziOtopark[aracSayici, 8];
            if (Form1.doluAracSayac == 21)
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + (Form1.doluAracSayac - 1);
            else
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + Form1.doluAracSayac;
            comboBox1.Text = Form1.diziOtopark[aracSayici, 9];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            aracSayici=Form1.doluAracSayac-2; // son elemanı gösterir
            textBox1.Text = Form1.diziOtopark[aracSayici, 1];
            textBox2.Text = Form1.diziOtopark[aracSayici, 2];
            textBox3.Text = Form1.diziOtopark[aracSayici, 3];
            textBox4.Text = Form1.diziOtopark[aracSayici, 4];
            textBox5.Text = Form1.diziOtopark[aracSayici, 5];
            textBox6.Text = Form1.diziOtopark[aracSayici, 6];
            textBox7.Text = Form1.diziOtopark[aracSayici, 7];
            textBox8.Text = Form1.diziOtopark[aracSayici, 8];
            if (Form1.doluAracSayac == 21)
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + (Form1.doluAracSayac - 1);
            else
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + Form1.doluAracSayac;
            comboBox1.Text = Form1.diziOtopark[aracSayici, 9];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int odenecekPara = 0; //para ilk başta 0
            string aracPlakasi = ""; //yazdırılacak plaka
            string silinecekDeger = textBox1.Text; //eşleşmede silinecek değer
            for (int i = 0; i < Form1.doluAracSayac; i++)
            {
                if(Form1.diziOtopark[i, 1] == silinecekDeger)//eşleşme sağlanırsa
                {
                    aracPlakasi = Form1.diziOtopark[i, 5]; //plakayı kaydeder
                    Form1.diziOtopark[i, 0] = ""; //değerleri sıfırlar
                    Form1.diziOtopark[i, 1] = "";
                    Form1.diziOtopark[i, 2] = "";
                    Form1.diziOtopark[i, 3] = "";
                    Form1.diziOtopark[i, 4] = "";
                    Form1.diziOtopark[i, 5] = "";
                    Form1.diziOtopark[i, 6] = "";
                    Form1.diziOtopark[i, 7] = "";
                    Form1.diziOtopark[i, 8] = "";
                    Form1.diziOtopark[i, 9] = "";
                    int sira = i+1; // sırayı arttırır
                    for(int k = i+1; k < Form1.doluAracSayac; k++)
                    {
                        for(int m = 0; m < 10; m++)
                        {
                            
                            if (m == 0)
                            {
                                Form1.diziOtopark[k-1, m] = Convert.ToString(sira); // dizi elemanlarının ilk değerini düzenler
                                sira++;
                            }
                            else
                            {
                                if (k > 19) // son eleman ise
                                    continue;
                                else //değilse
                                    Form1.diziOtopark[k - 1, m] = Form1.diziOtopark[k, m]; //değer silindiği için, bir sonraki değeri bir öncekine kaydeder
                            }
                                 
                        }
                    }
                    break;
                }

            }
            //aracSayici--;
            Form1.doluAracSayac--;
            aracSayici = 0;
            textBox1.Text = Form1.diziOtopark[aracSayici, 1]; // textboxları doldurur
            textBox2.Text = Form1.diziOtopark[aracSayici, 2];
            textBox3.Text = Form1.diziOtopark[aracSayici, 3];
            textBox4.Text = Form1.diziOtopark[aracSayici, 4];
            textBox5.Text = Form1.diziOtopark[aracSayici, 5];
            textBox6.Text = Form1.diziOtopark[aracSayici, 6];
            textBox7.Text = Form1.diziOtopark[aracSayici, 7];
            textBox8.Text = Form1.diziOtopark[aracSayici, 8];
            if (Form1.doluAracSayac == 21)
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + (Form1.doluAracSayac - 1);
            else
                textBox9.Text = Form1.diziOtopark[aracSayici, 0] + " / " + Form1.doluAracSayac;
            comboBox1.Text = Form1.diziOtopark[aracSayici, 9];

            if (comboBox2.Text == "10dk") // ödenecek para işlemleri yapılır
                odenecekPara += 0;
            else if (comboBox2.Text == "30dk")
                odenecekPara += 2;
            else if (comboBox2.Text == "1 saat")
                odenecekPara += 3;
            else if (comboBox2.Text == "3 saat")
                odenecekPara += 5;
            else if (comboBox2.Text == "5 saat")
                odenecekPara += 10;
            else if (comboBox2.Text == "10 saat")
                odenecekPara +=15;
            else if (comboBox2.Text == "1 gün")
                odenecekPara += 25;

            if (checkBox1.Checked = true)
                odenecekPara += 10;
            if (checkBox2.Checked = true)
                odenecekPara += 10;

            MessageBox.Show(aracPlakasi +" "+ odenecekPara +" TL ödeme için teşekkür ederiz.\nYine bekleriz, Güle Güle.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

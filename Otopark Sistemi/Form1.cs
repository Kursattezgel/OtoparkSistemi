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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 fr2 = new Form2();

        public static string dosyayolu = @"C\Yeni:\deneme.txt"; //dosya yolu belirtildi

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 bilgiler = new Form2();
            bilgiler.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 yerler = new Form3();
            yerler.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter dosyayaYaz = new StreamWriter(dosyayolu);
            for (int i=0; i<20; i++)
            {
                if (diziOtopark[i, 0].Length < 1) //dizi uzunluğu 0'sa atlar
                    continue;
                else //değilse
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j < 9)
                        {
                            dosyayaYaz.Write(diziOtopark[i, j]);//bilgileri yan yana yazar
                            dosyayaYaz.Write("#");//araya # koyarak
                        }
                        else
                        {
                            dosyayaYaz.WriteLine(diziOtopark[i, j]); //son elemansa sonuna # koymadan alt satıra geçer
                        }
                    }
                }
                
            }
            dosyayaYaz.Close();
            MessageBox.Show("Dosyaya yazıldı.");
            
        }

        public static int doluAracSayac = 0; //dolu aracları tuttan bir sayac
        public static string[,] diziOtopark = new string[20, 10]; //2 boyutlu bir dizi, ilk boyutta araclar, ikincisinde bilgileri tutulur
        private void button1_Click(object sender, EventArgs e)
        {

            FileStream fileStream = new FileStream(dosyayolu, FileMode.OpenOrCreate, FileAccess.Read);
            
            int sayac = 0; //satır ve arac sırasını tutar
            using (StreamReader oku = new StreamReader(fileStream)) 
            {
                while (true)
                {
                    string satirr = oku.ReadLine(); // satırı okur
                    if (satirr == null) break; //boşsa sonlandırır
                    string[] words = satirr.Split('#'); // # ile parçalara ayırır

                    
                    for(int j = 0; j < 10; j++)
                    {
                        diziOtopark[sayac,j] = words[j]; //parçları dizi içerisine yerleştirir
                    }

                    sayac++;
                }
                doluAracSayac = sayac+1;
                for(int i=sayac; i < 20; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        diziOtopark[i, j] = ""; //doldurulmayan dizi elemanları boş tanımlanır

                    }

                }
                MessageBox.Show("Dosya Başarıyla Okundu.");
               
                oku.Close();
            }
            fileStream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    


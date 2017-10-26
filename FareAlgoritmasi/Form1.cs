using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareAlgoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] degerler;
        int xMax, yMax;
        bool duvar = true;
        bool mickey = false;
        bool minnie = false;
        int[] mickeyLocation = new int[2];
        //Duvar engeli sayısını tutmaktadır.
        int sayac = 0;
        bool dursunMu = false;
        int hareketSayisi = 0;

        public void Temizle()
        {
            pnlIcerik.Controls.Clear();
            txtX.Text = "";
            txtX.Enabled = true;
            txtY.Text = "";
            txtY.Enabled = true;
            btnCiz.Enabled = true;
            duvar = true;
            mickey = false;
            minnie = false;
            sayac = 0;
            hareketSayisi = 0;
            dursunMu = false;
            pnlIcerik.Enabled = true;
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            btnMickey.Enabled = true;
            btnMinnie.Enabled = false;
            btnCiz.Enabled = false;
            txtX.Enabled = false;
            txtY.Enabled = false;
            int Boy, En;
            bool BoyKontrol = true, EnKontrol = true;



            foreach (char item in txtX.Text)
            {
                if (item < 47 || item > 58)
                {
                    BoyKontrol = false;
                    break;
                }

            }

            foreach (char item in txtY.Text)
            {
                if (item < 47 || item > 58)
                {
                    EnKontrol = false;
                    break;

                }
            }
            //Inputlara girilen değerlerin kontrolü yapıldı
            if (BoyKontrol && EnKontrol && txtX.Text != "" && txtY.Text != "")
            {
                if (Convert.ToInt32(txtX.Text) > 15 || Convert.ToInt32(txtY.Text) > 20 || Convert.ToInt32(txtY.Text) < 4 || Convert.ToInt32(txtX.Text) < 4)
                {
                    MessageBox.Show("Lütfen boyu 15 eni 20'den fazla ve 4'ten küçük değer girmeyiniz!");
                    btnMickey.Enabled = false;
                    txtY.Enabled = true;
                    txtX.Enabled = true;
                    btnCiz.Enabled = true;

                }
                else
                {
                    Boy = Convert.ToInt32(txtX.Text);
                    En = Convert.ToInt32(txtY.Text);
                    //Girilen en ve boy değerlerine göre en*boy boyutunda oyun tahtası oluşturuldu.
                    degerler = new int[Boy, En];                    
                    for (int i = 0; i < Boy; i++)
                    {
                        for (int j = 0; j < En; j++)
                        {
                            degerler[i, j] = 0;
                        }
                    }
                    xMax = Boy;
                    yMax = En;
                    Ciz(Boy, En);
                }
            }
            else
            {
                MessageBox.Show("Lütfen sayı giriniz");
                btnMickey.Enabled = false;
                txtY.Enabled = true;
                txtX.Enabled = true;
                btnCiz.Enabled = true;
            }
        }


        private void btnDuvar_Click(object sender, EventArgs e)
        {
            PictureBox b = sender as PictureBox;
            string[] bol = new string[2];
            bol = b.Tag.ToString().Split(',');
            //Mickey fare ve Minnie farenin üzerlerine duvar engeli yerleştirilmesi engellendi
            if (duvar == true && degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] != -3 && degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] != -2)
            {
                b.Image = Properties.Resources.duvar;
                degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] = -1;
                sayac++;
            }
            
            else if (mickey)
            {
                //Duvar engeli üzerine Mickey farenin yerleştirilmesi engellendi
                if (degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] == -1)
                {
                    MessageBox.Show("Lütfen boş olanlara yerleştiriniz!");
                }
                else
                {
                    b.Image = Properties.Resources.mickey;
                    btnMinnie.Enabled = true;
                    mickey = false;
                    duvar = true;
                    btnMickey.Enabled = false;
                    degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] = -2;
                    mickeyLocation[0] = Convert.ToInt32(bol[0]);
                    mickeyLocation[1] = Convert.ToInt32(bol[1]);

                }
            }
            //Mickey farenin üzerine Minnie fare yerleştirilmesi engellendi
            else if (minnie && degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] != -2)
            {
                //Duvar engelinin üzerine Minnie fare yerleştirikmesi engellendi
                if (degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] == -1)
                {
                    MessageBox.Show("Lütfen boş olanlara yerleştiriniz!");
                }
                else
                {
                    b.Image = Properties.Resources.minnie;
                    minnie = false;
                    duvar = true;
                    btnMinnie.Enabled = false;
                    degerler[Convert.ToInt32(bol[0]), Convert.ToInt32(bol[1])] = -3;
                    btnBasla.Enabled = true;
                }
            }
            //Oyun tahtasıın tamamının duvar engeliyle kaplanması engellendi
            if (sayac == ((xMax - 2) * (yMax - 2)))
            {
                MessageBox.Show("Hatalı labirent çizimi!");
            }


        }


        private async void btnBasla_Click(object sender, EventArgs e)
        {
            //Mickey farenin duvar engelleri arasına sıkıştırılması engellendi
            if (degerler[mickeyLocation[0], mickeyLocation[1] - 1] == -1 &&
               degerler[mickeyLocation[0], mickeyLocation[1] + 1] == -1 &&
               degerler[mickeyLocation[0] - 1, mickeyLocation[1]] == -1 &&
               degerler[mickeyLocation[0] + 1, mickeyLocation[1]] == -1)
            {
                MessageBox.Show("Hatalı labirent çizimi !");
                dursunMu = true;
                btnMinnie.Enabled = false;
            }
            txtX.Enabled = false;
            txtY.Enabled = false;
            btnCiz.Enabled = false;
            pnlIcerik.Enabled = false;
            btnBasla.Enabled = false;
            await mickeyHareket();
            btnYeniOyun.Enabled = true;
        }

        private async Task<int> mickeyHareket()
        {
            int x = 1, y = 1;
            bool ilkMi = true;
            //Mickey fare Minnie fareyi bulduğunda hareketinin sonlandırılması sağlandı
            while (dursunMu == false)
            {
                if (x > xMax || y > yMax) break;
                int xBulunan = 0, yBulunan = y, min = 0, bulunan = 0;
                if (ilkMi == true)
                {
                    xBulunan = mickeyLocation[0];
                    yBulunan = mickeyLocation[1];
                    min = 1;
                    bulunan = mickeyLocation[1];
                    ilkMi = false;
                }


                int ust = y - 1;
                int alt = y + 1;
                int sol = x - 1;
                int sag = x + 1;
                int[] siralama = new int[] { int.MaxValue, degerler[x, ust], degerler[x, alt], degerler[sol, y], degerler[sag, y] };
                for (int i = 1; i < siralama.Length; i++)
                {
                    if (siralama[i] == -3)
                    {
                        MessageBox.Show("Minnie bulundu. Hareket Sayısı : " + hareketSayisi.ToString());
                        dursunMu = true;
                        break;
                    }
                    else if (hareketSayisi > Convert.ToInt32(txtX.Text) * Convert.ToInt32(txtY.Text) * 2)
                    {
                        MessageBox.Show("Hatalı labirent çizimi... Minnie bulunamadı:( ");
                        dursunMu = true;
                        break;
                    }
                    else
                    {
                        if (siralama[i] < siralama[min] && siralama[i] != -1)
                        {
                            min = i;
                            if (i == 1)
                            {
                                xBulunan = x;
                                yBulunan = ust;
                            }
                            else if (i == 2)
                            {
                                xBulunan = x;
                                yBulunan = alt;
                            }
                            else if (i == 3)
                            {
                                xBulunan = sol;
                                yBulunan = y;
                            }
                            else if (i == 4)
                            {
                                xBulunan = sag;
                                yBulunan = y;
                            }
                            bulunan = i;
                        }
                    }

                }
                if (dursunMu == true)
                {
                    break;
                }
                //Mickey farenin oyun tahtası üzerindeki gezinme işlemi sağlandı
                foreach (var i in pnlIcerik.Controls)
                {
                    if (i is PictureBox)
                    {
                        string[] bol = new string[2];
                        bol = (i as PictureBox).Tag.ToString().Split(',');

                        if (bol[0] == xBulunan.ToString() && bol[1] == yBulunan.ToString())
                        {
                            (i as PictureBox).Image = Properties.Resources.mickey;
                            (i as PictureBox).Text = "";
                            await Task.Delay(40);
                            degerler[xBulunan, yBulunan] += 1;
                            (i as PictureBox).Text = degerler[xBulunan, yBulunan].ToString();
                            (i as PictureBox).BackColor = Color.Transparent;
                            (i as PictureBox).Image = null;
                            hareketSayisi++;
                            break;
                        }
                    }
                }
                x = xBulunan;
                y = yBulunan;
                await Task.Delay(40);
            }
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Ekrana Mickey fare yerleştirilmesi işleminde kullanıldı
        private void btnMickey_Click(object sender, EventArgs e)
        {
            duvar = false;
            mickey = true;
        }
        //Ekrana Minnie fare yerleştirilmesi işleminde kullanıldı
        private void btnMinnie_Click(object sender, EventArgs e)
        {
            duvar = false;
            minnie = true;
            //İkinci bir Minnie fare yerleştirilmesi engellendi
            btnMinnie.Enabled = false;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            //Yeni oyun için oyun tahtası temizlenir
            Temizle();
        }

        private void Ciz(int x, int y)
        {
            //Oyun tahtasının kenarlarının duvar engeli ile oluşturulması sağlandı
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Duvar sembolü -1 olarak ayarlandı
                    if (i == 0)
                        degerler[i, j] = -1;
                    else if (j == 0)
                        degerler[i, j] = -1;
                    else if (j == y - 1)
                        degerler[i, j] = -1;
                    else if (i == x - 1)
                        degerler[i, j] = -1;
                        
                }
            }
            int xNoktasi = 0, yNoktasi = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Değeri -1 olan yere duvar engeli 0 olan yere boşluk geldi
                    PictureBox b = new PictureBox();
                    if (duvar == true)
                    {

                        if (degerler[i, j] == -1)
                        {
                            b.Image = Properties.Resources.duvar;
                        }
                        else
                        {
                            b.BackColor = Color.Transparent;
                        }
                    }

                    b.Top = yNoktasi;
                    b.Left = xNoktasi;
                    b.Height = 50;
                    b.Width = 50;
                    b.Tag = i + "," + j;
                    b.Click += btnDuvar_Click;
                    pnlIcerik.Controls.Add(b);
                    //Konum değişikliği yapıldı
                    if (j == y - 1)
                    {
                        xNoktasi = 0;
                        yNoktasi += 50;
                    }
                    else
                    {
                        xNoktasi += 50;
                    }
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumerator_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Takim Tkm = new Takim();//Var olan takim listesi butona her tıklandığında sıfırlanmasın diye Takim Class'ı Global tanımlandı.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oyuncu O = new Oyuncu();
            O.Adi = txtAdi.Text;
            O.DogumTarihi = DateTime.Now;
            O.FormaNo = 10;
            O.Mevki = "Ön libero";
            O.Soyadi = "Atik";
            O.Uyrugu = "Papua Yeni Gine";
            Tkm.Oyuncular.Add(O); //Tkm Class'ın da ki Oyuncular listesine her yeni girilen bilgi eklenecek
            lstElemanlar.Items.Add(O.Adi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tkm.Adi = "B312 Spor";
            Tkm.KurulusYili = Convert.ToDateTime("15.01.1993");
            Tkm.StadAdi = "19 Mayıs Stadı";
        }

        private void btnOyunculariListele_Click(object sender, EventArgs e)
        {
            foreach (Oyuncu item in Tkm.Oyuncular)
            {
                lstOyuncuListesi.Items.Add(item.Adi);
            }
        }
    }
}

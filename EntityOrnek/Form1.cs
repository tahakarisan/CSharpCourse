using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        DbSınavEntities dataBase = new DbSınavEntities();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDersListesi_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = dataBase.TBLDERSLER.ToList();
            dataGridView2.Columns[2].Visible = false;
        }

        private void btnÖğrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = dataBase.TBLOGRENCİ.ToList();
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in dataBase.TBLNOTLAR select new { item.NOTID, item.OGRENCI, item.DERS, item.SINAV1, item.SINAV2, item.SINAV3, item.DURUM, item.ORTALAMA };
            dataGridView2.DataSource = query.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCİ ogrenci = new TBLOGRENCİ();
            ogrenci.AD = txtÖğrenciAd.Text;
            ogrenci.SOYAD = txtÖğrenciSoyad.Text;
            dataBase.TBLOGRENCİ.Add(ogrenci);
            dataBase.SaveChanges();
            MessageBox.Show("Öğrenci Eklendi ");
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {    
                Kaydet();           
        }

        private void Kaydet()
        {
            TBLDERSLER ders = new TBLDERSLER();
            ders.DERSADI = txtDersAd.Text;
            dataBase.TBLDERSLER.Add(ders);
            dataBase.SaveChanges();
            MessageBox.Show("Ders Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {         
                Sil();
        }

        private void Sil()
        {
            int id = Convert.ToInt32(txtÖğrenciId.Text);
            var notlar = from not in dataBase.TBLNOTLAR where not.OGRENCI == id select not;
            if (notlar.Count() > 0)
            {
                DialogResult result = MessageBox.Show("Bu öğrencinin notları bulunmakta silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataBase.TBLNOTLAR.RemoveRange(notlar);
                    var query2 = dataBase.TBLOGRENCİ.Find(id);
                    dataBase.TBLOGRENCİ.Remove(query2);
                    dataBase.SaveChanges();
                    MessageBox.Show("Öğrenci sistemden silindi!");
                }
                else if (result == DialogResult.No)
                {
                    //do something else
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;

            BtnEkle.Enabled = true;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSehir.Text = "";
            TxtGorev.Text = "";
            TxtMaas.Text = "";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehir.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            ent.Gorev = TxtGorev.Text;

            LogicPersonel.LLPersonelEkle(ent);


            //listeleme kodları
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;

            BtnEkle.Enabled = true;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSehir.Text = "";
            TxtGorev.Text = "";
            TxtMaas.Text = "";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TxtID.Text);
            LogicPersonel.LLPersonelSil(ent.Id);

            //listeleme kodları
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;

            BtnEkle.Enabled = true;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSehir.Text = "";
            TxtGorev.Text = "";
            TxtMaas.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TxtID.Text);
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehir.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            ent.Gorev = TxtGorev.Text;

            LogicPersonel.LLPersonelGuncelle(ent);

            //listeleme kodları
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;

            BtnEkle.Enabled = true;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSehir.Text = "";
            TxtGorev.Text = "";
            TxtMaas.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtSehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtGorev.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtMaas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            BtnEkle.Enabled = false;
            BtnGuncelle.Enabled = true;
            BtnSil.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listeleme kodları
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
            BtnEkle.Enabled = true;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;

        }

    }
}

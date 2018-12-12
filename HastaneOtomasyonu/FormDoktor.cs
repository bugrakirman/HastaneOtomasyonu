﻿using HastaneOtomasyonu.ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }


        public List<Doktor> doktorlar = new List<Doktor>();

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {

            Doktor doktor = new Doktor();

            doktor.Ad = txtDoktorAd.Text;
            doktor.Soyad = txtDoktorSoyad.Text;
            doktor.Email = txtDoktorEmail.Text;
            doktor.Telefon = txtDoktorTelefon.Text;
            doktor.TCKN = txtDoktorTCKN.Text;
            doktor.Maas = txtDoktorMaas.Text;


            //doktor.DoktorBrans = cmbDoktorBrans.SelectedItem as DoktorBranslari;

            //switch (cmbdoktorbrans.selectedıtem as i)
            //{
            //    case doktorbranslari.genelcerrahi:

            //        break;
            //    case doktorbranslari.ıchastaliklari:
            //        break;
            //    case doktorbranslari.ortopedi:
            //        break;
            //    case doktorbranslari.uroloji:
            //        break;
            //    case doktorbranslari.kbb:
            //        break;
            //    case doktorbranslari.cocuksagligi:
            //        break;
            //    case doktorbranslari.kardiyoloji:
            //        break;
            //    case doktorbranslari.gözhastaliklaari:
            //        break;
            //    default:
            //        break;
            //}


            doktorlar.Add(doktor);

            lstDoktorlar.Items.Clear();

            foreach (var item in doktorlar)
            {
               
                lstDoktorlar.Items.Add(item);
            }
            

        }

        private void FormDoktor_Load(object sender, EventArgs e)
        {
            cmbDoktorBrans.Items.AddRange(Enum.GetNames(typeof(DoktorBranslari)));
            
        }
    }
}

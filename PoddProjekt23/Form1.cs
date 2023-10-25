﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Controllers;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PL

{
    public partial class Form1 : Form
    {
        PodcastController podcastController;
        KategoriController kategoriController;
        Podcast enPodcast = null;

        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            kategoriController = new KategoriController();  
            enPodcast = new Podcast();
            getGenre();
            getPodcast();   
        }

        private void buttonKategori_Click(object sender, EventArgs e)
        {
            string url = textBoxUrl.Text;
            
            enPodcast = podcastController.GetPodcast(url);
            //txtNamn.Text = enPodcast.Title;

            string kategori = CBKategori.Text;

            Kategori k = new Kategori(kategori);

            enPodcast.Kategori = k;
            
            string Namn = txtNamn.Text;
            if (!Namn.Equals(enPodcast.Title)) 
            {
                enPodcast.Namn = Namn;
            }

            listBoxInfo.Items.Add(enPodcast.Beskrivning);

            foreach (Avsnitt avsnitt in enPodcast.avsnittLista)
            {
                listBoxAvsnitt.Items.Add(avsnitt.Titel);
            }

            listBoxPoddar.Items.Add(enPodcast.AntalAvsnitt + " " + enPodcast.Title + " " + enPodcast.Frekvens + " " + Namn + " " + enPodcast.Kategori.Genre);
            podcastController.CreatePodcast(enPodcast);
        }

    
        
        private void label4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriForm form1 = new KategoriForm();
            form1.ShowDialog();
        }

        private void getGenre()
        {
            foreach (Kategori item in kategoriController.GetAll())
            {
                if (item.Genre != null)
                {
                    CBKategori.Items.Add(item.Genre);

                }
            }
        }



        private void getPodcast()
        {
            foreach (Podcast item in podcastController.GetAll())
            {

                listBoxPoddar.Items.Add(item.AntalAvsnitt + " " + item.Title + " " + item.Namn);
          
                    
                
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            object selectedItem = listBoxPoddar.SelectedItem;

            Kategori nyKategori = new Kategori(CBKategori.Text);

            string nyNamn = txtNamn.Text;


            if (selectedItem != null && !nyNamn.Equals(null) && !nyKategori.Equals(null))
            {
                //Podcast object för repo -> Podcast.txt
                Podcast nyPodcast = new Podcast(enPodcast.Title, nyKategori, enPodcast.Beskrivning, enPodcast.AntalAvsnitt, enPodcast.Frekvens, nyNamn);
                int selectedIndex = listBoxPoddar.SelectedIndex;
                podcastController.Change(selectedIndex, nyPodcast);


                listBoxPoddar.Items.RemoveAt(selectedIndex);
                //listBoxPoddar.Items.Clear();

                //Lokal object för listboxPoddar i string/int
                object nyPodd = enPodcast.AntalAvsnitt + " " + enPodcast.Title + " " + enPodcast.Frekvens + " " + nyNamn + " " + CBKategori.Text;
              
                    listBoxPoddar.Items.Insert(selectedIndex, nyPodd);

                //Problem uppstår pga att "Presistent" data inte finns i programmet, leder till tomma objekt vid omstart!!!

                //kontroll
                //MessageBox.Show("Ny namn: " + nyPodcast.Namn);
                //MessageBox.Show("Ny kategori: " + nyPodcast.Kategori.Genre);

              

            }
            else
            {
                //TODO: behöver valideras
            }
        }

      
    }
}

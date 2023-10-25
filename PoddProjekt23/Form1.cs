using System;
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
using Modelss;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PL

{
    public partial class Form1 : Form
    {  Validering validering= new Validering();
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

        private void getPodcast()
        {
            foreach (Podcast item in podcastController.GetAll())
            {
                listBoxPoddar.Items.Add(item.AntalAvsnitt + " " + item.Title + " " + item.Namn + " " + item.Kategori.Genre);

            }
        }

        private void buttonKategori_Click(object sender, EventArgs e)
        {

            List<Podcast> list = podcastController.GetAll();    

            if (!validering.NameInputValidate<string>(textBoxUrl.Text, list))
            {

                MessageBox.Show("Namnet finns redan, Vänligen skriv ett annat :)", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //else if (!validering.textInputsValidate(txtNamn.Text))
            //{

            //    MessageBox.Show("Endast bokstäver är tillåtna", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            else if (!validering.NullNotAcceptedValidate(txtNamn.Text, textBoxUrl.Text, CBKategori.Text))
            {
                MessageBox.Show("Fyll rutan!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                listBoxInfo.Items.Clear();
                listBoxAvsnitt.Items.Clear();
                string url = textBoxUrl.Text;

                enPodcast = podcastController.GetPodcast(url);
                txtNamn.Text = enPodcast?.Title;

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

                listBoxPoddar.Items.Add("Antal avsnitt: " + enPodcast.AntalAvsnitt + " Titel: " + enPodcast.Title + " Namn: " + enPodcast.Namn + " Kategori: " + enPodcast.Kategori.Genre);
                podcastController.CreatePodcast(enPodcast);


            }

          
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



        private void button2_Click(object sender, EventArgs e)
        {
            object selectedItem = listBoxPoddar.SelectedItem;
            string kategori = CBKategori.Text;

            Kategori kategori1 = new Kategori(kategori);
            string Namn = txtNamn.Text;
            Podcast nyPodcast = new Podcast(enPodcast.AntalAvsnitt, Namn, enPodcast.Title, kategori1, enPodcast.Beskrivning);

            if (selectedItem != null)
            {
                int selectedIndex = listBoxPoddar.SelectedIndex;
                podcastController.Change(selectedIndex, nyPodcast);

                listBoxPoddar.Items.Clear();

            }
            else
            {
                //TODO: behöver valideras
            }


        }

        private void listBoxPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPoddar.SelectedIndex;
            List<Podcast> allaPoddar = podcastController.GetAll();
           
                if (selectedIndex <= allaPoddar.Count)
                {
                    Podcast podd = allaPoddar[selectedIndex];
                    listBoxAvsnitt.Items.Clear();
                    listBoxInfo.Items.Clear();
                    listBoxInfo.Items.Add(podd.Beskrivning);
                List<Avsnitt> nyLista = podd.avsnittLista.Where(avsnitt => avsnitt != null)
                    .ToList();

                foreach (var avsnitt in nyLista)
                {
                    listBoxAvsnitt.Items.Add(avsnitt); // Antag att du vill lägga till avsnitten i listBoxAvsnitt.
                }


            }
           


        }
    }
}

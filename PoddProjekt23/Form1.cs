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
using System.Xml;
using System.Xml.Linq;
using BLL;
using BLL.Controllers;
using Models;
using Modelss;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PL

{
    public partial class Form1 : Form
    {
        Validering validering = new Validering();
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

                MessageBox.Show("Podden finns redan, Vänligen skriv ett annat :)", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                //txtNamn.Text = enPodcast?.Title;

                string kategori = CBKategori.Text;

                Kategori k = new Kategori(kategori);

                enPodcast.Kategori = k;

                string Namn = txtNamn.Text;
                if (!Namn.Equals(enPodcast.Title))
                {
                    enPodcast.Namn = Namn;
                }

                listBoxInfo.Items.Add(enPodcast.Beskrivning);

                foreach (Avsnitt avsnitt in enPodcast.AvsnittsLista)
                {
                    listBoxAvsnitt.Items.Add(avsnitt.Titel);
                }

                listBoxPoddar.Items.Add(enPodcast.AntalAvsnitt + " " + enPodcast.Title + " " + Namn + " " + enPodcast.Kategori.Genre);
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
                    CBKategori1.Items.Add(item.Genre);

                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            object selectedItem = listBoxPoddar.SelectedItem;
            string kategori = CBKategori.Text;

            Kategori nyKategori = new Kategori(CBKategori.Text);

            string nyNamn = txtNamn.Text;


            if (selectedItem != null && !nyNamn.Equals(null) && !nyKategori.Equals(null))
            {
                //Podcast object för repo -> Podcast.txt
                Podcast nyPodcast = new Podcast(enPodcast.AntalAvsnitt, nyNamn, enPodcast.Title, nyKategori, enPodcast.Beskrivning, enPodcast.AvsnittsLista);
                int selectedIndex = listBoxPoddar.SelectedIndex;
                podcastController.Change(selectedIndex, nyPodcast);


                listBoxPoddar.Items.RemoveAt(selectedIndex);
                //listBoxPoddar.Items.Clear();

                //Lokal object för listboxPoddar i string/int
                object nyPodd = enPodcast.AntalAvsnitt + " " + enPodcast.Title + " " + nyNamn + " " + CBKategori.Text;

                listBoxPoddar.Items.Insert(selectedIndex, nyPodd);

                //Problem uppstår pga att "Presistent" data inte finns i programmet, leder till tomma objekt vid omstart!!!


            }



        }

        private void listBoxPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPoddar.SelectedIndex;
            List<Podcast> allaPoddar = podcastController.GetAll();

            if (selectedIndex <= allaPoddar.Count && selectedIndex >= 0)
            {

                Podcast podd = allaPoddar[selectedIndex];
                listBoxAvsnitt.Items.Clear();
                listBoxInfo.Items.Clear();
                listBoxInfo.Items.Add(podd.Beskrivning);
                Console.WriteLine(podd.AvsnittsLista.Count);
                foreach (Avsnitt avsnitt in podd.AvsnittsLista)
                {
                    listBoxAvsnitt.Items.Add(avsnitt);
                    Console.WriteLine(avsnitt);

                }
            }
        }
      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPoddar.SelectedIndex;

            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Är du säker att du vill ta bort?", "Ta bort podcast", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    PodcastController controller = new PodcastController();
                    controller.Delete(selectedIndex);
                    listBoxPoddar.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void CBKategori1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Podcast> podcasts = podcastController.GetAll();

            object selectedItem = CBKategori1.SelectedItem;

            if (selectedItem != null && selectedItem is string selectedCategory)
            {
                var filteredPodcasts = podcasts.Where(p => p.Kategori.Genre == selectedCategory).ToList();
                listBoxPoddar.Items.Clear();
                listBoxPoddar.Items.AddRange(filteredPodcasts.Select(p => p.Title).ToArray());
            }

        }
    }

}

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
            listBoxPoddar.Items.Clear();
            foreach (Podcast item in podcastController.GetAll())
            {
                listBoxPoddar.Items.Add(item.Title + " " + item.Namn + " " + item.Kategori.Genre);
            }
        }

        private void buttonKategori_Click(object sender, EventArgs e)
        {  try
            {
            string url = textBoxUrl.Text;
            enPodcast = podcastController.GetPodcast(url);

            if (enPodcast != null)
            {
                List<Podcast> list = podcastController.GetAll();

                if (!validering.NameInputValidate(enPodcast.Title, list))
                {
                    MessageBox.Show("Podden finns redan registrerat, vänligen försök med en annan :)", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show("Hittar inte podden, försök med en annan url! :)", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (!validering.textInputsValidate(txtNamn.Text))
            {

                MessageBox.Show("Endast bokstäver är tillåtna i namnet!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (!validering.NullNotAcceptedValidate(txtNamn.Text, textBoxUrl.Text, CBKategori.Text))
                {
                    MessageBox.Show("Fyll i alla uppgifter!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    listBoxAvsnitt.Items.Clear();
                    listBoxInfo.Clear();



                    if (enPodcast != null)
                    {
                        string kategori = CBKategori.Text;

                        Kategori k = new Kategori(kategori);

                        enPodcast.Kategori = k;

                        string Namn = txtNamn.Text;
                        if (!Namn.Equals(enPodcast.Title))
                        {
                            enPodcast.Namn = Namn;
                        }

                        foreach (Avsnitt avsnitt in enPodcast.AvsnittsLista)
                        {
                            listBoxAvsnitt.Items.Add(avsnitt.Titel);
                        }

                        listBoxPoddar.Items.Add(enPodcast.Title + " " + Namn + " " + enPodcast.Kategori.Genre);
                        podcastController.CreatePodcast(enPodcast);
                    }
                }  
            }

        catch( Exception ex)
            {
                Validering.ExceptionFinder(ex); 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            KategoriForm form1 = new KategoriForm();
            
            // En händelsehanterare för FormClosing-händelsen
            form1.FormClosing += (s, ef) =>
            {
                getGenre();
            };
            form1.ShowDialog();

        }

        private void getGenre()
        {
            CBKategori.Items.Clear();
            CBKategori1.Items.Clear();
            CBKategori1.Items.Add("Alla Poddar");
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
            try
            {
                Kategori nyKategori = new Kategori(CBKategori.Text);

                string nyNamn = txtNamn.Text;

                List<Podcast> allaPoddar = podcastController.GetAll();

                if (!validering.textInputsValidate(txtNamn.Text))
                {

                    MessageBox.Show("Endast bokstäver är tillåtna i namnet!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (!validering.NullNotAcceptedValidateK(txtNamn.Text))
                {
                    MessageBox.Show("Fyll i namn!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (!validering.NullNotAcceptedValidateK(CBKategori.Text))
                {
                    MessageBox.Show("Fyll i kategori!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int selectedIndex = listBoxPoddar.SelectedIndex;

                    Podcast podd = allaPoddar[selectedIndex];

                    podd.Namn = nyNamn;
                    podd.Kategori = nyKategori;
                    podcastController.Change(selectedIndex, podd);

                    getPodcast();

                }
            }

         catch(Exception ex)
            {
                Validering.ExceptionFinder(ex); 
            
            
            }
          
        

    }

        private void listBoxPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPoddar.SelectedIndex;
            List<Podcast> allaPoddar = podcastController.GetAll();

            if (selectedIndex <= allaPoddar.Count && selectedIndex >= 0)
            {
                Podcast podd = allaPoddar[selectedIndex];
                txtNamn.Text = podd.Namn;
                listBoxAvsnitt.Items.Clear();
                listBoxInfo.Clear();
                foreach (Avsnitt avsnitt in podd.AvsnittsLista)
                {
                    listBoxAvsnitt.Items.Add(avsnitt.Titel);
                }
            }
        }

        private void listBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPoddar.SelectedIndex;
            List<Podcast> allaPoddar = podcastController.GetAll();

            if (selectedIndex <= allaPoddar.Count && selectedIndex >= 0)
            {
                Podcast podd = allaPoddar[selectedIndex];
                foreach (Avsnitt avsnitten in podd.AvsnittsLista)
                {
                    int selectedAvsnitt = listBoxAvsnitt.SelectedIndex;
                    Avsnitt avsnitt = podd.AvsnittsLista[selectedAvsnitt];
                    listBoxInfo.Clear();
                    listBoxInfo.Text = avsnitt.Beskrivning;

                }
            }
        }

        private void CBKategori1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Podcast> podcasts = podcastController.GetAll();

            object selectedItem = CBKategori1.SelectedItem;
            if(selectedItem.Equals("Alla Poddar")) 
            {
                getPodcast();
            }
            else if (selectedItem != null && selectedItem is string selectedCategory)
            {
                var filteredPodcasts = podcasts.Where(p => p.Kategori.Genre.Equals(selectedCategory)).ToList();
                listBoxPoddar.Items.Clear();
                listBoxPoddar.Items.AddRange(filteredPodcasts.Select(p => p.Title).ToArray());
            }
        
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        { try
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
        catch (Exception ex)
            {
                Validering.ExceptionFinder(ex); 
            }
           
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Models;
using BLL.Controllers;

namespace PL
{
    public partial class KategoriForm : Form
    {

        KategoriController controller;
        public KategoriForm()
        {
            controller = new KategoriController();
            InitializeComponent();
            getGenre();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string KategoriNamn = textBox1.Text;
            controller.CreateKategori(KategoriNamn);
            listBox1.Items.Clear();
            getGenre();
            
        }

        private void getGenre()
        {
            foreach (Kategori item in controller.GetAll())
            {
                if (item.Genre != null)
                {
                    listBox1.Items.Add(item.Genre);

                }
            }     
        }

    private void changeButton_Click_1(object sender, EventArgs e)
        {
            object selectedItem = listBox1.SelectedItem;
            Kategori andrarKategori = new Kategori(textBox1.Text);
            if (selectedItem != null && textBox1.Text != null)
            {
                int selectedIndex = listBox1.SelectedIndex;
                controller.Change(selectedIndex, andrarKategori);

                listBox1.Items.Clear();
                getGenre();
            }
            else { 
            //TODO: behöver valideras
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            object selectedItem = listBox1.SelectedItem;
            if (selectedItem != null)

            {
                DialogResult result = MessageBox.Show("Är du säker att du vill ta bort?", "Ta bort kategori", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string value = listBox1.SelectedItem.ToString();
                    controller.Delete(value);
                    listBox1.Items.Clear();
                    getGenre();
                }

            }



        }
    }
}

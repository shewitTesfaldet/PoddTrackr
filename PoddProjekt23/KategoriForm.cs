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
using Modelss;

namespace PL
{
    public partial class KategoriForm : Form
    {
        Validering validering= new Validering();
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
            List<Kategori> list = controller.GetAll();

            if (!validering.NameInputValidate<string>(textBox1.Text, list))
            {

                MessageBox.Show("Kategorin finns redan, Vänligen skriv ett annat :)", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (!validering.textInputsValidate(textBox1.Text))
            {

                MessageBox.Show("Endast bokstäver är tillåtna", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (!validering.NullNotAcceptedValidateK(textBox1.Text))
            {
                MessageBox.Show("Fyll rutan!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                string KategoriNamn = textBox1.Text;
                controller.CreateKategori(KategoriNamn);
                listBox1.Items.Clear();
                getGenre();
            }
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
            List<Kategori> list = controller.GetAll();

            if (!validering.NameInputValidate<string>(textBox1.Text, list))
            {

                MessageBox.Show("Kategorin finns redan, Vänligen skriv ett annat :)", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (!validering.textInputsValidate(textBox1.Text))
            {

                MessageBox.Show("Endast bokstäver är tillåtna", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (!validering.NullNotAcceptedValidateK(textBox1.Text))
            {
                MessageBox.Show("Fyll rutan!", "Felaktig Inmatning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
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

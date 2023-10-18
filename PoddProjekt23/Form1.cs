using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;


namespace PL

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKategori_Click(object sender, EventArgs e)
        {
            KategoriForm kategoriForm = new KategoriForm();  
            kategoriForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

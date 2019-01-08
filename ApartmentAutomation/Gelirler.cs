using ApartmentAutomation.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentAutomation
{
    public partial class Gelirler : Form
    {
        GelirRepo rep = new GelirRepo();
        public Gelirler()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Gelir newGelir = new Gelir();
            newGelir.DaireNo = (int)numericUpDown1.Value;
            newGelir.Tutar = Convert.ToDecimal(textBox1.Text);
            newGelir.Tarih = (DateTime)dateTimePicker1.Value;
            rep.InsertGelir(newGelir);
            RefreshGelir();
            
        }
        private void RefreshGelir()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rep.GelirGetir();
        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            RefreshGelir();
        }
    }
}

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
    public partial class Giderler : Form
    {
        GiderRepo gider = new GiderRepo();
        public Giderler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gider newGider = new Gider();
            newGider.MasrafTuru = comboBox1.SelectedItem.ToString();
            newGider.Tutar = Convert.ToDecimal(textBox1.Text);
            newGider.Tarih = (DateTime)dateTimePicker1.Value;
            gider.InsertGider(newGider);
            Refreshgelir();
            
        }
        private void Refreshgelir()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gider.GiderGetir();
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            Refreshgelir();
            comboBox1.DataSource = Enum.GetValues(typeof(MasrafTuru));
        }
    }
}

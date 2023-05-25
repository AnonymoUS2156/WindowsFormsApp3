using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rent_MallEntities rentEnt = new Rent_MallEntities();

        List<Pavilion> pavilions = new List<Pavilion>();
        List<Pavilion> PavChanged = new List<Pavilion>();



        private void Form1_Load(object sender, EventArgs e)
        {
            PavChanged = pavilions = rentEnt.Pavilion.ToList();
            loadStartData();
            LoadDataCombo();
        }

        private void loadStartData()
        {
            pavilionBindingSource1.DataSource = PavChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrfer();
        }

        private void LoadDataCombo()
        {
            comboBox1.DataSource = typeof(Pavilion).GetProperties().Where(x => !x.GetMethod.Attributes.ToString().Contains("Virtual")).Select(x => x.Name).ToList();
            comboBox1.SelectedIndex = 0;
        }

        private void LoadOrfer()
        {
            PavChanged = checkBox1.Checked ? PavChanged.OrderByDescending(p => p.GetType().GetProperties().First(x => x.Name == comboBox1.SelectedItem.ToString()).GetValue(p)).ToList() :
                PavChanged.OrderBy(p => p.GetType().GetProperties().First(x => x.Name == comboBox1.SelectedItem.ToString()).GetValue(p)).ToList();
            loadStartData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrfer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PavChanged = pavilions.Where(x => x.Status.Contains(textBox1.Text)).ToList();
            LoadOrfer();
        }
    }
}

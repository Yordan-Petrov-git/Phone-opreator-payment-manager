using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example30
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void nowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult yn = MessageBox.Show("Сигурни ли сте ,че искате да излезете?", "Изход",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yn == DialogResult.Yes) Close();
        }

        private void всичкиПродажбиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new spisak().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Glavna_Load(object sender, EventArgs e)
        {

            timer1.Tick += new EventHandler(timer1_Tick);
            label1.Text = DateTime.Now.ToString();

        }

        private void продажбиПоВидToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new spravkavid().Show();

        }

        private void новКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vavejdane().Show();
        }

        private void търсенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Tarsene_po_ime_ili_nomer().Show();
        }

        private void телефонИлиИмеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Otchet_i_zapisvane().Show();
        }

        private void времетраенеНаРазговориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Vremetraener().Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

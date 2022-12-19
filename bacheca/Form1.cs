using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bacheca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bacheca bacheche;
        public annuncio nuovo;
        public annuncio nuovi;
        public int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 20);
            listView1.Columns.Add("Nota", 140);
            listView1.Columns.Add("Data", 90);
            listView1.Columns.Add("Prezzo", 60);

            bacheche = new bacheca("1");

        }

        public void riempi(annuncio v)
        {
            listView1.Items.Add(Convert.ToString(v.Id));
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.Testo);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.Data);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToString(v.Prezzo));

        }
        public void Pulizia()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        public void Eliminaitem()
        {
            for (int i = 0; i < count; i++)
            {
                listView1.Items.Remove(listView1.Items[0]);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            nuovo = new annuncio(count, textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            bacheche.Aggiungi(nuovo);
            riempi(nuovo);
            count++;
            Pulizia();
            label5.Text = ("Prezzo tot: " + Convert.ToString(bacheche.Costotot()));


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int prova = listView1.FocusedItem.Index;
            MessageBox.Show(Convert.ToString(prova));
            listView1.Items.Remove(listView1.SelectedItems[0]);
            bacheche.Remove(prova);
            label5.Text = ("Prezzo tot: " + Convert.ToString(bacheche.Costotot()));
            Pulizia();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gino = listView1.SelectedItems[0].SubItems[0].Text;
            nuovi = new annuncio(Convert.ToInt32(gino), textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            bacheche.Modifica(nuovi);
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[1].Text = nuovi.Testo;
                listView1.SelectedItems[0].SubItems[2].Text = nuovi.Data;
                listView1.SelectedItems[0].SubItems[3].Text = Convert.ToString(nuovi.Prezzo);

            }
            label5.Text = ("Prezzo tot: " + Convert.ToString(bacheche.Costotot()));
            Pulizia();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            annuncio[] a = new annuncio[999];
            Eliminaitem();
            bacheche.OrdinaP();
            a = bacheche.prodotti();

            for (int i = 0; i < count; i++)
            {
                riempi(a[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

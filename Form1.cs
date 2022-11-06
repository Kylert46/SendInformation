using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Reflection.Emit;

namespace Gestione_ListBox
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void comboEta_DropDown(object sender, EventArgs e)
        {
            //la ComboBox età viene popolata "a volo"
            comboEta.Items.Clear();
            for (int i = 16; i <= 30; i++)
            {
                comboEta.Items.Add(i);
            }
        }

        private void bEsci_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confermi?", "Esci dall'applicazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nessuna riga della ListBox è stata selezionata", this.Text);
                return;
            }
            int scelta = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(scelta);
            lNumeroRighe.Text = "Numero righe: " + listBox1.Items.Count.ToString();
        }

      

        private void bReset_Click(object sender, EventArgs e)
        {
            tNome.Text = "";
            comboEta.Text = "";
            radioF.Checked = true;
            checkLettura.Checked = false;
            checkCinema.Checked = false;
            checkSport.Checked = false;
            checkInternet.Checked = false;
            checkMusica.Checked = false;
            checkViaggi.Checked = false;
        }

        private void comboEta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0; // impedisce di scrivere nella ComboBox
        }

        private void bInserisci_Click(object sender, EventArgs e)
        {
            if (tNome.Text == "" || comboEta.Text == "")
            {
                MessageBox.Show("Nome ed età sono obbligatori", this.Text);
                return;
            }
            string  s="";// la stringa che verrà inserita nella ListBox
            s += tNome.Text+ " - ";
            if (radioM.Checked)
                s += " M - ";
            else
                s += " F -";
            s += " Anni " + comboEta.Text + " - ";
            string interessi = "";
            if (checkLettura.Checked) interessi = interessi + checkLettura.Text+" ";
            if (checkCinema.Checked) interessi = interessi + checkCinema.Text + " ";
            if (checkSport.Checked) interessi = interessi + checkSport.Text + " ";
            if (checkInternet.Checked) interessi = interessi + checkInternet.Text + " ";
            if (checkMusica.Checked) interessi = interessi + checkMusica.Text + " ";
            if (checkViaggi.Checked) interessi = interessi + checkViaggi.Text;
            if(interessi!="")  s += "Interessi: " + interessi;
            listBox1.Items.Add(s);
            lNumeroRighe.Text = "Numero righe: " + listBox1.Items.Count.ToString();
            bReset_Click(sender, e);
        }

        private void bOrdina_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void bSalva_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;
            //
            SaveFileDialog Sf = new SaveFileDialog();
            Sf.Filter = "File di testo |*.txt";
            if (Sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fout = new StreamWriter(Sf.FileName);
                for(int i=0;i<listBox1.Items.Count;i++)
                fout.WriteLine(listBox1.Items[i]);
                fout.Close();
            }
        }

        private void tNome_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^(?=.{4,16}$)[A-Z][a-z]*(\s[A-Z][a-z]*)*_[A-Z][a-z]*(\s[A-Z][a-z]*)*")).IsMatch(tNome.Text))
            {
                tNome.ForeColor = Color.Black;
            }
            else
            {
                tNome.ForeColor = Color.Red;
            }
        }
    }
}

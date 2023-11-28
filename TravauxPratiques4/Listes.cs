using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravauxPratiques4
{
    public partial class Listes : Form
    {
        public Listes()
        {
            InitializeComponent();
        }

        private void BtnAjout1_Click(object sender, EventArgs e)
        {
            if (TxtN.Text.Trim() != "")
            {
                LstG1.Items.Add(TxtN.Text);
                TxtN.Text = "";
                TxtN.Focus();
            }
            else
                MessageBox.Show("Il faut saisir une valeur");
        }

        private void BtnSupp1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1)
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            else
                MessageBox.Show("Aucun élément n'est sélectionné");
        }

        private void BtnGD1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1)
            {
                LstD1.Items.Add(LstG1.SelectedItem);
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            }
            else
                MessageBox.Show("Aucun élément n'est sélectionné");
        }

        private void BtnTGD1_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstG1.Items)
            {
                LstD1.Items.Add(x);
            }
            LstG1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LstD1.SelectedIndex != -1)
            {
                LstG1.Items.Add(LstD1.SelectedItem);
                LstD1.Items.RemoveAt(LstD1.SelectedIndex);
            }
            else
                MessageBox.Show("Aucun élément n'est sélectionné");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstD1.Items)
            {
                LstG1.Items.Add(x);
            }
            LstD1.Items.Clear();
        }

        private void BtnVider1_Click(object sender, EventArgs e)
        {
            // Vider la liste de gauche
            LstG1.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Object> coll = new List<Object>();
            foreach (Object x in LstG2.SelectedItems)
            {
                coll.Add(x);
                LstD2.Items.Add(x);
            }
            foreach (Object x in coll)
            {
                LstG2.Items.Remove(x);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Object> coll = new List<Object>();
            foreach (Object x in LstD2.SelectedItems)
            {
                coll.Add(x);
                LstG2.Items.Add(x);
            }
            foreach (Object x in coll)
            {
                LstD2.Items.Remove(x);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstG2.Items)
            {
                LstD2.Items.Add(x);
            }
            LstG2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstD1.Items)
            {
                LstG2.Items.Add(x);
            }
            LstD1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Ajouter un element dans la liste de gauche
            if (textBox1.Text.Trim() != "")
            {
                LstG2.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
                MessageBox.Show("Il faut saisir une valeur");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vider la liste de gauche
            LstG2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Supprimer tous les éléments sélectionnés
            List<Object> coll = new List<Object>();
            foreach (Object x in LstG2.SelectedItems)
            {
                coll.Add(x);
            }
            foreach (Object x in coll)
            {
                LstG2.Items.Remove(x);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Ajouter un element dans la liste de gauche
            if (textBox2.Text.Trim() != "")
            {
                checkedListBox1.Items.Add(textBox2.Text);
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
                MessageBox.Show("Il faut saisir une valeur");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Vider le checkedListBox
            checkedListBox1.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Supprimer les elements cochés
            foreach (Object x in checkedListBox1.CheckedItems)
            {
                checkedListBox1.Items.Remove(x);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<Object> list = new List<Object>();
            foreach (Object x in checkedListBox1.CheckedItems)
            {
                list.Add(x);
            }
            foreach (Object x in list)
            {
                checkedListBox2.Items.Add(x);
                checkedListBox1.Items.Remove(x);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            foreach (Object x in checkedListBox1.CheckedItems)
            {
                checkedListBox2.Items.Add(x);
            }
            checkedListBox1.Items.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<Object> list = new List<Object>();
            foreach (Object x in checkedListBox2.CheckedItems)
            {
                list.Add(x);
            }
            foreach (Object x in list)
            {
                checkedListBox1.Items.Add(x);
                checkedListBox2.Items.Remove(x);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (Object x in checkedListBox2.CheckedItems)
            {
                checkedListBox1.Items.Add(x);
            }
            checkedListBox2.Items.Clear();
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // AJouter un element dans la liste de gauche
            if (textBox3.Text.Trim() != "")
            {
                listBox2.Items.Add(textBox3.Text);
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
                MessageBox.Show("Il faut saisir une valeur");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Supprimer tous les éléments sélectionnés
            List<Object> coll = new List<Object>();
            foreach (Object x in listBox2.SelectedItems)
            {
                coll.Add(x);
            }
            foreach (Object x in coll)
            {
                listBox2.Items.Remove(x);
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.DoDragDrop(listBox2.SelectedItem, DragDropEffects.Move);
            }
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Move);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Swiat_Alkoholi_Kiril_Zlotnikov1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxLokal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length != 0)
            {
                richTextBox1.Text += comboBox1.Text;
                richTextBox1.Text += ", ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string path = @"C:\Zamówienia\" + textBoxName.Text + "_" + textBoxForename.Text + ".txt";
                string tekst = "Dane klienta: \r\n ";
                tekst += "Imię: " + textBoxName.Text + " " + "Nazwisko: " + " " + textBoxForename.Text + "\r\n ";
                tekst += "Adres: " + textBoxAdres.Text + "\r\n";
                tekst += "Zamówienie: " + richTextBox1.Text + "\r\n";
                tekst += "Data złożenia zamówienia: " + DateTime.Now.ToString("dddd, dd MM yyyy") + "\r\n";
                if (textBoxName.Text.Length == 0 || textBoxForename.Text.Length == 0 || textBoxAdres.Text.Length == 0)
                {
                    MessageBox.Show("Podaj imię, nazwisko i adres");
                }
                else
                {
                    if (!File.Exists(path))
                    {
                        File.WriteAllText(path, tekst);
                    }
                    else
                    {
                        string zmiana = "";
                        zmiana += "Data złożenia zamówienia: " + DateTime.Now.ToString("dddd, dd MM yyyy") + "\r\n";
                        File.AppendAllText(path, zmiana);
                    }
                }

            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int data = int.Parse(dateTimePicker1.Value.ToString("yyyyMMdd"));
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int wiek = ((now - data) / 10000);
            if (wiek >= 18)
            {
                panel1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                button2.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

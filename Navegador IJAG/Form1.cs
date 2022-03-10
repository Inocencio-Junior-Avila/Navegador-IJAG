using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_IJAG
{
    public partial class Form1 : Form
    {
        List<string> favoritos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtdireccion.Text);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void delante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            Actualizar();
        }
        private void Actualizar()
        {
            cmdfav.Items.Clear();
            foreach (string direccion in favoritos)
            {
                cmdfav.Items.Add(direccion);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
            txtdireccion.Text = "";
        }

        private void cmdfav_SelectedIndexChanged(object sender, EventArgs e)
        {

            webBrowser1.Navigate(cmdfav.SelectedItem.ToString());
            Actualizar();
        }
    }
}

using Adivinanza.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinanza.Front
{
    public partial class menu : Form
    {
        public string nombre;
        public menu(string nombre)
        {
            InitializeComponent();

            this.nombre = nombre;

            lblSaludo.Text = "Bienvenid@ " + nombre + "!!";

            lblSaludo.Enabled = true;
            lblSaludo.Visible = true;

            lblChau.Enabled = false;
            lblChau.Visible = false;
        }

        public async void btNo_Click(object sender, EventArgs e)
        {
            lblSaludo.Visible = false;
            lblPreg.Enabled = false;
            lblPreg.Visible = false;
            btSi.Enabled = false;
            btSi.Visible = false;
            btNo.Enabled = false;
            btNo.Visible = false;

            lblChau.Text = "Gracias por jugar con nosotros, " + nombre + "!!";
            lblChau.Visible = true;

            await Task.Delay(2000);

            Application.Exit();
        }

        public void btSi_Click(object sender, EventArgs e)
        {
            Jugada jugada = new Jugada();

            jugada.Visible = true;

            jugada.Show();

            this.Hide();
        }
    }
}

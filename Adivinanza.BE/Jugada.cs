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
    public partial class Jugada : Form
    {
        public int numeroSecreto;
        public int intentos;
        public List<int> intentosRealizados;
        public Jugada()
        {
            InitializeComponent();
            ReiniciarJuego();
            numsecreto.Text = numeroSecreto.ToString();
        }

        public void btAdivinar_Click(object sender, EventArgs e)
        {
            Adivinar();
        }

        public async void Adivinar()
        {
            int adivinanza = int.Parse(txtNumero.Text);
            intentosRealizados.Add(adivinanza);
            intentos++;

            if (adivinanza < numeroSecreto)
            {
                lblResultado.Text = "El número es mayor.";
            }
            else if (adivinanza > numeroSecreto)
            {
                lblResultado.Text = "El número es menor.";
            }
            else if (adivinanza == numeroSecreto)
            {
                lblResultado.Text = $"¡Felicidades! Adivinaste el número en {intentos} intentos.";
                btAdivinar.Enabled = false;
                await Task.Delay(1500);
            }

            if (intentos > 10)
            {
                lblResultado.Text = $"Has superado el límite de intentos. El número secreto era {numeroSecreto}.";
                btAdivinar.Enabled = false;
                await Task.Delay(1500);
            }
        }
        public void ReiniciarJuego()
        {
            Random random = new Random();
            numeroSecreto = random.Next(1, 101);
            intentos = 0;
            intentosRealizados = new List<int>();
            lblResultado.Text = "Nuevo juego iniciado. ¡Adivina el número!";
        }
    }
}

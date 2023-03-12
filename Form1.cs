using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_4._8_REPASO___ALEATORIOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();

            //Generamos 20 números aleatorios y los almacenamos en un array
            for (int i = 0; i < listaAleatorios.Length; i++)
            {
                listaAleatorios[i] = aleatorio.Next(0, 100);
            }

            lblAleatorios.Text = string.Join(", ", listaAleatorios); //Mostramos los números aleatorios en el label
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numeroBuscado = Convert.ToInt32(txtBuscar.Text); //Obtenemos el número ingresado en el textbox

            int contador = 0;

            //Recorremos el array para contar cuántas veces aparece el número buscado
            foreach (int numero in listaAleatorios)
            {
                if (numero == numeroBuscado)
                {
                    contador++;
                }
            }

            //Mostramos los resultados en el label
            if (contador == 0)
            {
                lblResultado.Text = "El número no está en la lista";
            }
            else
            {
                lblResultado.Text = $"El número aparece {contador} veces en la lista";
            }
        }
    }
}

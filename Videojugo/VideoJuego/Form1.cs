using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoJuego
{
    public partial class Form1 : Form
    {
        string[] misdatos = new string[3];

        public struct Adquisicion
        {
            public string compra;
            public string disponibilidad;
            public int total;
        }
        public struct Tienda
        {
            public string servicio;
            public Juego juego;
            public Adquisicion adquisicion;
        }
        public struct Juego
        {
            public string plataforma;
            public byte numDiscos;
            public string titulo;
        }


        public Form1()
        {
            InitializeComponent();
            Tienda[] misTiendas = new Tienda[1];
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Tienda[] misTiendas = new Tienda[1];

            try
            {

                misdatos[0] = txtbNombre.Text;
                misdatos[1] = txtbPlat.Text;
                misdatos[2] = txtbPrecio.Text;
                for (int i = 0; i < misdatos.Length; i++)
                {
                    string aux = misdatos[i];
                    if (aux == "")
                    {
                        throw new ApplicationException();

                    }

                }

                MessageBox.Show("Se esta checando la venta presione para continuar\n");

            }
            catch (ApplicationException)
            {
                MessageBox.Show("revise bien qu elos campos esten completos porfavor");

            }

            misTiendas[0].servicio = "Servicio : Encontrado y empaquetado";
            misTiendas[0].juego.titulo = misdatos[0];
            misTiendas[0].juego.plataforma = misdatos[1];
            misTiendas[0].juego.numDiscos = byte.Parse(misdatos[2]);
            misTiendas[0].adquisicion.disponibilidad = "Si esta disponible";
            misTiendas[0].adquisicion.compra = "Su compra fue exitosa con pago en efectivo";
            misTiendas[0].adquisicion.total = byte.Parse(misdatos[2]) * 1099;


            label4.Text = misdatos[0];
            label5.Text = misdatos[1];
            label6.Text = misdatos[2];
            label7.Text = misTiendas[0].servicio;
            label8.Text = misTiendas[0].adquisicion.compra;
            label9.Text = misTiendas[0].adquisicion.disponibilidad;
            label10.Text = "A pagar:       pesitos" + misTiendas[0].adquisicion.total;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaUD10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click_1(object sender, EventArgs e)
        {
            string nombre, apellido, telefono;
            nombre = tNombre.Text;
            apellido = tApellidos.Text;
            telefono = tTelefono.Text;
            textBox3.Text = nombre + " " + apellido + " " + telefono;

        }

    }
}

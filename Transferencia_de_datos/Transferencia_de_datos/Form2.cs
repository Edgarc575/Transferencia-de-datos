using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transferencia_de_datos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Boton regresar al formulario 1
        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();//Instancia del formulario 1
            fr1.Show();//Abrir el formulario 1
            Hide();// Esconder el formulario 2
        }

        //Metodo para pasar los datos al textbox
        private void Datosobtenidos()
        {
            string dato = Transferir_datos.Obtenerdatos();// En la variable dato almacenamos la variable
            txtrespuesta.Text = dato; //Luego la info se muestra en el textbox
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Datosobtenidos();// Llamamos el metodo de los datos para mostrarse 
        }
    }
}

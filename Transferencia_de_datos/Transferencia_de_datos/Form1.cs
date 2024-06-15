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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        //Boton transferir en el cual, al darle clic, transferira los datos.
        private void btntransferrir_Click(object sender, EventArgs e)
        {

                //|-------Ingresar datos--------|
                //Declaracion de variables
                //Todas las variables seran de tipo cadena
                String nombre = "";
                nombre = txtnombre.Text;
                String apellido = "";
                apellido = txtapellido.Text;
                String fruta = "";
                fruta = txtfruta.Text;
                String color = "";
                color = cmbcolor.Text;
                String cbopcion = "";
                String rbopcion = "";
                String libro = "";
                libro = txtlibro.Text;
                String cumple = dtpcumple.Text;
                String conjunto = "";

                //Condicion de el campo "Mascotas" (Checkboxes)
                if (cbperro.Checked) // Si la opcion dormir es seleccionada
                {
                    cbopcion = "Perro ";//La opcion se agregara perro
                }
                if (cbgato.Checked)// Si la opcion leer es seleccionada
                {
                    cbopcion = cbopcion + " Gato ";//La opcion se agregara ato
                }
                if (cbotro.Checked)// Si la opcion rbtele es seleccionada
                {
                    cbopcion = cbopcion + "Otras mascotas"; // La opcion agregara otro tipo de mascota
                }

                //Condicion del campo de "Pasatiempos" (radio botones)
                if (rbdormir.Checked)// Si se selecciono la opcion entonces
                {
                    rbopcion = "Mi pasatiempo favorito es dormir";//Se almacena dormir
                }
                else if (rbleer.Checked)
                {//Sino, si se selecciona la segunda opcion
                    rbopcion = "Mi pasatiempo favorito es leer";//Se almacena leer
                }
                else if (rbtele.Checked)//Sino, si se selecciona la tercera opcion
                {
                    rbopcion = "Mi pasatiempo favorito es ver tele";//Se almacena ver tele
                }
                else//Si no se selecciono ninguna
                {
                    rbopcion = "No tengo pasatiempo favorito";//No hay pasatiempo favorito
                }

                //En la variable conjunto concatenamos el texto con su respectiva variable para
                //poder transferir la informacion en 1 sola variable hacia el otro formulario
                conjunto = "Nombre: " + nombre + "\n ,Apellido: " + apellido + "\n ,Fruta: " + fruta + "\n ,Color: " + color + "" +
                    "\n ,Mascotas: " + cbopcion + "\n ,Pasatiempo: " + rbopcion + "\n ,Libro: " + libro + "\n ,Cumpleaños: " + cumple;

                //|----Almacenar la informacion en el puente de datos------|
                Transferir_datos.Puentedatos(conjunto);
                //-------------------------------------------------------
                MessageBox.Show("Se han transferido los datos correctamente!", "Transferencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        //Boton ver datos, al darle clic, llevara al usuario al formulario 2
        private void btnverdatos_Click(object sender, EventArgs e)
        {
            //|-----Ir al otro formulario-------------|
            Form2 fr2 = new Form2(); //Creamos una instancia del formulario 2
            fr2.Show(); //Llamamos a la variable de la instancia para abrir el formulario 2
            Hide(); // Se escondera la interfaz actual 
        }
    }
}

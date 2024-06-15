using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transferencia_de_datos
{
    internal class Transferir_datos
    {

        //Se crea un campo de tipo privado para la variable conjunto dentro de la clase
        private static string td_conjunto;

        //Creamos un metodo publico llamado "Puentedatos" para que reciba la variable de tipo cadena
        public static void Puentedatos(string cargarconjunto)
        {
            //La variable del metodo se almacenaran en la variable de esta clase
            td_conjunto = cargarconjunto;
        }

        //Creamos un metodo de tipo publico que retornara la variable al otro formulario
        public static string Obtenerdatos()
        {
            return td_conjunto;//Retorna la variable conjunto

        }


    }
}

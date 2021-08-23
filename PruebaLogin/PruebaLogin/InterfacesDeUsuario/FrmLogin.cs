using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Declaración de variables
            string userPermitido; // Declaración de variable
            userPermitido = "admin"; // Asignación de variable
            string passPermitida = "admin"; // Declaración y asignación juntos

            // Obtener los valores de los textbox (string -> cadena de texto con "" / var -> toma el tipo del dato del primer valor que lo define)
            // .Trim() saca los espacios al principio y final del string para validar estos tipos de errores de los usuarios.
            var userIngresado = TxtLoginUser.Text.Trim();
            var passIngresado = TxtLoginPass.Text.Trim();

           //Estructura de control if para comparar el user ingresado con el definido como válido
           if(userIngresado == userPermitido && passIngresado == passPermitida)            
           {
                MessageBox.Show("Hola admin", "Bienvenido admin", MessageBoxButtons.OK );
           }
           else
           {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Bienvenido admin", MessageBoxButtons.OK);
           }

        }
    }
}

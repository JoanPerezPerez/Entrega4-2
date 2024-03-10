using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    internal class Program
    {
        [STAThread] // Este atributo es necesario para aplicaciones de Windows Forms
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); // Habilitar estilos visuales de Windows Forms
            Application.SetCompatibleTextRenderingDefault(false); // Establecer el renderizado de texto compatible

            // Crear una instancia del formulario Form1 y ejecutar la aplicación
            Application.Run(new Form1());
        }
    }
}

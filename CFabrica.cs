using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copia_practica_2
{
    class CFabrica
    {
        private static CCrearCamioneta camionetaInstance;

        public static IVehiculos GetVehiculos(int opciones)
        {
            if(opciones == 1)
            {
                camionetaInstance ??= new CCrearCamioneta();

                return (IVehiculos)camionetaInstance;
            }
            else
            {
                Console.WriteLine("La opción debe estar dentro del menú");
                return null;

            }
        }
    }
}

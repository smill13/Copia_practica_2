using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Copia_practica_2.CreaciónAutos;

namespace Copia_practica_2
{
    class CFabrica
    {
        private static CCrearCamioneta camionetaInstance;
        private static CCrearDeportivo deportivoIntace;
        private static CCrearSedan sedanIntance;
        private static CCrearMoto motoIntace;

        public static IVehiculos GetVehiculos(int opcion)
        {

            if (opcion == 1)
            {
                sedanIntance ??= new CCrearSedan();
                return (IVehiculos)sedanIntance;

            }
            else if (opcion == 2)
            {
                motoIntace ??= new CCrearMoto();
                return (IVehiculos)motoIntace;

            }
            else if (opcion == 3)
            {
                deportivoIntace ??= new CCrearDeportivo();
                return (IVehiculos)deportivoIntace;
            }
            else if (opcion == 4)
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

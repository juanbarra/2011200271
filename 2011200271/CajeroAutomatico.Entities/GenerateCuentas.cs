using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class GenerateCuentas
    {

        public List<Cuenta> getListaCuentas()
        {
            List <Cuenta> listaCuentas= new List<Cuenta>();

            Cuenta cuenta1 = new Cuenta ( 1015222601, 5215, 2000);
            Cuenta cuenta2 = new Cuenta ( 1012312222, 4977, 1800);
            Cuenta cuenta3 = new Cuenta ( 1002321366, 6782, 4444);
            Cuenta cuenta4 = new Cuenta ( 1020679291, 2312, 675);
            Cuenta cuenta5 = new Cuenta ( 1019967862, 8762, 231);
            Cuenta cuenta6 = new Cuenta ( 1296599812, 3453, 876);

            listaCuentas.Add(cuenta1);
            listaCuentas.Add(cuenta2);
            listaCuentas.Add(cuenta3);
            listaCuentas.Add(cuenta4);
            listaCuentas.Add(cuenta5);
            listaCuentas.Add(cuenta6);


            return listaCuentas;
        }


        public void ImprimirCuentas(List<Cuenta>listacuentas){
            Console.WriteLine("Numero Cuenta".PadRight(15)+"Pin".PadRight(10)+"Saldo".PadRight(10));
            for (int i = 0; i < listacuentas.Count; i++)
            {
                Console.WriteLine(listacuentas[i].getNroCuenta().ToString().PadRight(15)+listacuentas[i].getPin().ToString().PadRight(10)+listacuentas[i].getSaldo().ToString().PadRight(10));
            }
        }
    }
}

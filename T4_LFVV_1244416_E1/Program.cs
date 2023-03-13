using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_LFVV_1244416_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            string vf1 = "cero";
            string vo1 = "cero";
            string a1 = "cero";
            string t1 = "cero";
            string v = "";
            double vf = 0, vo = 0, a = 0, t = 0, aceleracion= 0, tiempo= 0;
            Console.WriteLine("Deje en blanco la variable que desea encontrar, ya sea la aceleración o el tiempo");
            Console.WriteLine("");
            Console.Write("Ingrese Valor de Vf: ");
            vf1= Console.ReadLine();
            Console.Write("Ingrese Valor de Vo: ");
            vo1 = Console.ReadLine();
            Console.Write("Ingrese Valor de a: ");
            a1 = Console.ReadLine();
            Console.Write("Ingrese Valor de t: ");
            t1 = Console.ReadLine();

            if (vf1 == v) { vf1 = "cero"; }
            if (vo1 ==v) { vo1 = "cero"; }
            if (a1 == v) { a1 = "cero"; }
            if (t1 == v) { t1 = "cero"; }

            if (vf1 != "cero") { x = x + 1; y = y + 1; z = z + 1; vf = Convert.ToDouble(vf1); }
            if (vo1 != "cero") { x = x + 1; y = y + 1; z = z + 1; vo = Convert.ToDouble(vo1); }
            if (a1 != "cero") { x = x + 1; y = y + 1; a = Convert.ToDouble(a1); }
            if (t1 != "cero") { x = x + 1; z = z + 1; t = Convert.ToDouble(t1); }

            Console.WriteLine("");
            if (x==4) { 
                Console.WriteLine("Error Usted Ha Ingresado Un Valor A Las Cuatro Variables"); 
             }

            if (z==3 && x<4) {
                aceleracion = (vf - vo) / t;
                Console.WriteLine("La aceleración es igual a: " +aceleracion); 
            }
            if (y == 3 && x<4)
            {
                tiempo = (vf - vo) / a;
                Console.WriteLine("El tiempo es igual a: " + tiempo);
            }

            Console.ReadKey();
        }
    }
}

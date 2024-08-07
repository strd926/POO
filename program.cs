using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculos Automovil = new Auto("Mazda", "Atenza", 2024, 4);
            Vehiculos MotoC = new Motocicleta("Honda", "Shadow", 2019, "Cruiser");
            Vehiculos Trailer = new Camion("Peterbuilt","579", 2015, 17);

            Automovil.Encender();
            Automovil.Apagar();
            Automovil.Conducir(200);

            Console.WriteLine();

            MotoC.Encender();
            MotoC.Apagar();
            MotoC.Conducir(250);

            Console.WriteLine();

            Trailer.Encender();
            Trailer.Apagar();
            Trailer.Conducir(3000);

            Console.WriteLine();

        }
    }
}

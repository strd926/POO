using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Auto : Vehiculos
    {
        public int NumeroDePuertas {  get; set; }

        public Auto(string marca, string modelo, int anio, int numeroDePuertas)
            : base(marca, modelo, anio)
        {
            NumeroDePuertas = numeroDePuertas;
        }

        public override void Encender ()
        {
            Console.WriteLine($"{Marca} {Modelo} con {NumeroDePuertas} puertas, esta encendido");
        }
        public override void Apagar ()
        {
            Console.WriteLine($"{Marca} {Modelo} con {NumeroDePuertas} puertas, esta apagado");
        }
        public override void Conducir (int km)
        {
            Kilometraje += km;
            Console.WriteLine($"{Marca} {Modelo} con {NumeroDePuertas} puertas, ha recorrido {km} km. Kilometraje total {Kilometraje} km");
        }
    }
}

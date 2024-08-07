using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Motocicleta :Vehiculos
    {
        public string TipoDeMoto { get; set; }

        public Motocicleta(string marca, string modelo, int anio, string tipoDeMoto)
            : base(marca, modelo, anio)
        {
            TipoDeMoto = tipoDeMoto;
        }

        public override void Encender()
        {
            Console.WriteLine($"{Marca} {Modelo} {TipoDeMoto} esta encendido");
        } 
        public override void Apagar()
        {
            Console.WriteLine($"{Marca} {Modelo} {TipoDeMoto} esta apagado");
        }
        public override void Conducir(int km)
        {
            Kilometraje += km;
            Console.WriteLine($"{Marca} {Modelo} {TipoDeMoto} ha recorrido {km} su nuevo kilometraje es {Kilometraje} km");
        }
    }
}

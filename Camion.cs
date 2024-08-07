using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Camion : Vehiculos
    {
        public int CapacidadDeCarga { get; set; }

        public Camion(string marca, string modelo, int anio, int capacidadDeCarga)
            : base(marca, modelo, anio)
        {
            CapacidadDeCarga = capacidadDeCarga;
        }
        public override void Encender()
        {
            Console.WriteLine($"{Marca} {Modelo} con capacidad de carga de {CapacidadDeCarga} toneladas esta encendido");
        }
        public override void Apagar()
        {
            Console.WriteLine($"{Marca} {Modelo} con capacidad de carga de {CapacidadDeCarga} toneladas esta apagado");
        }
        public override void Conducir(int km)
        {
            Kilometraje += km;
            Console.WriteLine($"{Marca} {Modelo} con capacidad de carga de {CapacidadDeCarga} ha recorrido {km} su nuevo kilometraje es {Kilometraje} km");
        }
    }
}

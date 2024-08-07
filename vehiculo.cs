using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Vehiculos
    {
        private string marca;
        private string modelo;
        private int anio;
        private int kilometraje;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public int Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }

        protected Vehiculos(string marca, string modelo, int anio)
        {
            this.marca = marca;
            this.anio = anio;
            this.modelo = modelo;
            this.kilometraje = 0;
        }
        public abstract void Encender();
        public abstract void Apagar();
        public abstract void Conducir(int km);
    }
    
}

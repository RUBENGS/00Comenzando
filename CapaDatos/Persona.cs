using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    
    public class Persona : IEquatable<Persona>
    {
        public Persona()
        {
        }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(string nombre, int distancia) : this(nombre)
        {
            Distancia = distancia;
        }

        public Persona(string nombre, int distancia, Transporte movilidad) : this(nombre, distancia)
        {
            Movilidad = movilidad;
        }

        public enum Transporte
        {
            Autobus,
            Coche,
            Moto,
            Piernas,
            SillaRuedas,
            PatinElectrico,
            Bicicleta
        }
        public String Nombre { get; set; }
        public int Distancia { get; set; }
        public Transporte Movilidad { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Persona);
        }

        public bool Equals(Persona other)
        {
            return other != null &&
                   Nombre.ToLower() == other.Nombre.ToLower();
        }

        public override int GetHashCode()
        {
            return 289764928 + EqualityComparer<string>.Default.GetHashCode(Nombre);
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Distancia (en KM):  {Distancia}, Transporte: {Movilidad}";
        }


    }
}

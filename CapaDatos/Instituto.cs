using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Instituto
    {
        public ReadOnlyCollection<Persona> Personas = new ReadOnlyCollection<Persona>(new List<Persona>() {
            new Persona("Juan", 1, Persona.Transporte.Bicicleta), new Persona("Pepe", 4, Persona.Transporte.Autobus)
        });

        public string AddPersona(Persona persona)
        {
            List<string> errores = new List<string>();
            if (persona == null)
            {
                return "La persona no puede ser nula";
            } else if (!LeerPersonasDeFichero(out errores).Contains(persona))
            {
                List<Persona> pers = LeerPersonasDeFichero(out errores);
                pers.Add(persona);
                CrearFichero(pers);
                return "Persona añadida con éxito.";
            }
            else
            {
                return "Esta persona ya existía.";
            }
        }

        public void AddPersona(string nombre)
        {
            AddPersona(new Persona(nombre));
        }

        public void AddPersona(string nombre, int distancia)
        {
            AddPersona(new Persona(nombre, distancia));
        }

        public void AddPersona(string nombre, int distancia, Persona.Transporte transporte)
        {
            AddPersona(new Persona(nombre, distancia, transporte));
        }

        public string AddPersonaBtn(string nombre, string dist, string transp)
        {
            int distancia;
            Persona.Transporte transporte;
            if (Int32.TryParse(dist, out distancia))
            {
                if (Enum.TryParse(transp, out transporte))
                {
                    Persona persona = new Persona(nombre, distancia, transporte);
                    string s = AddPersona(persona);
                    return s;

                }
                else
                {
                    return "Error al elegir transporte";
                }
            }
            else
            {
                return "Error en la distancia";
            }
        }

        public string Quitar(string text)
        {
            List<string> errores = new List<string>();
            if (LeerPersonasDeFichero(out errores).Contains(new Persona(text)))
            {
                List<Persona> pers = LeerPersonasDeFichero(out errores);
                pers.Remove(new Persona(text));
                CrearFichero(pers);
                return "Persona borrada";
            }
            else
            {
                return "No se ha encontrado la persona";
            }
        }

        private static readonly String path = @".\Datos.txt";

        public void CrearFichero(List<Persona> personas)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Persona p in personas)
                {
                    sw.WriteLine(p.Nombre + ";" + p.Distancia + ";" + p.Movilidad);
                }

            }
        }

        public void CrearFichero(ReadOnlyCollection<Persona> personas)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Persona p in personas)
                {
                    sw.WriteLine(p.Nombre + ";" + p.Distancia + ";" + p.Movilidad);
                }
            }
        }

        public void CrearFichero()
        {
            CrearFichero(Personas);
        }

        public List<Persona> LeerPersonasDeFichero(out List<String> errores)
        {
            List<Persona> personas = new List<Persona>();
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                errores = new List<string>();
                int contador = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    String[] info = s.Split(';');
                    if (info.Length == 3)
                    {
                        Persona.Transporte transporte;
                        int distancia;
                        if (Int32.TryParse(info[1], out distancia) && Enum.TryParse(info[2], out transporte))
                        {
                            Persona persona = new Persona(info[0], distancia, transporte);
                            personas.Add(persona);
                            Console.WriteLine(persona);
                        } else errores.Add("Error en la línea " + contador);
                    } else errores.Add("Error en la línea " + contador);
                    contador++;
                }
            }
            return personas;
        }

        public List<Persona> LeerPersonasDeFichero()
        {
            List<Persona> personas = new List<Persona>();
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                int contador = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    String[] info = s.Split(';');
                    if (info.Length == 3)
                    {
                        Persona.Transporte transporte;
                        int distancia;
                        if (Int32.TryParse(info[1], out distancia) && Enum.TryParse(info[2], out transporte))
                        {
                            Persona persona = new Persona(info[0], distancia, transporte);
                            personas.Add(persona);
                            Console.WriteLine(persona);
                        }
                        else Console.WriteLine("Error en la línea " + contador);
                    }
                    else Console.WriteLine("Error en la línea " + contador);
                    contador++;
                }
            }
            return personas;
        }

        public void IniciarInstituto()
        {
            if (ExisteFichero())
            {
                Console.WriteLine("Existe el fichero");
            }
            else
            {
                CrearFichero(Personas);
            }
        }

        public bool ExisteFichero()
        {
            return File.Exists(path);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Propietario:IComparable
    {

        public int Dni
        {
            get
            {
                return Dni;
            }
            set
            {
                Dni = value;
            }
        }

        public string ApellidosNombres
        {
            get
            {
                return ApellidosNombres;
            }
            set
            {
                ApellidosNombres = value;
            }

        } 

        public string Email 
        { 
            get { return Email; }
            set { Email = value; }
        }

        public Propietario(int dni, string nombre, string email) 
        {

            Dni = dni;
            ApellidosNombres = nombre;
            Email = email;
        
        }

        public override string ToString() 
        {
            return $"DNI: {Dni} - Apellido y Nombre: {ApellidosNombres} - Email: {Email}";

        }

        public int CompareTo(object obj)
        {
            Propietario p = obj as Propietario;
            if (p != null) return Dni.CompareTo(p.Dni);
            return -1;
        }

    }
}

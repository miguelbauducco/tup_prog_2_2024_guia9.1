using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Vtv 
    {
        public string Patente { get; private set; }
        public DateTime Fecha
        {
            get { return Fecha; }
           
        }

        public DateTime FechaRevalidacion
        {
            get 
            {
                return Fecha.AddDays(20);
            }
        
        }
        public int CantidadVerificaciones { get { return verificaciones.Count; } }
        public TipoAprobacion Aprobacion { get; private set; }
        public Propietario propietario { get; private set; }

        List<Evaluacion> verificaciones;

        public Evaluacion this[int idx] 
        {
            get {  return verificaciones[idx];}
        }

        public Vtv(string patente, Propietario propietario) 
        {
            verificaciones = new List<Evaluacion>();
            Patente = patente;
            this.propietario = propietario;
        
        }

        public string[] EmitirComprobante()
        {
            string[] c = new string[CantidadVerificaciones + 1];
            c[0] = propietario.ToString();
            for (int i = 0; i<CantidadVerificaciones; i++) 
            {
                c[i] = verificaciones[i-1].ToString();
            }
            return c;
        }

        public override string ToString()
        {
            return $"{Patente} - {Aprobacion} - {Fecha} - {FechaRevalidacion} ";
        }


        
    }
}

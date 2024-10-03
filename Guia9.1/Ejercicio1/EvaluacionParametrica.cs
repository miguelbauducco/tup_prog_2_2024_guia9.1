using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class EvaluacionParametrica:Evaluacion
    {

        public double ValorMinimo { get; private set; }
        public double ValorMaximo { get;private set; }
        public string Unidad {  get; private set; }
        public double ValorTolerado {  get; private set; }

        public double ValorMedido
        {
            get { return ValorMedido; }
            set { ValorMedido = value; }
        }

        public EvaluacionParametrica(string nombre, string descripcion, double minimo, double maximo, string unidad, double tolerado) :base (nombre, descripcion) 
        {
            ValorMinimo = minimo;
            ValorMaximo = maximo;
            Unidad = unidad;
            ValorTolerado = tolerado;   
        }

        public override TipoAprobacion Evaluar()
        {

            double porcentaje = ValorMinimo * 0.7;

            if (porcentaje < ValorMedido)
                return TipoAprobacion.NoAprobado;
            else if (ValorMedido < ValorMinimo)
                return TipoAprobacion.Parcial;

            return TipoAprobacion.Aprobado ;

        }

        public override string ToString()
        {
            if (Evaluar() == TipoAprobacion.Aprobado) return $"Aprobado";
            else if (Evaluar() == TipoAprobacion.Parcial) return $"Parcial";
            return $"No Aprobado";
        }

    }
}

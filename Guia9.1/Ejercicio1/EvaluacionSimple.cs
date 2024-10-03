﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class EvaluacionSimple:Evaluacion
    {
        public bool HaVerificado 
        {
            get { return HaVerificado; }
            set { HaVerificado = value; }
        }

        public EvaluacionSimple(string nombre, string descripcion) :base(nombre, descripcion) 
        { }

        public override TipoAprobacion Evaluar()
        {
            if (HaVerificado) 
            {
                return TipoAprobacion.Aprobado;
            }
            return TipoAprobacion.NoAprobado;
        }

        public override string ToString() 
        {
            if(Evaluar() == TipoAprobacion.Aprobado)return $"Aprobado.";
            return $"NoAprobado";        
        }

    }
}

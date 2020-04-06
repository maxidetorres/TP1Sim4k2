using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSIM
{
    class Intervalo
    {
        float limiteInferior;
        float limiteSuperior;
        int cantidadObservaciones;

        public Intervalo(float limiteInferior, float limiteSuperior)
        {
            this.limiteInferior = limiteInferior;
            this.limiteSuperior = limiteSuperior;
        }

        public int CantidadObservaciones
        {
            get { return cantidadObservaciones; }
            set { cantidadObservaciones = value; }
        }

        public float LimiteSuperior
        {
            get { return limiteSuperior; }
            set { limiteSuperior = value; }
        }

        public float LimiteInferior
        {
            get { return limiteInferior; }
            set { limiteInferior = value; }
        }
    }
}

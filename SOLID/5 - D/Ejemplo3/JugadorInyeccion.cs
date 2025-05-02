using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___D.Ejemplo3
{
    public class JugadorInyeccion
    {
        private readonly IArma _arma;

        public JugadorInyeccion(IArma arma)
        {
            _arma = arma;
        }

        public void Pelear()
        {
            _arma.Atacar();
        }
    }
}

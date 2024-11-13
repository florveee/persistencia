using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinanza.Back
{
    public class Resultado
    {
        public string nombre { get; set; }
        public string numadiv { get; set; }
        public string intentos { get; set; }

        public void AgregarResult (string rnombre, string rnumadiv, string rintentos) 
        {
            nombre = rnombre;
            numadiv = rnumadiv;
            intentos = rintentos;
        }
    }
}

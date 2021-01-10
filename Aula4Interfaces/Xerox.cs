using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4Interfaces
{
    public class Xerox : iCopiadora
    {
        public string Copiar(string texto)
        {
            return $"Texto copiado {texto}";
        }
    }
}

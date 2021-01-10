using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4Interfaces
{
    class ImpressoraCopiadora : iImpressora, iCopiadora
    {
        public string Copiar(string texto)
        {
            return $"Texto copiado: {texto}";
        }

        public string Imprimir(string texto)
        {
            return $"Texto Impresso: {texto}";
        }
    }
}

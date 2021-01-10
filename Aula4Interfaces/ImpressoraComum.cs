using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4Interfaces
{
    class ImpressoraComum : iImpressora
    {
        public string Imprimir(string texto)
        {
            return $"Texto a imprimir {texto}";
        }

        // Não alterar uma classe já pronta, para adicionar. Usar interface
        // para resolver 


    }
}

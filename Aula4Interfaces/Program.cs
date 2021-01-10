using System;

namespace Aula4Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var c = new ImpressoraCopiadora();

            Console.WriteLine(i.Imprimir("Estou estudando C#"));
            Console.WriteLine(c.Copiar("Estou Copiando"));

            CopiarDocumento(new Xerox(), "Hello World");


        }

        // Sempre deixar cada interface fazendo o menos possível

        // o método/função pode chamar uma interface como tipo, 
        // e qualquer objeto
        // derivado dela pode ser usado como argumento
        public static void CopiarDocumento(iCopiadora c, string texto)
        {
            Console.WriteLine($"Estou copiando: {c.Copiar(texto)}");
        }
    }
}

// Using:

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

//NameSpace:

namespace MeuApp
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Variável:
            var texto = "Meu aprendizado";
            Console.WriteLine(texto);
            int idade = 25;
            Console.WriteLine(idade);

            //Constante:
            const string NOME = "Alan";
            Console.WriteLine(NOME);

            //Byte:
            byte meuByte = 127;
            Console.WriteLine(meuByte);

            //Sbyte
            sbyte meuSbyte = -127;
            Console.WriteLine(meuSbyte);

            //Número Int
            int meuInt = 12127;
            Console.WriteLine(meuInt);
        }
             
    }
}







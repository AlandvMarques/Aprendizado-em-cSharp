using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

// namespace MeuApp
//{ 
//    class Program
//    {
//        static void Main(string[] agrs)
//        {
//            MeuMetodo();
//            EscreverNome();
//            string teste = RetornarNome("Kevin", "Oliveira");
//            Console.WriteLine(teste);
//        }
//        static void MeuMetodo()
//        {
//            Console.WriteLine("C# é legal");

//        }

//        static string RetornarNome(string name, string sobrenome, int idade= 21)
//        {
//            return name + " " + sobrenome + " tem " + idade.ToString();
//        }

//        static void EscreverNome()
//        {
//            var nome = NomeCompleto();
//            var soma = somaValores();

//            Console.WriteLine(nome);
//            Console.WriteLine(soma);
//        }

//        static string NomeCompleto()
//        {
//            return "Alan Marques";
//        }

//        static int somaValores()
//        {
//            return 8 + 2;
//        }
//    }
//}

var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Alan", 21);
Console.WriteLine(nome);

int SomaValores(int i, int j)
{
    return i + j;
}

string NomeEIdade( string nome , int idade )
{ 
    return "Meu nome é " + nome + " e tenho " + idade + " anos ";
}
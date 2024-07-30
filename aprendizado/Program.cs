// Using: / System:

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

            //Número Short / Int / Long:
            short meuShort = 34;
            Console.WriteLine(meuShort);

            int meuInt = 12127;
            Console.WriteLine(meuInt);

            long MeuLong = 64573;
            Console.WriteLine(MeuLong);

            //Número Float / Double / Decimal:
            float meuFloat = 2.300f;
            Console.WriteLine(meuFloat);

            double meuDouble = 4.690;
            Console.WriteLine(meuDouble);

            decimal meuDecimal = 34.980m;
            Console.WriteLine(meuDecimal);

            //Número Boolean:
            bool meuBoolTrue = true;
            Console.WriteLine(meuBoolTrue);

            bool meuBoolFalse = false;
            Console.WriteLine(meuBoolFalse);

            var meuBoolVar = true;
            Console.WriteLine(meuBoolVar);

            //Char:
            char meuCharPrimeiro = 'a';
            Console.WriteLine(meuCharPrimeiro);

            char meuCharSecundario = 'b';
            Console.WriteLine(meuCharSecundario);

            var meuCharVar = 'c';
            Console.WriteLine(meuCharVar);

            //String:
            string meuStringPrimario = "minha";
            Console.WriteLine(meuStringPrimario);

            string meuStringSecundaria = "string";
            Console.WriteLine(meuStringSecundaria);

            var meuStringVar = "23.4658";
            Console.WriteLine(meuStringVar);

            //Var: 

            var meuVarPrimario = 25;
            Console.WriteLine(meuVarPrimario);

            var meuVarSecundario = true;
            Console.WriteLine(meuVarSecundario);

            var meuVarTernario = 'd';
            Console.WriteLine(meuVarTernario);

            var meuVarQuartenario = "name";
            Console.WriteLine(meuVarQuartenario);

            //Object:
            object semValor;

            object meuObjectPrimario = 25;
            Console.WriteLine(meuObjectPrimario);

            object meuObjectSecundario = true;
            Console.WriteLine(meuObjectSecundario);

            object meuObjectTernario = 'e';
            Console.WriteLine(meuObjectTernario);

            semValor = "atribuindo";
            semValor = true;
            semValor = false;
            Console.WriteLine(semValor);

            //Null:
            int? meuNullPrimario = null;
            Console.WriteLine(meuNullPrimario);

            string? meuNullSecundario = null;
            Console.WriteLine(meuNullSecundario);

            bool? meuNullTernario = null;
            Console.WriteLine(meuNullTernario);

            //Alias:
            int meuAlias = 25; //Alias
            Console.WriteLine(meuAlias);

            Int32 meuTipo = 25; //Tipo
            Console.WriteLine(meuTipo);

            //Valores Padrões:
            string meuValorPadraostring = "";
            Console.WriteLine(meuValorPadraostring);

            int meuValorPadraoint = 0;
            Console.WriteLine(meuValorPadraoint);

            float meuValorPadraoFloat = 0;
            Console.WriteLine(meuValorPadraoFloat);

            decimal meuValorPadraoDecimal = 0;
            Console.WriteLine(meuValorPadraoDecimal);

            bool meuValorPadraoBool = false;
            Console.WriteLine(meuValorPadraoBool);

            char meuValorPadraoChar = '\0';
            Console.WriteLine(meuValorPadraoChar);
        }  
    }
}







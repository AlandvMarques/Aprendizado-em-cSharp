// Using: / System:

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

            //Conversão Implícita:
            float meuConversaoImplicitaPrimaria = 25.8f;
            int meuConversaoImplicitaSecundaria = 25;
            meuConversaoImplicitaPrimaria = meuConversaoImplicitaSecundaria;
            Console.WriteLine(meuConversaoImplicitaPrimaria);

            //Conversão Explícita: 
            int meuConversaoExplicita = 100;
            uint meuConversaoExplicitaSemSinal = (uint)meuConversaoExplicita;

            //Parse:
            int meuParse = int.Parse("10");
            Console.WriteLine(meuParse);

            //Convert:
            int meuConvertPrimario = 100;
            float meuConvertSecundario = 25.8f;
            meuConvertPrimario = Convert.ToInt32(meuConvertSecundario);
            Console.WriteLine(meuConvertPrimario);

            //Operadores Aritiméticas:
            int meuSoma = 25 + 22;
            Console.WriteLine(meuSoma);

            int meuSubtacao = 22 - 4;
            Console.WriteLine(meuSubtacao);

            int meuMultiplicacao = 25 * 2;
            Console.WriteLine(meuMultiplicacao);

            int meuDivisao = 25 * 3;
            Console.WriteLine(meuDivisao);

            int x = 2 + 2 * 2;
            Console.WriteLine(x);

            int y = 2 + (2 * 2);
            Console.WriteLine(x);

            int z = (2 + 2) * 2;
            Console.WriteLine(x);

            //Operadores de Atribuição:
            int num = 0; //Atribuição
            num += 5; // num = num + 5;
            num -= 1; // num = num - 1;
            num *= 10; //num = num * 10;
            num /= 2; // num = num / 2;
            num++;
            num--;
            Console.WriteLine(num);

            /* Operadores de Comparação:

             Igual ==
             Diferente !=
             Maior que >
             Menor que <
             Maior ou igual a >=
             Menor ou igual que <=

             int meuComparacao = 25;
             meuComparacao == 0;
             meuComparacao != 0;
             meuComparacao > 0;
             meuComparacao < 0;
             meuComparacao <= 0;
             meuComparacao >= 0
            */

            //Operadores Lógicos:
            // and == &&
            // ou == ||
            // não == !
            int meuOperadorLogico = 10;
            bool entre = (meuOperadorLogico > 25) && (meuOperadorLogico < 40);
            Console.WriteLine(entre);

            bool ou = (x > 25) || (x < 40);
            Console.WriteLine(ou);

            bool negacao = !(x < 25);
            Console.WriteLine(negacao);

            //Operações Lógicos:
            int meuIdade = 18;
            int meuMaiorIdadde = 21;
            int meuIdadeMaxima = 65;

            if (!(meuIdade >= meuMaiorIdadde || meuIdade < meuIdadeMaxima))
            {
                Console.WriteLine("É igual");
            }
            else
            {
                Console.WriteLine("É Diferente");
            }

            Console.WriteLine("Finalizou o pragrama");

            //Estrutura Condicional: Switch
            int meuValorSwitch = 1;
            switch (meuValorSwitch)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                case 4: Console.WriteLine("4"); break;
                default: Console.WriteLine("5"); break;
            }

            //Laços de Repetição: For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Laços de Repetição: While
            int meuWhilePrimario = 0;
            while (meuWhilePrimario <= 10)
            {
                Console.WriteLine(meuWhilePrimario);
                meuWhilePrimario++;
            }

            //Laços de Repetição: Do
            int meuDoWhilePrimario = 0;
            do
            {
                Console.WriteLine(meuDoWhilePrimario);
                meuDoWhilePrimario++;
            } while (meuDoWhilePrimario <= 10);

            //Função ou Métodos:
            MeuMetodo();

            string MeuNomeFuncao = RetornaNome("Alan", "Marques");
            Console.WriteLine(MeuNomeFuncao);

            //Value Type Reference Type:
            int meuX = 25;
            int meuY = meuX;
            Console.WriteLine(meuX);
            Console.WriteLine(meuY);

            meuX = 32;
            Console.WriteLine(meuX);
            Console.WriteLine(meuY);

            var meuArr = new string[2];
            meuArr[0] = "primeiro item";

            var meuArr2 = meuArr;

            Console.WriteLine(meuArr[0]);
            Console.WriteLine(meuArr2[0]);

            meuArr[0] = "sengundo item";
            Console.WriteLine(meuArr[0]);
            Console.WriteLine(meuArr2[0]);

            //Struts:
            //    struct Product
            //{
            //    //propriedade 
            //    public int Id;
            //    public float Preco;

            //    //Método
            //    public float PrecEnDolar(float dolar)
            //    {
            //        return Preco * dolar;
            //    }
            //}

            //Construtor:
            //struct Product
            //{
            //    public Product(int id, string title, float price)
            //    {
            //        Id = id;
            //        Title = title;
            //        Price = price;
            //    }


            Product mouse = new Product(1, "Mouse gamer", 287.89);

                Console.WriteLine(mouse.Id);
                Console.WriteLine(mouse.Name);
                Console.WriteLine(mouse.Price);

            // Enumerador:
            //enum EEstadoCivil 
            //{
            //    Solteiro = 1,
            //    Casado = 2,
            //    Divorciadoo = 3
            //}
            // var cliente = new Cliente("João ", EEstadoCivil.Casado)

        }

        //Função ou Métodos:
        static void MeuMetodo()
            {
                Console.WriteLine("C# é legal");
            }

            static string RetornaNome(
                string meuNome,
                string meuSobrenome,
                int minhaIdade = 21
                )
            {
                return meuNome + " " + meuSobrenome;
            }

            //Struts:
            struct Product  
            { 
                //construtor
                public Product(int id, string meuNomeStruts, double price)
                {
                    Id = id;
                    Name = meuNomeStruts;
                    Price = price;
                }

                public int Id;
                public string Name;
                public double Price;

                public double PriceInDolar(double dolar)
                {
                    return Price * dolar;
                }
            }
    }
 }








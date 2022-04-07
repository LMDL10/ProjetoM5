using System;

namespace Projeto_M5
{
    class Program
    {
        public struct cienciasexatas
        {
            public int Codigo;
            public string Nome;
            public string Nomeautor;
            public string Editora;
            public int Npáginas;
        }

        public struct cienciashumanas
        {
            public int Codigo;
            public string Nome;
            public string Nomeautor;
            public string Editora;
            public int Npáginas;
        }
        public struct cienciasbiomedicas
        {
            public int Codigo;
            public string Nome;
            public string Nomeautor;
            public string Editora;
            public int Npáginas;
        }
        //Declaração dos vetores
        public static cienciasexatas[] livrocienexata = new cienciasexatas[50];
        public static cienciashumanas[] livrocienhumanas = new cienciashumanas[50];
        public static cienciasbiomedicas[] livrocienbiomedicas = new cienciasbiomedicas[50];

        public static int addobra
        {


        }

        public static void  inserir0()
        {
            int num 1;
            dados[] novo = new dados[]
            Console.WriteLine("Quantos livros quer introduzir?");
            num = Int.Parse(Console.ReadLine());
            //Ler valores para o Vetor
            For(i = tam;i < (tam + num );i++)
            {
               8 

            
        }
        
        static dados [] dados 1 = new dados[100];  
        static tam = 0;

        static void Main(string[] args)
        {
            //Declaração das variaveis 
            int num = 0, num1 = 1, num2 = 0;
            
            //Introdução do primeiro valor
            Console.WriteLine("Bem vindo a biblioteca");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("****Menu****\n1 para adicionar uma obra\n2 para ver as informaçoes das obras\n3 Sair\n--------------------------------------");
            num = Convert.ToInt32(Console.ReadLine());


            
            
            
            
            
            
            Console.WriteLine("De que tipo quer introduzir: \n1 para ciências exatas\n2 para ciências humanas\n3 para ciências biomédicas");
            num2 = Convert.ToInt32(Console.ReadLine());

            case 1;
            Console.Clear();
            addobra(); // dps criar uma funçao com este nome
            Console.WriteLine("Qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;
            
            case 2;
            Console.Clear();
            Consultaobras(); // dps criar uma funçao com este nome
            Console.WriteLine("Qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;

            case 3;
            Console.Clear();
            Console.WriteLine("Qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;




            //Introducão dos valores 2
            if (num == 1)
            {
                for (int i = 0; i < num1; i++)
                {

                    //Introdução dos valores
                   
                    if (num2 == 1)
                    {
                        Console.WriteLine("Você escolheu Ciências exatas\nAgora Introduza as Informação");
                        Console.WriteLine("Nome do Livro:");
                        livrocienexata[i].Nome = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("\nNome do Autor:");
                        livrocienexata[i].Nomeautor = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("\nEditora:");
                        livrocienexata[i].Editora = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("\nCodigo do Livro");
                        livrocienexata[i].Codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduza o Numero de Paginas");
                        livrocienexata[i].Npáginas = int.Parse(Console.ReadLine());


                    }
                    if (num2 == 2)
                    {
                        //para ciências humanas
                    }
                    if (num2 == 3)
                    {
                        //ciências biomédicas
                    }

                }
            }

            if (num == 2)
            {
                //Consulta às informações de uma obra.
            }

            if (num == 3)
            {
                Console.WriteLine("Clique em qualquer tecla para sair");
                Console.ReadLine();
            }

        }
    }
}

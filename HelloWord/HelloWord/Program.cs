using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HelloWord
{
    internal class Program
    {

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args)
        {
            //tipo int - 156 como 1212
            //float - casas  decimais 12,5; => double e decimal
            //Bool - true ou false
            //String - "" ->sempre aspas duplas
            //char - '' ->aspas simples - caracters

            /*
            int segundaGuerraMundial = 1942;
            string corFavorita = "Azul";
            float velocidadeF1 = 294.48f;
            bool segundaGerraMundial = true;

            Console.WriteLine("A segunda guerra mundial aconteceu em: " + segundaGuerraMundial);
            Console.WriteLine("Minha cor favorita é " +  corFavorita);

            velocidadeF1 = 322.291f;
            
            */
            //const float PI = 3.14f; // nunca mais poderá ser mudado pois é uma constante
            //capturando dados do usuário 
            /*
            Console.WriteLine("Escrevaa seu nonme: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é " + nome);
            */
            /*
            float altura = 1.77f;
            float peso = 58.5f;

            float soma = altura * peso;
            Console.WriteLine("Seu imc é " + soma);

            float numeroDiv = 5.0f / 2;
            Console.WriteLine(numeroDiv);

            Console.ReadLine();
            */
            /*
            int a = 10;
            int b = 11;
            int c = 22;


            if(c > a && c > b)
            {

                Console.WriteLine("Deu bom!.");
            }else if (b > a && c > a) {

                Console.WriteLine("Deu ruim viu ");
            }
            
            else{
                Console.WriteLine("Buguei!.");
            }
            Console.ReadLine();
            */

            // programinha para praticar condicionais e operadores logicos
            /*
            Console.WriteLine("Digite sua idade : ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11 )
            {
                Console.WriteLine("Você é uma criança!.");
            }else if (idade >= 12 && idade <=18)
            {
                Console.WriteLine("Você é um adolescente!!.");
            }else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto!!.");
            }else
            {
                Console.WriteLine("Você é um idoso!..");
            }

            */


            //FUNÇÕES
            /*
            ExibitMsg();
            GerarPreco(-50);

              static void  ExibitMsg()
            {
                Console.WriteLine("Esse é show de bola!.");
                Console.WriteLine("Topzera");
                Console.WriteLine("Eu estou usando funções!!");
            }



            Console.ReadLine();
        }

        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
            */

            /*
            int soma1 = Somar(5, 5, 5);

            Console.WriteLine(soma1);

            Console.ReadLine();

            static int Somar(int a, int b, int c)
            {
                int resultadoFinal = a + b + c;
                return resultadoFinal;

              */

            //arrays
            /*
            string[] produtos = new string[5] {
                "Carro de Passeio", //indice 0 
                "Carro de corrida", //1 
                "Motocicletas",//2 
                "Bicicletas", //3
                "Patins"}; ;//4

            int[] numeros =
            {
                51,
                57,
                56,
                10,
                22
            };

            Console.WriteLine(produtos[1] + " " + numeros[1]);
            Console.WriteLine(produtos[2] + " " + numeros[2]);
            Console.WriteLine(produtos[3] + " " + numeros[3]);
            Console.WriteLine(produtos[4] + " " + numeros[4]);

            Console.WriteLine("Escolha seu produto atráves de numeros");
            int escolher = int.Parse(Console.ReadLine());

            if (escolher == 51)
            {
                Console.WriteLine("Você escolheu " + "" + produtos[0]);
            }
            else if (escolher == 57)
            {
                Console.WriteLine("Você escolheu" + " " + produtos[1]);
            }
            else if (escolher == 56)
            {
                Console.WriteLine("Você escolheu" + " " + produtos[2]);
            }
            else if (escolher == 10)
            {
                Console.WriteLine("Você escolheu" + " " + produtos[3]);
            }
            else if (escolher == 22)
            {
                Console.WriteLine("Você escolheu" + " " + produtos[4]);
            }else
            {
                Console.WriteLine("Numero Inválido");
            }

            Console.WriteLine("Fim do programa");
            */

            //switch

            /*
            string cor = "Azul";

            switch(cor)
            {
                case "Vermelho":
                    Console.WriteLine("A sua cor é vermelho");
                    break;

                case "Amarelo":
                    Console.WriteLine("A sua cor é Amarelo");
                    break;

                case "Azul":
                    Console.WriteLine("A sua cor é Azul");
                    break;

                default:
                    Console.WriteLine("Cor não encontrada");
                    break;
            }

            */

            //ENUM
            /*
            enum Cor { Azul  , Verde, Amarelo, Vermelho }
            Cor corFfavorita = Cor.Amarelo;
            */
            /**
            Console.WriteLine("Seleciona uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());

            Opcao opcaoSelecionadaa = (Opcao)index;
            Console.WriteLine(opcaoSelecionadaa);
            */

            //while // enquanto for verdade faça ->

            /*

             int pesoThaliza = 95;

             while(pesoThaliza > 79)
             {
                 Console.WriteLine("Godinha do bora" + " " + "seu peso é : " + " " + pesoThaliza -- );
             }
             Console.WriteLine("Agora virou magrinha do bora TE AMO MOMO KK");
            */

            // do while por mais que seja falso, vai rodar pelo menos uma vez
            // funciona como o while
            /*
            int contador2 = 0;

            do
            {
                Console.Write("É verdade");
                contador2++;    
            } while (contador2 < 20 );
            */

            //forEach
            /*
            string[] nomes = { "Jonathan", "Jonathan1", "Jonathan2", "Jonathan3" };

            foreach (string palavra in nomes) // para cada palavra no array palavras repita o bloco de c´´odigo
            {
                Console.WriteLine(palavra);
            }
            */
            //FOR


            for(int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(contador + " " +  "Contador com FOR rodando");
            }


            Console.ReadLine();





        }
        
        
    }
    
}

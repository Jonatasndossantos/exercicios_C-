using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class Control
    {
        ExerciciosIniciais exer;

        public Control() 
        { 
            this.exer = new ExerciciosIniciais();


        }//fim constructor

        public void mostrarMenu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: " +
                              "\n0. Sair" +
                              "\n1. Mostrar Números" +
                              "\n2. Média de três notas" +
                              "\nfim");

            
        }// fim metodo
        public void menu()
        {
            int opcao = 0;
            do
            {
                mostrarMenu();//Mostrar as opçoes
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\n\n\nObrigado!!!");
                        break;
                    case 1:
                        //Coleta de dados
                        Console.WriteLine("Informe um Número: "); //Escrever - Mostrar algo na tela
                        int num1 = Convert.ToInt32(Console.ReadLine()); //Lê o que o usuário digita

                        Console.WriteLine("Informe outro Número: "); //Escrever - Mostrar algo na tela
                        int num2 = Convert.ToInt32(Console.ReadLine()); //Lê o que o usuário digita

                        ExerciciosIniciais exer = new ExerciciosIniciais(num1,num2);
                        Console.WriteLine(exer.imprimir());
                        break;
                    case 2:
                        //Coleta de dados
                        Console.WriteLine("Informe uma nota entre 0 e 10: "); //Escrever - Mostrar algo na tela
                        double nota1 = Convert.ToDouble(Console.ReadLine()); //Lê o que o usuário digita

                        Console.WriteLine("Informe uma nota entre 0 e 10: "); //Escrever - Mostrar algo na tela
                        double nota2 = Convert.ToDouble(Console.ReadLine()); //Lê o que o usuário digita

                        Console.WriteLine("Informe uma nota entre 0 e 10: "); //Escrever - Mostrar algo na tela
                        double nota3 = Convert.ToDouble(Console.ReadLine()); //Lê o que o usuário digita

                        //executar
                        double media = this.exer.media(nota1, nota2, nota3);

                        //resposta
                        if (media == -1)
                        {
                            Console.WriteLine("Uma ou mais notas estão erradas, digite novamente");
                        }
                        else
                        {
                            Console.WriteLine("\n\n A media é: " + media);
                        }

                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é valida!");
                        break;


                }
            } while (opcao != 0);
        }

    }//fim class
}//fim project

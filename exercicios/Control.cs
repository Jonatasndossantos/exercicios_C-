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
                              "\n3. Verificar se um número é positivo, negativo ou zero" +
                              "\n4. Tabuada de um número" +
                              "\n5. Cálculo do fatorial de um número" +
                              "\n6. Operações matemáticas: Potencia ou Raiz" +
                              "\n7. Verificar se um número é par ou ímpar" +
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
                    case 3:
                        Console.WriteLine("Informe o número para determinar se ele é positivo, negativo ou zero:");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.verificador(num));
                        break;

                    case 4:
                        do 
                        {
                            Console.WriteLine("Tabuada de um número:");
                            num = Convert.ToInt32(Console.ReadLine());
                            if(num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        }while(num > 0);

                        Console.WriteLine(this.exer.tabuada(num));

                        break;
                    case 5:
                        Console.WriteLine("Cálculo do fatorial do número:");
                        num = Convert.ToInt32(Console.ReadLine());

                        if ((this.exer.verificador(num)) == "O número é positivo")
                        {
                            Console.WriteLine(this.exer.fatorial(num));

                        }
                        else
                        {
                            Console.WriteLine("Erro, numero negativo;");
                        }

                        break;
                    case 6:
                        Console.WriteLine("Operações matemáticas: \n" +
                                          "1 = Potencia \n" +
                                          "2 = Raiz:");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o número para a operação: ");
                        nota1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o número para o calculo: ");
                        nota2 = Convert.ToDouble(Console.ReadLine());

                        switch(opcao)
                        {   case 1: Console.WriteLine(this.exer.potencia(nota1, nota2));break;
                            case 2: Console.WriteLine(this.exer.raiz(nota1));
                                    Console.WriteLine(this.exer.raiz(nota2));break;
                            default: Console.WriteLine("Opção escolhida não é valida!"); break;}
                        break;
                    case 7:
                        Console.WriteLine("Verificar se um número é par ou ímpar:");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exer.parOuImpar(num));

                        break; 
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.ordem(num1,num2));

                        break;





                    default: Console.WriteLine("Opção escolhida não é valida!"); break;
                }
            } while (opcao != 0);
        }

    }//fim class
}//fim project

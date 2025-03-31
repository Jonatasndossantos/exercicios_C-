using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{public class Control
    { ExerciciosIniciais exer;
        public Control() 
        { this.exer = new ExerciciosIniciais();}//fim constructor
        public void mostrarMenu()
        {   Console.WriteLine("\n\nEscolha uma das opções abaixo: " +
                              "\n0. Sair" +
                              "\n1. Mostrar Números" +
                              "\n2. Média de três notas" +
                              "\n3. Verificar se um número é positivo, negativo ou zero" +
                              "\n4. Tabuada de um número" +
                              "\n5. Cálculo do fatorial de um número" +
                              "\n6. Operações matemáticas: Potencia ou Raiz" +
                              "\n7. Verificar se um número é par ou ímpar" +
                              "\n8. Dois números em ordem crescente" +
                              "\n9. Média de uma lista de números" +
                              "\n10. Contar o número de vogais" +
                              "\n11. Inverter a palavra" +
                              "\n12. Verifique se um número é primo" +

                              "\n13. somar dois números e multiplicar o resultado pelo primeiro número" +
                              "\n14. média de três números" +
                              "\n15. e receba 15%" +
                              "\n16. e receba para o usuário 5% e 50%" +
                              "\n17. o quadrado de 2 números, some os quadrados e receba" +
                              "\n18. velocidade de um objeto em m/s em km/h." +
                              "\n19. calcule o seu IMC " +
                              "\n20. receba um desconto de 9%" +
                              "\n21. receba um desconto de 7% com valores" +
                              "\n22. volume de uma caixa retangular" +
                              "\n23. receba um desconto de 27%" +
                              "\n24. área de um trapézio" +
                              "\n25. média ponderada de 3 notas de um aluno" +
                              "\n26. acrescente 16% a esse valor, divida em 10 parcelas" +
                              "\n27. Consumo médio" +
                              "\n");

            
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
                    case 9:
                            Console.Write("Informe uma quantidade: ");
                            int quan = 0;
                            quan = Convert.ToInt32(Console.ReadLine());

                            int[] vet = new int[quan]; 
                            for (int i = 0; i < (vet.Length); i++)
                            {
                                Console.Write("Informe o " + (i + 1) + "º número: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                
                                vet[i] = num;
                            }
                            Console.WriteLine(this.exer.mediaTotal(vet));
                        break;
                    case 10:

                        Console.Write("Informe uma palavra: ");
                        string palavra = Console.ReadLine();

                        Console.WriteLine(this.exer.vogais(palavra));

                        break;
                    case 11:
                        Console.Write("Informe uma palavra: ");
                        palavra = Console.ReadLine();

                        Console.WriteLine(this.exer.inverter(palavra));
                        break;
                    case 12:
                        Console.Write("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exer.VerificaNumeroPrimo(num));

                        break;
                    case 13:
                        vet = new int[2];
                        for (int i = 0; i < (vet.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe o " + (i + 1) + "º número: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                if (num < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (num < 0);

                            vet[i] = num;
                        }
                        Console.WriteLine("O resultado da soma é: "+ vet.Sum()+ " a multiplicação do resultado com o primeiro numero é: "+ (vet.Sum() * vet[0]));
                        break; 
                    case 14:
                        vet = new int[3];
                        for (int i = 0; i < (vet.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe o " + (i + 1) + "º número: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                if (num < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (num < 0);

                            vet[i] = num;
                        }
                        Console.WriteLine("A media dos valores é: " + vet.Average());
                        break;
                    case 15:
                        do
                        {
                            Console.Write("Informe o número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        } while (num < 0);

                        Console.WriteLine("15% de "+num+" é: "+ (num*0.15));

                        break;
                    case 16:
                        do
                        {
                            Console.Write("Informe o número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        } while (num < 0);

                        Console.WriteLine("5% de "+num+" é: "+ (num*0.05));
                        Console.WriteLine("50% de "+num+" é: "+ (num*0.5));

                        break;
                    case 17:
                        double[] veto = new double[2];
                        double resulta = 0;
                        for (int i = 0; i < (veto.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe o " + (i + 1) + "º número: ");
                                nota1 = Convert.ToDouble(Console.ReadLine());
                                if (nota1 < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (nota1 < 0);

                            veto[i] = nota1;

                            resulta += this.exer.potencia(veto[i], 2);
                        }
                        Console.WriteLine(resulta);
                        break;
                    case 18:
                        do
                        {
                            Console.Write("Informe a velocidade de um objeto em m/s: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        } while (num < 0);
                        Console.WriteLine("velocidade do objeto em km/h: "+ num* 3.6);
                        break;
                    case 19:
                        veto = new double[2];
                        resulta = 0;
                        for (int i = 0; i < (veto.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe ");
                                if (i == 0) { Console.Write("o peso: "); } else { Console.Write("a altura: "); }
                                nota1 = Convert.ToDouble(Console.ReadLine());
                                if (nota1 < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (nota1 < 0);
                            veto[i] = nota1;
                        }
                            resulta = (veto[0]/(this.exer.potencia(veto[1], 2)));
                        Console.WriteLine("O IMC é: "+resulta);
                        break;
                    case 20:
                        do
                        {
                            Console.Write("Informe o número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        } while (num < 0);

                        Console.WriteLine("9% de " + num + " é: " + (num * 0.09));
                        break;
                    case 21:
                        do
                        {
                            Console.Write("Informe o número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        } while (num < 0);

                        Console.WriteLine(num);
                        Console.WriteLine("O Desconto é: "+ (num-(num * 0.07)));
                        Console.WriteLine("7% de " + num + " é: " + (num * 0.07));
                        break;
                    case 22:
                        veto = new double[3];
                        resulta = 0;
                        for (int i = 0; i < (veto.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe ");
                                if (i == 0) { Console.Write("o comprimento: "); } else if(i==1) { Console.Write((i) + "ºa altura: "); } else { Console.Write((i) + "ºa altura: "); }
                                nota1 = Convert.ToDouble(Console.ReadLine());
                                if (nota1 < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (nota1 < 0);
                            veto[i] = nota1;
                        }
                        resulta = (veto[0] * veto[1] * veto[2]);
                        Console.WriteLine("O volume é: " + resulta);
                        break;
                    case 23:
                        do
                        {
                            Console.Write("Informe o número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        } while (num < 0);

                        Console.WriteLine("27% de " + num + " é: " + (num * 0.27));
                        break;
                    case 24:
                        veto = new double[3];
                        resulta = 0;
                        for (int i = 0; i < (veto.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe ");
                                if (i == 0) { Console.Write("a base menor: "); } else if (i == 1) { Console.Write("a base maior: "); } else { Console.Write("a altura: "); }
                                nota1 = Convert.ToDouble(Console.ReadLine());
                                if (nota1 < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (nota1 < 0);
                            veto[i] = nota1;
                        }
                        resulta = ((veto[0] +veto[1]) * veto[2])/2;
                        Console.WriteLine("A área de um trapézio é: " + resulta);
                        break;
                    case 25:
                        veto = new double[3];
                        resulta = 0;
                        for (int i = 0; i < (veto.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe a " + (i + 1) + "º nota: ");
                                nota1 = Convert.ToDouble(Console.ReadLine());
                                if (nota1 < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (nota1 < 0);
                            if (i == 0) { veto[i] = nota1*2; }else if (i == 1) { veto[i] = nota1*3; } else { veto[i] = nota1*5; }

                        }
                        resulta = veto.Average();
                        Console.WriteLine(resulta);
                        break;
                    case 26:
                        do
                        {
                            Console.Write("Informe o número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num < 0)
                            {
                                Console.WriteLine("Erro, numero negativo;");
                            }
                        } while (num < 0);

                        Console.WriteLine("O valor das parcelas é: "+ (num+(num*0.16))/10 );
                        Console.WriteLine("16% de " + num + " é: " + (num * 0.16));
                        Console.WriteLine("O valor total é: "+ (num + (num * 0.16)));
                        break;
                    case 27:
                        veto = new double[2];
                        resulta = 0;
                        for (int i = 0; i < (veto.Length); i++)
                        {
                            do
                            {
                                Console.Write("Informe ");
                                if (i == 0) { Console.Write("a distancia em  km: "); } else{ Console.Write("a quantidade de combustível em litros: "); }
                                nota1 = Convert.ToDouble(Console.ReadLine());
                                if (nota1 < 0)
                                {
                                    Console.WriteLine("Erro, numero negativo;");
                                }
                            } while (nota1 < 0);
                            veto[i] = nota1;
                        }
                        resulta = veto[0]/veto[1];
                        Console.WriteLine("O consumo médio de combustível: " + resulta);
                        break;


                    default: Console.WriteLine("Opção escolhida não é valida!"); break;
                }
            } while (opcao != 0);
        }

    }//fim class
}//fim project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class ExerciciosIniciais
    {
        //Área de variaveis ->globais
        private int num1;
        private int num2;
        private int num;
        private int result;

        public ExerciciosIniciais() { }
        public ExerciciosIniciais(int num1,int num2) 
        {
            this.num1 = num1;
            this.num2 = num2;
        }//fim constructor

        //Métodos Modificadores
        public int getNum1() { return this.num1; }
        public int getNum2() { return this.num2; }

        public void setNum1(int num1) { this.num1 = num1; }
        public void setNum2(int num2) { this.num2 = num2; }

        public string imprimir()
        {
            return "\n Primeiro Número: " + getNum1() +
                   "\n segundo Número: " + getNum2();
        }//fim imprimir

        public double media(double nota1, double nota2, double nota3)
        {
            double med = 0;
            
            if ((nota1 >= 0 && nota1 <= 10) && (nota2 >= 0 && nota2 <= 10) && (nota3 >= 0 && nota3 <= 10))
            {
                med = (nota1 + nota2 + nota3) / 3;
                return med;
            }//fim if
            return -1;
        }//fim media

        public string verificador(int num)
        {
            if(num < 0)
            {
                return "O número é negativo";
            }else if(num > 0)
            {
                return "O número é positivo";
            }else
            {
                return "O número é zero!";
            }
        }

        public string tabuada(int num)
        {
            string result = "";
            for(int i = 1; i < 11; i++)
            {
                result += (i + " * " + num + " = " + (num * i)+"\n");
            }
            return result;
        }
        public int fatorial(int num)
        {
            int result = 1;
            for (int i = (num-1); i > 0; i--)
            {
                if (i == num)
                {
                    result += (i * num);
                }
                result += result*i;
            }
            return result;
        }

        public double potencia(double num, double num2)
        {
            double result = 1;
            for (int i = 0; i <= num2; i++)
            {
                result = (long)Math.Pow(num, num2);
            }
            return result;
        }
        public double raiz(double num)
        {
            return (Math.Sqrt(num));
        }

        public string parOuImpar(int num)
        {
            if((num%2) == 0)
            {
                return "O número é par";
            }
            else
            {
                return "O número é impar";
            }
        }

        public string ordem(int num1, int num2)
        {
            int[] result = { num1,num2 };

            Array.Sort(result);
            string resultado = "";
            foreach (int i in result)
            {
                resultado += i+"\n";
            }
            return resultado;
        }

        public string mediaTotal(int[] vet)
        {
            return "A média de todos os números é " + (vet.Sum()/(vet.Length));
        }

        public string vogais(string palavra)
        {
            int tamanho = palavra.Length;
            int contador = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if ((palavra.Substring(i, 1) == "a") ||
                    (palavra.Substring(i, 1) == "A") ||
                    (palavra.Substring(i, 1) == "e") ||
                    (palavra.Substring(i, 1) == "E") ||
                    (palavra.Substring(i, 1) == "i") ||
                    (palavra.Substring(i, 1) == "I") ||
                    (palavra.Substring(i, 1) == "o") ||
                    (palavra.Substring(i, 1) == "O") ||
                    (palavra.Substring(i, 1) == "u") ||
                    (palavra.Substring(i, 1) == "U"))
                {
                    contador++;
                }
            }
            return "A palavra " + palavra + " tem " + contador + " vogais";
        }

        public string inverter(string palavra)
        {
            string textoInvertido = new string(palavra.Reverse().ToArray());

            return textoInvertido;

        }

        public string VerificaNumeroPrimo(int num)
        {
            int cont = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    cont = cont + 1;
                }
            }

            if ((cont > 2) || (num == 4))
                return "O número " + num + " NÃO É primo";
            else
                return "O número " + num + " É primo";
        }



    }//fim classe
}//fim project

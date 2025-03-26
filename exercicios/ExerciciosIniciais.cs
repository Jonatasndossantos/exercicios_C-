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
            result = [result, num1, num2];
            return OrderBy(result).list();
        }



    }//fim classe
}//fim project

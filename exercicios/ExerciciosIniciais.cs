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


    }//fim classe
}//fim project

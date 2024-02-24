using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    internal class Método_Model
    {
        //Área de Variáveis
        private double num1;
        private double num2;

        //Método Construtor = Instancia as variáveis
        public Método_Model()
        {
            ConsultarNum1 = 0;
            num2 = 0;

        }//Fim do Construtor

        //Método Get e Set
        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }

        }//Fim do get e set

        public double ConsultarNum2
        {
            get { return num2; }
            set { num2 = value; }

        }//Fim do get e set

        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2;

        }//Fim do Somar

        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum2;

        }//Fim Subtrair

        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;

        }//Fim multiplicar

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else 
            {
                return ConsultarNum1 / ConsultarNum2;
            } 
           
        }//Fim Divisão

    }//Fim da classe
}//Fim do Projeto

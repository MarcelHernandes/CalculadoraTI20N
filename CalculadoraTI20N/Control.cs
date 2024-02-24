using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
     class Control
    {
        //Criei uma Conexão com a Classe model
        Método_Model Mod;

        public Control()
        {
            Mod = new Método_Model();//Chamando o Contrutor da classe model
        }//Fim do Construtor

        public string Menu() 
        {
            string msg = "#### Menu #### \n\n" +
                         "0. Sair\n"           +
                         "1. Somar\n"          +
                         "2. Subtrair\n"       +
                         "3. Multiplicar\n"    +
                         "4. Dividir\n"        +
                         "Escolha uma das opções acima:";
            return msg; 
        }//Fim do Menu

        public void Operacao()
        {
            int opcao;
            do
            {

                Console.WriteLine(Menu());//Mostrar as opções na tela
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//Chamando o método para coleta
                        Console.WriteLine("A Soma dos valores digitados é: " + Mod.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração dos valores digitados é: " + Mod.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        Console.WriteLine("A multiplicação dos valores digitados é: " + Mod.Multiplicar());
                        break;
                    case 4:
                        Coletar();
                        if (Mod.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por Zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão dos valores digitais é: " + Mod.Dividir());
                        }
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }//Fim do Switch
            } while (opcao != 0);
        }//Fim do Operação

        public void Coletar()
        {
            //Coletando o primeiro número
            Console.WriteLine("Informe o primeiro Número");
            Mod.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());

            //Coletando o segundo número
            Console.WriteLine("Informe o Segundo número");
            Mod.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método Coletar

    }//Fim da Classe
}//Fim do Projeto

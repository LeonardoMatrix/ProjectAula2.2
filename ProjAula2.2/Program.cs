using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int Operacao = 0;

            Calculo calculo = new Calculo();


            do
            {
                try

                {


                    Console.WriteLine("Informe: 0-Sair 1-Somar 2-Subtrair 3-Multiplicar 4-Dividir");
                    Operacao = Convert.ToInt32(Console.ReadLine());

                    if  (Operacao != 0) {

                        try

                        {

                        Console.WriteLine("Digite a 1 nota: ");
                        calculo.ValorA = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite a 2 nota: ");
                        calculo.ValorB = Convert.ToInt32(Console.ReadLine());

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Caracter invalido");
                            Console.ReadKey();
                            Operacao = 0;

                        }

                    }



                    switch (Operacao)
                    {
                        case 0:
                            Console.WriteLine("Saindo...");
                            break;
                        case 1:
                            Console.WriteLine("Resultado: " + calculo.Somar());
                           
                            break;
                        case 2:
                            Console.WriteLine("Resultado: " + calculo.Subtrair());
                            break;
                        case 3:
                            Console.WriteLine("Resultado: " + calculo.Multiplicar());
                            break;
                        case 4:
                                Console.WriteLine("Resultado: " + calculo.Dividir());                       
                            break;
                            
                        default:
                            Console.WriteLine("Caracter invalido");
                            break;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Operação invalida");

                }

            } while (Operacao != 0);


        } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public double bas;
        public double altura;
        public double maca;
        public double fixo;
        public double vendas;
        public int ano;
        public int meses;
        public int dias;
        public double eleitores;
        public double brancos;
        public double nulos;
        public double validos;
        public double salario;
        public double reajuste;
        public double custoDeFabrica;
        public int numConta;

        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }

        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03" +
                             "\n4. Exercício 04" +
                             "\n5. Exercício 05" +
                             "\n6. Exercício 06" +
                             "\n7. Exercício 07" +
                             "\n8. Exercício 08" +
                             "\n9. Exercício 09" +
                             "\n11. Exercicio 11" +
                             "\n12. Exercicio 12" +
                             "\n0. Sair");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;

                case 2:
                    Console.WriteLine("Informe um número");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de " + num +
                        " é: " + model.Exercicio02(num));
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("Informe a base: ");
                        bas = Convert.ToDouble(Console.ReadLine());
                        if (bas <= 0)
                        {
                            Console.WriteLine("Base digitada não é valida," +
                                " digite novamente!");
                        }
                    } while (bas <= 0);

                    do
                    {
                        Console.WriteLine("Informe a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura <= 0)
                        {
                            Console.WriteLine("Altura digitada não é valida," +
                                " digite novamente!");
                        }
                    } while (altura <= 0);

                    Console.WriteLine("A área do retângulo é: " +
                        model.Exercicio03(bas, altura));
                    break;

                case 4:
                    do
                    {
                        Console.WriteLine("Informe quantos anos você tem: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        if (ano <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (ano <= 0);
                    do
                    {
                        Console.WriteLine("Informe quantos meses você tem: ");
                        meses = Convert.ToInt32(Console.ReadLine());
                        if (meses <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (meses < 0);
                    do
                    {
                        Console.WriteLine("Informe quantos dias vocês tem: ");
                        dias = Convert.ToInt32(Console.ReadLine());
                        if (dias <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (dias <= 0);
                    Console.WriteLine("Sua idade em dias é: " + model.Exercicio04(ano, meses, dias) + " dias");
                    break;

                case 5:
                    do
                    {
                        Console.WriteLine("Informe o total de eleitores: ");
                        eleitores = Convert.ToDouble(Console.ReadLine());
                        if (eleitores <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (eleitores <= 0);
                    do
                    {
                        Console.WriteLine("Informe o total de brancos: ");
                        brancos = Convert.ToDouble(Console.ReadLine());
                        if (brancos <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (brancos <= 0);
                    do
                    {
                        Console.WriteLine("Informe o total de nulos: ");
                        nulos = Convert.ToDouble(Console.ReadLine());
                        if (nulos <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (nulos <= 0);
                    do
                    {
                        Console.WriteLine("Informe o total de válidos: ");
                        validos = Convert.ToDouble(Console.ReadLine());
                        if (validos <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (validos <= 0);
                    Console.WriteLine(model.Exercicio05(eleitores, brancos, nulos, validos));
                    break;

                case 6:
                    do
                    {
                        Console.WriteLine("Digite o seu salario: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        if (salario < 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (salario <= 0);
                    do
                    {
                        Console.WriteLine("Digite o reajuste: ");
                        reajuste = Convert.ToDouble(Console.ReadLine());
                        if (reajuste <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (reajuste <= 0);
                    Console.WriteLine("O seu novo salário é:" + model.Exercicio06(salario, reajuste));
                    break;

                case 7:
                    do
                    {
                        Console.WriteLine("Digite o custo de fabrica do carro: ");
                        custoDeFabrica = Convert.ToDouble(Console.ReadLine());
                        if (custoDeFabrica <= 0)
                        {
                            Console.WriteLine("Valor inválido." +
                                "\nTente novamente.");
                        }
                    } while (custoDeFabrica <= 0);
                    Console.WriteLine("O custo final ao consumidor é: R$ " + model.Exercicio07(custoDeFabrica));
                    break;
                    
                case 8:
                    Console.WriteLine("Digite sua primeira nota: ");
                    double nota1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite sua segunda nota: ");
                    double nota2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite sua terceira nota: ");
                    double nota3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Sua média é: " + model.Exercicio08(nota1, nota2, nota3));
                    break;

                case 9:
                    do
                    {
                        Console.WriteLine("Digite o número de maçãs compradas: ");
                        maca = Convert.ToDouble(Console.ReadLine());
                        if (maca < 0)
                        {
                            Console.WriteLine("O número digitado é invalido." +
                                "\nTente novamente.");
                        }
                    } while (maca < 0);

                    Console.WriteLine("O total a ser pago pelas maças é: R$ " + model.Exercicio09(maca) + ",00");
                    break;

                //exercicio10

                case 11:
                    do
                    {
                        Console.WriteLine("Digite o seu salário fixo: ");
                        fixo = Convert.ToDouble(Console.ReadLine());
                        if (fixo <= 0)
                        {
                            Console.WriteLine("Valor digitado é invalido." +
                                "\nTente novamente.");
                        }
                    } while (fixo <= 0);
                    do
                    {
                        Console.WriteLine("Digite o valor total de vendas efetuadas");
                        vendas = Convert.ToDouble(Console.ReadLine());
                        if (vendas <= 0)
                        {
                            Console.WriteLine("Valor digitado é invalido." +
                                "\nTente novamente.");
                        }
                    } while (vendas <= 0);
                    Console.WriteLine("Seu salário total é: R$" + model.Exercicio11(fixo, vendas));
                    break;

                case 12:
                    do
                    {
                        Console.WriteLine("Digite o numero da sua conta bancaria");
                        numConta = Convert.ToInt32(Console.ReadLine());
                        if (numConta <= 0)
                        {
                            Console.WriteLine("Valor digitado é invalido." +
                                "\nTente novamente.");
                        }
                    } while (numConta <= 0);
                    Console.WriteLine("Digite o seu saldo");
                    int saldo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite seu valor de débito");
                    int debito = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite seu valor de credito");
                    int credito = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Seu saldo atual é: R$ " + model.Exercicio12(numConta, saldo, debito, credito));
                    break;

                case 0:
                    Console.WriteLine("Obrigado!!");
                    break;

                default:
                    Console.WriteLine("Código digitado não é valido!");
                    break;
            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
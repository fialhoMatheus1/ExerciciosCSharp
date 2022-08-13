using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ModelExercicios
    {
        //Declaração de variáveis
        private int A;
        private int B;
        private int auxiliar;
        private double eleitores;
        private double brancos;
        private double nulos;
        private double validos;
        private double reajuste;
        private double aux;

        //Declarar o construtor
        public ModelExercicios()
        {
            ConsultarA = 10;
            ConsultarB = 20;
            ConsultarAuxiliar = 0;
            ConsultarEleitores = 0;
            ConsultarBrancos = 0;
            ConsultarNulos = 0;
            ConsultarValidos = 0;
            ConsultarReajuste = 0;
            ConsultarAux = 0;
            ConsultarNotas = 0;
            ConsultarMaca = 0;
            ConsultarCusto = 0;
            ConsultarVendas = 0;
            ConsultarSaldo = 0;
            ConsultarCalculadora = 0;
        }//fim do construtor

        public int ConsultarA
        {
            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }
        }//fim do consultarA

        public int ConsultarB
        {
            get
            {
                return B;
            }
            set
            {
                this.B = value;
            }
        }//fim do consultarB

        public int ConsultarAuxiliar
        {
            get
            {
                return auxiliar;
            }
            set
            {
                this.auxiliar = value;
            }
        }//fim do consultarC

        public double ConsultarEleitores
        {
            get
            {
                return eleitores;
            }
            set
            {
                this.eleitores = value;
            }
        }// fim do consultarEleitores

        public double ConsultarBrancos
        {
            get
            {
                return brancos;
            }
            set
            {
                this.brancos = value;
            }
        }// fim do consultarBrancos

        public double ConsultarNulos
        {
            get
            {
                return nulos;
            }
            set
            {
                this.nulos = value;
            }
        }// fim do ConsultarNulos

        public double ConsultarValidos
        {
            get
            {
                return validos;
            }
            set
            {
                this.validos = value;
            }
        }// fim do ConsultarValidos

        public double ConsultarReajuste
        {
            get
            {
                return reajuste;
            }
            set
            {
                this.reajuste = value;
            }
        }// fim do metodo consultarPercent

        public double ConsultarAux
        {
            get
            {
                return aux;
            }
            set
            {
                this.aux = value;
            }
        }// fim do metodo ConsultarAux

        public double ConsultarNotas
        {
            get
            {
                return aux;
            }
            set
            {
                this.aux = value;
            }
        }// fim do consultarNotas

        public double ConsultarMaca
        {
            get
            {
                return aux;
            }
            set
            {
                this.aux = value;
            }
        }//fim do consultarMaca

        public double ConsultarCusto
        {
            get
            {
                return aux;
            }
            set
            {
                this.aux = value;
            }
        }//fim do metodo CustoConsumidor

        public double ConsultarVendas
        {
            get
            {
                return aux;
            }
            set
            {
                this.aux = value;
            }
        }// fim do metodo consultarVendas

        public int ConsultarSaldo
        {
            get
            {
                return auxiliar;
            }
            set
            {
                this.auxiliar = value;
            }
        }//fim do metodo consultarSaldo

        public int ConsultarCalculadora
        {
            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }
        }//fim do metodo consultarCalculadora

        //Exercício01

        public string Exercicio01()
        {
            ConsultarAuxiliar = ConsultarA;
            ConsultarA = ConsultarB;
            ConsultarB = ConsultarAuxiliar;
            return "A: " + ConsultarA + "\nB: " + ConsultarB;
        }//fim do métodoExercicio01

        //Exercicio 02

        public int Exercicio02(int num)
        {
            return num - 1;
        }

        //Exercicio 03

        public double Exercicio03(double bas, double altura)
        {
            return bas * altura;
        }// fim do metodo exercicio03

        //Exercicio 04

        public int Exercicio04(int ano, int mes, int dias)
        {
            return (ano * 365) + (mes * 30) + dias;
        }//fim do método exercicio04

        //Exercicio 05

        public string Exercicio05(double eleitores, double brancos, double nulos, double validos)
        {
            ConsultarEleitores = eleitores;
            ConsultarBrancos = (brancos * ConsultarEleitores) / 100;
            ConsultarNulos = (nulos * ConsultarEleitores) / 100;
            ConsultarValidos = (validos * ConsultarEleitores) / 100;
            return "O percentual de brancos nulos é: " + ConsultarBrancos + "%" +
                "\nO percentual de nulos é: " + ConsultarNulos + "%" +
                "\nO perncentual de válidos é: " + ConsultarValidos + "%";
        }//fim do método exercicios05

        //Exercicio 06

        public double Exercicio06(double salario, double reajuste)
        {
            ConsultarReajuste = (salario * reajuste) / 100;
            ConsultarAux = ConsultarReajuste + salario;
            return ConsultarAux;
        }

        //Exercicio 07

        public double Exercicio07(double custoDeFabrica)
        {
            ConsultarCusto = custoDeFabrica + (custoDeFabrica * 73) / 100;
            return ConsultarCusto;
        }// fim do metodo exercicio07

        //Exercicio 08

        public double Exercicio08(double nota1, double nota2, double nota3)
        {
            ConsultarNotas = (nota1 + nota2 + nota3) / 100;
            return ConsultarNotas;
        }// fim do metodo exercicio08

        //Exercicio 09

        public double Exercicio09(double maca)
        {
            if (maca < 12)
            {
                ConsultarMaca = maca * 1.30;
            }
            if (maca > 11)
            {
                ConsultarMaca = maca * 1.00;
            }
            return ConsultarMaca;
        }// fim do metodo exercio09

        //Exercicio 10

        //Exercicio 11

        public double Exercicio11(double fixo, double vendas)
        {
            if(vendas <= 1500)
            {
                ConsultarVendas = (vendas * 3) / 100;
            }
           if(vendas > 1500)
            {
                ConsultarVendas = ((1500 * 3) / 100) + ((vendas - 1500) * 5) / 100;
                //vendedor recebe os 3% de 1500 vendas, junto com 5% do que vendeu acima de 1500.
            }
            return fixo + ConsultarVendas;
        }//fim do metodo exercicio11

        //Exercicio 12

        public string Exercicio12(int numConta, int saldo, int debito, int credito)
        {
            ConsultarSaldo = saldo - debito + credito;
            if (ConsultarSaldo < 0)
            {
                return "Seu salto atual é: R$ " + ConsultarSaldo +
                    "\nSaldo NEGATIVO!!";
            }
            else
                return "Seu saldo atual é: R$ " + ConsultarSaldo +
                        "\nSalto POSITIVO!!";
        }//fim do metodo exercicio12

    }//fim da classe
}//fim do projeto
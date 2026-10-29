using System;

namespace Ex00 
{
    public class Ex00 
    {
        public static void Main(string[] args) 
        {            
            int opcao = 0;
            int subopcao = 0;

            do
            {
                mostrarMenu();
                opcao = int.Parse(Console.ReadLine()); 

                switch (opcao)
                {
                case 1:
                    Console.WriteLine("1 - MostrarCardapio");
                    Console.WriteLine("2 - CodigoValido");
                    subopcao = int.Parse(Console.ReadLine());

                    switch (subopcao) //aqui criei mais um switch case pra opcao dentro delas
                    {
                    case 1:
                        MostrarCardapio(); // executando os metodos
                        break;
                    case 2:
                        CodigoValido();
                        break;
                    default:
                        Console.Write("Opção invalida! :(");
                        break;
                    } 
                    break;
                    
                case 2:
                    Console.WriteLine("1 - Registrar Venda");
                    Console.WriteLine("2 - Total Produto");
                    Console.WriteLine("3 - Total Dia");
                    subopcao = int.Parse(Console.ReadLine());

                    switch (subopcao)
                    {
                    case 1:
                        RegistrarVenda();
                        break;
                    case 2:
                        TotalProduto();
                        break;
                    case 3:
                        TotalDia();
                        break;
                    default:
                        Console.Write("Opção invalida! :(");
                        break;
                    }
                    break;

                case 3:
                    Console.WriteLine("1 - Faturamento Produto");
                    Console.WriteLine("2 - Faturamento Semana");
                    Console.WriteLine("3 - Produto Campeao");
                    Console.WriteLine("4 - Dia Mais Movimentado");
                    subopcao = int.Parse(Console.ReadLine());

                    switch (subopcao)
                    {
                    case 1:
                        FaturamentoProduto();
                        break;
                    case 2:
                        FaturamentoSemana();
                        break;
                    case 3:
                        ProdutoCampeao();
                        break;
                    case 4:
                        DiaMaisMovimentado();
                        break;
                    default:
                        Console.Write("Opção invalida! :(");
                        break;
                    }
                    break;
                    
                case 0:
                    Console.WriteLine("Saindo do sistema!");
                    break;
                    
                default:
                    Console.WriteLine("Opcao indisponivel!");
                    break;
                }
                
            } while (opcao != 0);
        }
            static void mostrarMenu()
            {
                Console.WriteLine("=========  *LANCHONETE SENAC* ==================");
                Console.WriteLine("---------- OPÇÕES ----------");
                Console.WriteLine("1 - Ver Cardapio ");
                Console.WriteLine("2 - Ver Vendas");
                Console.WriteLine("3 - Ver Resumo e faturamento");
                Console.WriteLine("0 - Sair");
            }

            static void MostrarCardapio(){
                
            }

            static void CodigoValido(){
                
            }

            static void RegistrarVenda(){
                
            }

            static void TotalProduto(){
                
            }

            static void TotalDia(){
                
            }

            static void FaturamentoProduto(){
                
            }

            static void FaturamentoSemana(){
                
            }

            static void ProdutoCampeao(){
                
            }

            static void DiaMaisMovimentado(){
        }
    }
}

using System;

namespace Desafio8.ConsoleApp
{
    internal class Program
    {
        #region variáveis equipamentos
        static string[] nomesEquipamento = new string[1000];
        static decimal[] precosEquipamento = new decimal[1000];
        static string[] numerosSerieEquipamento = new string[1000];
        static string[] fabricantesEquipamento = new string[1000];
        static string[] datasFabricacaoEquipamento = new string[1000];

        static int posicaoEquipamento = 0;
        #endregion


        #region variáveis chamados
        static string[] tituloChamado = new string[1000];
        static string[] descricaoChamado = new string[1000];
        static string[] dataChamado = new string[1000];
        static string[] numSerie = new string[1000];

        static int posicaoChamado = 0;
        #endregion

        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcaoSubMenu = ApresentarMenuEquipamentos();

                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")
                        InserirNovoEquipamento();

                    else if (opcaoSubMenu == "2")
                        VisualizarEquipamentos();

                    else if (opcaoSubMenu == "3")
                        EditarEquipamentos();

                    else if (opcaoSubMenu == "4")
                        ExcluirEquipamentos();
                }
                else if (opcao == "2")
                {
                    string opcaoSubMenu = ApresentarMenuChamados();

                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")
                        InserirNovoChamado();

                    else if (opcaoSubMenu == "2")
                        VisualizarChamados();

                    else if (opcaoSubMenu == "3")
                        EditarChamados();

                    else if (opcaoSubMenu == "4")
                        ExcluirChamados();
                }

                Console.ReadLine();
            }
        }

        #region Controle de Chamados
        private static void ExcluirChamados()
        {
            Console.Clear();
            Console.WriteLine("Chamados 1.0");
            Console.WriteLine();

            Console.WriteLine("Digite o titulo do chamado: ");
            string tituloDelete = Console.ReadLine();

            Console.WriteLine("Excluindo Chamado:\n");
            Console.ReadLine();

            for (int i = 0; i < posicaoChamado; i++)
            {
                if (tituloChamado[i] == tituloDelete)
                {
                    tituloChamado[i] = null;
                    descricaoChamado[i] = null;
                    dataChamado[i] = null;
                    numSerie[i] = null;
                    continue;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nChamado excluido com sucesso :-)");
            Console.ResetColor();
        }

        private static void EditarChamados()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos 1.0");
            Console.WriteLine();

            Console.WriteLine("Digite o titulo do chamado: ");
            string TituloEdit = Console.ReadLine();

            for (int i = 0; i < posicaoChamado; i++)
            {
                if (tituloChamado[i] == TituloEdit)
                {

                    Console.Write("Digite o titulo do chamado (ou digite x para pular essa parte): ");
                    if (Console.ReadLine() == "x")
                    {
                        Console.WriteLine("valor não alterado");
                    }
                    else
                    {
                        string novoTitulo = Console.ReadLine();
                        tituloChamado[i] = novoTitulo;
                    }

                    Console.Write("Digite a descrição do chamado (ou digite x para pular essa parte): ");
                    if (Console.ReadLine() == "x")
                    {
                        Console.WriteLine("valor não alterado");
                    }
                    else
                    {
                        string novoDescr = Console.ReadLine();
                        descricaoChamado[i] = novoDescr;
                    }

                    Console.Write("Digite a data do chamado (ou digite x para pular essa parte): ");
                    if (Console.ReadLine() == "x")
                    {
                        Console.WriteLine("valor não alterado");
                    }
                    else
                    {
                        string novaDataChamado = Console.ReadLine();
                        dataChamado[i] = novaDataChamado;
                    }

                    Console.Write("Digite o número de série do Equipamento (ou digite x para pular essa parte): ");
                    if (Console.ReadLine() == "x")
                    {
                        Console.WriteLine("valor não alterado");
                    }
                    else
                    {
                        string novoNumSerie = Console.ReadLine();
                        numSerie[i] = novoNumSerie;
                    }
                    continue;
                }
            }
        }
                private static void VisualizarChamados()
                {
                    Console.Clear();
                    Console.WriteLine("Chamados 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Visualizando Chamados:\n");


                    for (int posicao = 0; posicao < 10; posicao++)
                    {
                        if (tituloChamado[posicao] != null)
                        {
                            Console.WriteLine("Titulo:\t\t" + tituloChamado[posicao]);
                            Console.WriteLine("Descrição:\t" + descricaoChamado[posicao]);
                            Console.WriteLine("Equipamento:\t" + numSerie[posicao]);
                            Console.WriteLine("Data:\t\t" + dataChamado[posicao]);
                            Console.WriteLine();
                        }
                    }
                }

                private static void InserirNovoChamado()
                {
                    Console.Clear();
                    Console.WriteLine("Chamados 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Inserindo um novo chamado:\n");

                    Console.Write("Digite o titulo do Chamado: ");
                    string titulo = Console.ReadLine();
                    tituloChamado[posicaoChamado] = titulo;

                    Console.Write("Digite a descrição do chamado: ");
                    string descricao = Console.ReadLine();
                    descricaoChamado[posicaoChamado] = descricao;

                    Console.Write("Digite a data do chamado: ");
                    string data = Console.ReadLine();
                    dataChamado[posicaoChamado] = data;

                    Console.Write("Digite o número de série do Equipamento: ");
                    string numeroSerie = Console.ReadLine();
                    numSerie[posicaoChamado] = numeroSerie;
                    for (int i = 0; i < posicaoEquipamento; i++)
                    {
                        if (numerosSerieEquipamento[i] == numeroSerie)
                        {
                            Console.WriteLine("Nome: " + nomesEquipamento[i]);
                            Console.WriteLine("Preço: " + precosEquipamento[i]);
                            Console.WriteLine("Numero de Série: " + numerosSerieEquipamento[i]);
                            Console.WriteLine("Data de fabricação: " + datasFabricacaoEquipamento[i]);
                            Console.WriteLine("Fabricante: " + fabricantesEquipamento[i]);
                            continue;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nChamado cadastrado com sucesso :-)");
                    Console.ResetColor();

                    posicaoEquipamento++;
                }

                private static string ApresentarMenuChamados()
                {
                    Console.Clear();
                    Console.WriteLine("Manutenção de Chmados 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Digite 1 para Inserir novo Chamado");
                    Console.WriteLine("Digite 2 para Visualizar Chamados");
                    Console.WriteLine("Digite 3 para Editar um Chamado");
                    Console.WriteLine("Digite 4 para Exluir um Chamado");

                    Console.WriteLine("Digite s para Sair");

                    string opcaoSubMenu = Console.ReadLine();

                    return opcaoSubMenu;
                }

                #endregion

                #region Cadastro Equipamentos
                private static void ExcluirEquipamentos()
                {
                    Console.Clear();
                    Console.WriteLine("Manutenção de Equipamentos 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Digite o numero de série do equipamento: ");
                    string numSerieDelete = Console.ReadLine();

                    Console.WriteLine("Excluindo Equipamentos:\n");
                    Console.ReadLine();

                    for (int i = 0; i < posicaoEquipamento; i++)
                    {
                        if(numerosSerieEquipamento[i] == numSerie[i])
                        {
                        Console.WriteLine("Não pode excluir um equipamento vinculado a um chamado, por favor exclua o chamado primeiro.");
                        }
                        else
                        {
                            if (numerosSerieEquipamento[i] == numSerieDelete)
                            {
                                nomesEquipamento[i] = null;
                                precosEquipamento[i] = 0;
                                numerosSerieEquipamento[i] = null;
                                datasFabricacaoEquipamento[i] = null;
                                fabricantesEquipamento[i] = null;
                                continue;
                            }
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEquipamento excluido com sucesso :-)");
                    Console.ResetColor();
                }

                private static void EditarEquipamentos()
                {
                    Console.Clear();
                    Console.WriteLine("Manutenção de Equipamentos 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Digite o numero de série do equipamento: ");
                    string numSerieEdit = Console.ReadLine();

                    for (int i = 0; i < posicaoEquipamento; i++)
                    {
                        if (numerosSerieEquipamento[i] == numSerieEdit)
                        {

                            Console.Write("Digite o nome do Equipamento (ou digite x para pular essa parte): ");
                            if (Console.ReadLine() == "x")
                            {
                                Console.WriteLine("valor não alterado");
                            }
                            else
                            {
                                string novoNome = Console.ReadLine();
                                nomesEquipamento[i] = novoNome;
                            }

                            Console.Write("Digite o preço do Equipamento (ou digite x para pular essa parte): ");
                            if (Console.ReadLine() == "x")
                            {
                                Console.WriteLine("valor não alterado");
                            }
                            else
                            {
                                decimal novoPreco = Convert.ToDecimal(Console.ReadLine());
                                precosEquipamento[i] = novoPreco;
                            }

                            Console.Write("Digite o número de série do Equipamento (ou digite x para pular essa parte): ");
                            if (Console.ReadLine() == "x")
                            {
                                Console.WriteLine("valor não alterado");
                            }
                            else
                            {
                                string novoNumSerieEquip = Console.ReadLine();
                                numerosSerieEquipamento[i] = novoNumSerieEquip;
                            }

                            Console.Write("Digite a data de fabricação do Equipamento (ou digite x para pular essa parte): ");
                            if (Console.ReadLine() == "x")
                            {
                                Console.WriteLine("valor não alterado");
                            }
                            else
                            {
                                string novaData = Console.ReadLine();
                                datasFabricacaoEquipamento[i] = novaData;
                            }

                            Console.Write("Digite o fabricante do Equipamento (ou digite x para pular essa parte): ");
                            if (Console.ReadLine() == "x")
                            {
                                Console.WriteLine("valor não alterado");
                            }
                            else
                            {
                                string novoFabricante = Console.ReadLine();
                                fabricantesEquipamento[i] = novoFabricante;
                            }
                            continue;
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEquipamento editado com sucesso :-)");
                    Console.ResetColor();
                }

                static void VisualizarEquipamentos()
                {
                    Console.Clear();
                    Console.WriteLine("Manutenção de Equipamentos 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Visualizando Equipamentos:\n");

                    for (int posicao = 0; posicao < 10; posicao++)
                    {
                        if (nomesEquipamento[posicao] != null)
                        {
                            Console.WriteLine("Nome:\t\t" + nomesEquipamento[posicao]);
                            Console.WriteLine("Preço:\t\t" + precosEquipamento[posicao]);
                            Console.WriteLine("Número de Série:\t" + numerosSerieEquipamento[posicao]);
                            Console.WriteLine("Data Fabricação:\t" + datasFabricacaoEquipamento[posicao]);
                            Console.WriteLine("Fabricante:\t\t" + fabricantesEquipamento[posicao]);
                            Console.WriteLine();
                        }
                    }
                }

                static void InserirNovoEquipamento()
                {
                    Console.Clear();
                    Console.WriteLine("Manutenção de Equipamentos 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Inserindo um novo Equipamento:\n");

                    Console.Write("Digite o nome do Equipamento: ");
                    string nome = Console.ReadLine();
                    nomesEquipamento[posicaoEquipamento] = nome;

                    Console.Write("Digite o preço do Equipamento: ");
                    decimal preco = Convert.ToDecimal(Console.ReadLine());
                    precosEquipamento[posicaoEquipamento] = preco;

                    Console.Write("Digite o número de série do Equipamento: ");
                    string numeroSerie = Console.ReadLine();
                    numerosSerieEquipamento[posicaoEquipamento] = numeroSerie;

                    Console.Write("Digite a data de fabricação do Equipamento: ");
                    string data = Console.ReadLine();
                    datasFabricacaoEquipamento[posicaoEquipamento] = data;

                    Console.Write("Digite o fabricante do Equipamento: ");
                    string fabricante = Console.ReadLine();
                    fabricantesEquipamento[posicaoEquipamento] = fabricante;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEquipamento cadastrado com sucesso :-)");
                    Console.ResetColor();

                    posicaoEquipamento++;
                }

                static string ApresentarMenuEquipamentos()
                {
                    Console.Clear();
                    Console.WriteLine("Manutenção de Equipamentos 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Digite 1 para Inserir novo Equipamento");
                    Console.WriteLine("Digite 2 para Visualizar Equipamentos");
                    Console.WriteLine("Digite 3 para Editar um Equipamento");
                    Console.WriteLine("Digite 4 para Exluir um Equipamento");

                    Console.WriteLine("Digite s para Sair");

                    string opcaoSubMenu = Console.ReadLine();

                    return opcaoSubMenu;
                }
                #endregion

                static string ApresentarMenuPrincipal()
                {
                    Console.Clear();
                    Console.WriteLine("Manutenção de Equipamentos 1.0");
                    Console.WriteLine();

                    Console.WriteLine("Digite 1 para Cadastro de Equipamentos");
                    Console.WriteLine("Digite 2 para Controle de Chamados");

                    Console.WriteLine("Digite s para Sair");

                    string opcao = Console.ReadLine();

                    return opcao;
                }


            }

        }


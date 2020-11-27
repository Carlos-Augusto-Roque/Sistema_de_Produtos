using System;

namespace Sistema_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            string[] descricao = new string[10];//array que recebe a descrição do produto
            float[] preco = new float[10];//array que recebe o preço do produto
            bool[] promocao = new bool[10];//array tipo bool para receber true or false

            //cabeçalho
            Console.WriteLine("-------------------------");//exibição da mensagem
            Console.WriteLine("---Sistema de Produtos---");//exibição da mensagem
            Console.WriteLine("-------------------------");//exibição da mensagem

            //menu
            int contador = 0;//variável contador
            int escolha;//variável escolha

            do//estrutura condicional do-while , primeiro lê o menu de opções
            {
                Console.WriteLine("-------------------------");//exibição da mensagem
                Console.WriteLine("Menu inicial");//exibição da mensagem
                Console.WriteLine("Selecione uma opção: ");//exibição da mensagem
                Console.ForegroundColor = ConsoleColor.Green;//altera a cor do texto a partir daqui
                Console.WriteLine("[1] - Cadastrar produtos");//exibição da mensagem
                Console.WriteLine("[2] - Listar produtos");//exibição da mensagem
                Console.WriteLine("[3] - Sair");//exibição da mensagem
                escolha = int.Parse(Console.ReadLine());//entrada e armazenamento da escolha
                Console.ResetColor();//encerra a alteração da cor do texto                 
                
                //então avalie a escolha da opção
                switch(escolha)
                {
                    case 1 : //caso 1 - cadastrar o produto
                        string resposta;//variável para resposta se quer cadastrar novo produto

                        do//condicional do-while - efetue o primeiro cadastro máx de 10 clientes
                        {
                            if(contador < 5)//condicional if -- caso contador for menor que 10,então tem opção de cadastrar novo produto 
                            {
                                Console.WriteLine($"Digite a descrição do {contador+1}° produto");//exibição da mensagem
                                descricao[contador] = Console.ReadLine();//entrada e armazenamento da descrição do produto
                                Console.WriteLine($"Digite o preço do {contador+1}° produto");//exibição da mensagem
                                preco[contador] = float.Parse(Console.ReadLine());//entrada e armazenamento do preço
                                Console.WriteLine($"O {contador+1}° produto está em promoção ? true or false");//exibição da mensagem
                                promocao[contador] = bool.Parse(Console.ReadLine());//entra e armazenamento da promoção
                                
                                contador++;//incremento de 1 em 1 no contador

                            }else// caso contrário, exibir que o limite de cadastro está excedido
                            {
                                Console.WriteLine("fim do cadastro!");//exibição da mensagem
                                break;//encerrar
                            }

                            //perguntar se quer efetuar novo cadastro
                            Console.WriteLine("Gostaria de cadastrar um novo produto? s/n");//exibição da mensagem
                            resposta = Console.ReadLine();//entrada e armazenamento da resposta

                        }while(resposta == "s");//condicional while ,enquanto a resposta for igual a sim, então volte para o cadastro até que exceda o limite

                    break; //fim do cadastro de produtos (caso 1)

                    

                    case 2: //caso a opção seja 2, então listar os produtos cadastrados

                        for (var i = 0; i < contador; i++)//estrutura de repetição do tipo for para listar todos os produtos
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;//altera a cor do texto a partir daqui
                            Console.WriteLine($"Produto: {descricao[i]}");//exibição da mensagem
                            Console.WriteLine($"Preço: {preco[i]}");//exibição da mensagem
                            Console.WriteLine($"Promoção: {promocao[i]}");//exibição da mensagem
                        }

                        Console.WriteLine("--------------------");//exibição da mensagem
                        Console.ResetColor();//encerra a alteração da cor

                    break;//encerrar

                    case 3: //caso a opção for 3, então sair do menu de opções
                        Console.WriteLine("---Fim---");//exibição da mensagem
                    break;//encerrar

                    default://caso a opção não seja nenhuma do menu,então exibir opção inválida
                        Console.WriteLine("Opção inválida");//exibição da mensagem
                    break;//encerrar 

                }   
                
            }while(escolha !=3);//fechamento da condicional do-while------enquanto a escolha for diferente de 0,então voltar para o início do menu

    
        }
    }
}

// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:

// - string Nome
// - float Preco
// - bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funçoes:

// - CadastrarProduto
// - ListarProdutos
// - MostrarMenu


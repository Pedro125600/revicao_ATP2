using System;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Remover Livro");
            Console.WriteLine("3. Exibir Livros Disponíveis");
            Console.WriteLine("4. Adicionar Cliente");
            Console.WriteLine("5. Remover Cliente");
            Console.WriteLine("6. Exibir Clientes");
            Console.WriteLine("7. Emprestar Livro");
            Console.WriteLine("8. Devolver Livro");
            Console.WriteLine("9. Exibir Informações de um Livro");
            Console.WriteLine("10. Exibir Informações de um Cliente");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o título do livro: ");
                    string tituloAdicionar = Console.ReadLine();
                    Console.Write("Digite o autor do livro: ");
                    string autorAdicionar = Console.ReadLine();
                    Console.Write("Digite o ano de publicação: ");
                    int anoAdicionar = int.Parse(Console.ReadLine());
                    Console.Write("Digite o número de páginas: ");
                    int paginasAdicionar = int.Parse(Console.ReadLine());
                    Livro livroAdicionar = new Livro(tituloAdicionar, autorAdicionar, anoAdicionar, paginasAdicionar);
                    biblioteca.AdicionarLivro(livroAdicionar);
                    break;

                case "2":
                    Console.Write("Digite o título do livro a ser removido: ");
                    string tituloRemover = Console.ReadLine();
                    Livro livroRemover = biblioteca.EncontrarLivro(tituloRemover);
                    if (livroRemover != null)
                    {
                        biblioteca.RemoverLivro(livroRemover);
                    }
                    else
                    {
                        Console.WriteLine($"Livro '{tituloRemover}' não encontrado.");
                    }
                    break;

                case "3":
                    biblioteca.ExibirLivrosDisponiveis();
                    break;

                case "4":
                    Console.Write("Digite o nome do cliente: ");
                    string nomeCliente = Console.ReadLine();
                    Console.Write("Digite o número de identificação do cliente: ");
                    int numeroIdentificacao = int.Parse(Console.ReadLine());
                    Cliente clienteAdicionar = new Cliente(nomeCliente, numeroIdentificacao);
                    biblioteca.RegistrarCliente(clienteAdicionar);
                    break;

                case "5":
                    Console.Write("Digite o número de identificação do cliente a ser removido: ");
                    int numeroRemover = int.Parse(Console.ReadLine());
                    Cliente clienteRemover = biblioteca.EncontrarCliente(numeroRemover);
                    if (clienteRemover != null)
                    {
                        biblioteca.RemoverCliente(clienteRemover);
                    }
                    else
                    {
                        Console.WriteLine($"Cliente com ID '{numeroRemover}' não encontrado.");
                    }
                    break;

                case "6":
                    biblioteca.ExibirClientes();
                    break;

                case "7": 
                    Console.Write("Digite o número de identificação do cliente: ");
                    int idClienteEmprestar = int.Parse(Console.ReadLine());
                    Cliente clienteEmprestar = biblioteca.EncontrarCliente(idClienteEmprestar);

                    if (clienteEmprestar != null)
                    {
                        Console.Write("Digite o título do livro a ser emprestado: ");
                        string tituloEmprestar = Console.ReadLine();
                        Livro livroEmprestar = biblioteca.EncontrarLivro(tituloEmprestar);

                        if (livroEmprestar != null)
                        {
                            clienteEmprestar.EmprestarLivro(livroEmprestar);
                        }
                        else
                        {
                            Console.WriteLine($"Livro '{tituloEmprestar}' não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Cliente com ID '{idClienteEmprestar}' não encontrado.");
                    }
                    break;

                case "8":
                    Console.Write("Digite o número de identificação do cliente: ");
                    int idClienteDevolver = int.Parse(Console.ReadLine());
                    Cliente clienteDevolver = biblioteca.EncontrarCliente(idClienteDevolver);

                    if (clienteDevolver != null)
                    {
                        Console.Write("Digite o título do livro a ser devolvido: ");
                        string tituloDevolver = Console.ReadLine();
                        Livro livroDevolver = biblioteca.EncontrarLivro(tituloDevolver);

                        if (livroDevolver != null)
                        {
                            clienteDevolver.DevolverLivro(livroDevolver);
                        }
                        else
                        {
                            Console.WriteLine($"Livro '{tituloDevolver}' não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Cliente com ID '{idClienteDevolver}' não encontrado.");
                    }
                    break;

                case "9":
                    Console.Write("Digite o título do livro: ");
                    string tituloInfo = Console.ReadLine();
                    Livro livroInfo = biblioteca.EncontrarLivro(tituloInfo);

                    if (livroInfo != null)
                    {
                        livroInfo.ExibirInformacoes();
                    }
                    else
                    {
                        Console.WriteLine($"Livro '{tituloInfo}' não encontrado.");
                    }
                    break;

                case "10": 
                    Console.Write("Digite o número de identificação do cliente: ");
                    int idClienteInfo = int.Parse(Console.ReadLine());
                    Cliente clienteInfo = biblioteca.EncontrarCliente(idClienteInfo);

                    if (clienteInfo != null)
                    {
                        clienteInfo.ExibirInformacoes();
                    }
                    else
                    {
                        Console.WriteLine($"Cliente com ID '{idClienteInfo}' não encontrado.");
                    }
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.ReadLine();
            Console.Clear();
        }
    }


public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public int NumeroPaginas { get; set; }
    public bool Disponivel { get; set; }

    public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        NumeroPaginas = numeroPaginas;
        Disponivel = true;
    }

    public void AlterarStatusParaEmprestado()
    {
        Disponivel = false;
    }

    public void AlterarStatusParaDisponivel()
    {
        Disponivel = true;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
        Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        Console.WriteLine($"Status: {(Disponivel ? "Disponível" : "Emprestado")}");
    }
}

public class Cliente
{
    public string Nome { get; set; }
    public int NumeroIdentificacao { get; set; }
    private Livro[] livrosEmprestados;
    private int quantidadeLivrosEmprestados;

    public Cliente(string nome, int numeroIdentificacao)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        livrosEmprestados = new Livro[5];
        quantidadeLivrosEmprestados = 0;
    }

    public void EmprestarLivro(Livro livro)
    {
        if (livro.Disponivel)
        {
            livro.AlterarStatusParaEmprestado();
            if (quantidadeLivrosEmprestados < livrosEmprestados.Length)
            {
                livrosEmprestados[quantidadeLivrosEmprestados] = livro;
                quantidadeLivrosEmprestados++;
                Console.WriteLine($"Livro '{livro.Titulo}' emprestado a {Nome}.");
            }
            else
            {
                Console.WriteLine($"{Nome} já tem o número máximo de livros emprestados.");
            }
        }
        else
        {
            Console.WriteLine($"Livro '{livro.Titulo}' não está disponível.");
        }
    }

    public void DevolverLivro(Livro livro)
    {
        for (int i = 0; i < quantidadeLivrosEmprestados; i++)
        {
            if (livrosEmprestados[i] == livro)
            {
                livro.AlterarStatusParaDisponivel();
                livrosEmprestados[i] = livrosEmprestados[quantidadeLivrosEmprestados - 1];
                livrosEmprestados[quantidadeLivrosEmprestados - 1] = null;
                quantidadeLivrosEmprestados--;
                Console.WriteLine($"Livro '{livro.Titulo}' devolvido por {Nome}.");
            }
        }
        Console.WriteLine($"Livro '{livro.Titulo}' não está emprestado para {Nome}.");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Número de Identificação: {NumeroIdentificacao}");
        Console.WriteLine("Livros Emprestados:");
        if (quantidadeLivrosEmprestados > 0)
        {
            for (int i = 0; i < quantidadeLivrosEmprestados; i++)
            {
                Console.WriteLine($"{livrosEmprestados[i].Titulo}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum livro emprestado.");
        }
    }
}

public class Biblioteca
{
    private Livro[] livros;
    private Cliente[] clientes;
    private int quantidadeLivros;
    private int quantidadeClientes;
    


    public Biblioteca()
    {
        livros = new Livro[5];
        clientes = new Cliente[5];
        quantidadeLivros = 0;
        quantidadeClientes = 0;
    }

    public void AdicionarLivro(Livro livro)
    {
        if (quantidadeLivros < livros.Length)
        {
            livros[quantidadeLivros] = livro;
            quantidadeLivros++;
            Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
        }
        else
        {
            Console.WriteLine("Não é possível adicionar mais livros. A biblioteca está cheia.");
        }
    }

    public void RemoverLivro(Livro livro)
    {
        for (int i = 0; i < quantidadeLivros; i++)
        {
            if (livros[i] == livro)
            {
                livros[i] = livros[quantidadeLivros - 1];
                livros[quantidadeLivros - 1] = null;
                quantidadeLivros--;
                Console.WriteLine($"Livro '{livro.Titulo}' removido da biblioteca.");
            }
        }
        Console.WriteLine($"Livro '{livro.Titulo}' não encontrado na biblioteca.");
    }

    public void RegistrarCliente(Cliente cliente)
    {
        if (quantidadeClientes < clientes.Length)
        {
            clientes[quantidadeClientes] = cliente;
            quantidadeClientes++;
            Console.WriteLine($"Cliente '{cliente.Nome}' registrado na biblioteca.");
        }
        else
        {
            Console.WriteLine("Não é possível registrar mais clientes. A biblioteca está cheia.");
        }
    }

    public void RemoverCliente(Cliente cliente)
    {
        for (int i = 0; i < quantidadeClientes; i++)
        {
            if (clientes[i] == cliente)
            {
                clientes[i] = clientes[quantidadeClientes - 1];
                clientes[quantidadeClientes - 1] = null;
                quantidadeClientes--;
                Console.WriteLine($"Cliente '{cliente.Nome}' removido da biblioteca.");
            }
        }
        Console.WriteLine($"Cliente '{cliente.Nome}' não encontrado na biblioteca.");
    }

    public void ExibirLivrosDisponiveis()
    {
        Console.WriteLine("Livros Disponíveis:");
        bool encontrouLivroDisponivel = false;
        for (int i = 0; i < quantidadeLivros; i++)
        {
            if (livros[i].Disponivel)
            {
                Console.WriteLine($"{livros[i].Titulo}");
                encontrouLivroDisponivel = true;
            }
        }
        if (!encontrouLivroDisponivel)
        {
            Console.WriteLine("Nenhum livro disponível.");
        }
    }

    public void ExibirClientes()
    {
        Console.WriteLine("Clientes Registrados:");
        if (quantidadeClientes > 0)
        {
            for (int i = 0; i < quantidadeClientes; i++)
            {
                Console.WriteLine($"{clientes[i].Nome} (ID: {clientes[i].NumeroIdentificacao})");
            }
        }
        else
        {
            Console.WriteLine("Nenhum cliente registrado.");
        }
    }

    public Livro EncontrarLivro(string titulo)
    {
        for (int i = 0; i < quantidadeLivros; i++)
        {
            if (livros[i].Titulo ==  titulo)
            {
                return livros[i];
            }
        }
        return null;
    }

    public Cliente EncontrarCliente(int numeroIdentificacao)
    {
        for (int i = 0; i < quantidadeClientes; i++)
        {
            if (clientes[i].NumeroIdentificacao == numeroIdentificacao)
            {
                return clientes[i];
            }
        }
        return null;
    }
}


    }


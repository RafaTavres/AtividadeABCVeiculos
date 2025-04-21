using ABCVeiculosLib;
internal class Program
{

// Cadastrar ou listas os dados da revenda
// Adicionar veículos
// Listar todos os dados da revenda e de seus veículos. 
// Listar somente um tipo especifico de veiculo, por exemplo, motocicleta. • Etc.
    public static Revenda RevendaAtual;
    Program()
    {
        RevendaAtual = new Revenda("S", "123123", new Endereco(), "12312323");
        string? opcao = null;
        do{
            opcao = MenuInicial(opcao);
        }while(opcao.Equals("N", StringComparison.CurrentCultureIgnoreCase));
    }

    // public void CriarRevenda(){
    //     try{
    //         Console.WriteLine("Titulo do livro:");
    //         string titulo = Console.ReadLine();
    //         Console.WriteLine("SubTitulo do livro:");
    //         string subTitulo = Console.ReadLine();
    //         Console.WriteLine("Escritor do livro:");
    //         string escritor = Console.ReadLine();
    //         Console.WriteLine("Editora do livro:");
    //         string editora = Console.ReadLine();
    //         Console.WriteLine("Genero do livro:");
    //         string genero = Console.ReadLine();
    //         Console.WriteLine("AnoPublicacao do livro:");
    //         DateTime anoPublicacao = Convert.ToDateTime(Console.ReadLine());
    //         Console.WriteLine("TipoDaCapa do livro:");
    //         string tipoDaCapa = Console.ReadLine();
    //         Console.WriteLine("NumeroDePaginas do livro:");
    //         int numeroDePaginas = Convert.ToInt32(Console.ReadLine());

    //         Livro livro = new Livro(
    //             titulo, 
    //             subTitulo, 
    //             escritor, 
    //             editora, 
    //             genero, 
    //             anoPublicacao, 
    //             tipoDaCapa, 
    //             numeroDePaginas
    //         );
    //         Livros.Add(livro);
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //         Console.WriteLine("Deseja tentar novamente?: S/N ");
    //         string resposta = Console.ReadLine() ?? "";
    //         if(resposta.Equals("S",StringComparison.CurrentCultureIgnoreCase))
    //             CriarLivro();
    //         if(resposta.Equals("N",StringComparison.CurrentCultureIgnoreCase))
    //             return;
    //         else
    //         {
    //             Console.WriteLine("resposta invalida, precione qualquer tecla para retornar");
    //             Console.ReadKey();
    //         }
    //     }

    //     Console.Clear();       
    //     // Console.Clear();
    // }
    // public Livro BuscarLivro(string tituloBusca = null){
    //     // Console.Clear();
    //     Console.WriteLine("======================");
    //     Console.WriteLine("Título do livro que deseja buscar");
    //     if(tituloBusca == null){
    //         tituloBusca = Console.ReadLine();
    //         Livro livroBusca = Livros.Find(x => x.Titulo == tituloBusca);
    //         Leitor leitorBuscado = Leitores.Find(x => x.LivrosDoLeitor.Contains(livroBusca));

    //         // Console.Clear();
    //         Console.WriteLine("======================");
    //         Console.WriteLine($"Titulo: {livroBusca.Titulo}");
    //         Console.WriteLine($"Subtitulo: {livroBusca.Subtitulo}");
    //         Console.WriteLine($"Escritor: {livroBusca.Escritor}");
    //         Console.WriteLine($"Editora: {livroBusca.Editora}");
    //         Console.WriteLine($"Genero: {livroBusca.Genero}");
    //         Console.WriteLine($"Ano da publicação: {livroBusca.AnoPublicacao}");
    //         Console.WriteLine($"Tipo de capa: {livroBusca.TipoDaCapa}");
    //         Console.WriteLine($"Número de páginas: {livroBusca.NumeroDePaginas}");
    //         Console.WriteLine("---------------------");

    //         if(leitorBuscado != null){
    //             Console.WriteLine("Leitor atual:");
    //             Console.WriteLine("---------------------");
    //             Console.WriteLine($"Nome: {leitorBuscado.Nome}");
    //             Console.WriteLine($"Idade: {leitorBuscado.Idade}");
    //             Console.WriteLine($"CPF: {leitorBuscado.CPF}");
    //             Console.WriteLine("---------------------");
    //         }
    //         return livroBusca;
    //     }
    //     else{
    //         Livro livroBusca = Livros.Find(x => x.Titulo == tituloBusca);
    //         Console.Clear();
    //         Console.WriteLine("======================");
    //         Console.WriteLine($"Titulo: {livroBusca.Titulo}");
    //         Console.WriteLine($"Subtitulo: {livroBusca.Subtitulo}");
    //         Console.WriteLine($"Escritor: {livroBusca.Escritor}");
    //         Console.WriteLine($"Editora: {livroBusca.Editora}");
    //         Console.WriteLine($"Genero: {livroBusca.Genero}");
    //         Console.WriteLine($"Ano da publicação: {livroBusca.AnoPublicacao}");
    //         Console.WriteLine($"Tipo de capa: {livroBusca.TipoDaCapa}");
    //         Console.WriteLine($"Número de páginas: {livroBusca.NumeroDePaginas}");
    //         return livroBusca;
    //     }
    // }
    // public void ListarTodosLivros(){
    //     Console.Clear();
    //     foreach(var livro in Livros)
    //     {
    //         Console.WriteLine("======================");
    //         Console.WriteLine($"Titulo: {livro.Titulo}");
    //         Console.WriteLine($"Escritor: {livro.Escritor}");
    //         Console.WriteLine($"Ano da publicação: {livro.AnoPublicacao}");
    //     }
    //     Console.WriteLine($"Clique qualquer tecla para continuar");
    //     Console.ReadKey();
    // }
    // public void ExcluirLivro(){
    //     Console.Clear();
    //     Console.WriteLine("======================");
    //     Console.WriteLine("Título do livro que deseja excluir");
    //     string tituloExclusao = Console.ReadLine();
    //     Livro LivroExclusao = BuscarLivro(tituloExclusao);
    //     Livros.Remove(LivroExclusao);
    //     Console.WriteLine("Livro excluído com sucesso");
    //     Console.WriteLine("Clique qualquer tecla para continuar");
    //     Console.ReadKey();
    // }
    // public void EditarLivro(){
    //     Console.Clear();
    //     Console.WriteLine("======================");
    //     Console.WriteLine("Título do livro que deseja editar");
    //     string tituloEditar = Console.ReadLine();
    //     Livro livroEditar = BuscarLivro(tituloEditar);
    //     Console.WriteLine("-------------------------");

    //     Console.WriteLine("Titulo do livro:");
    //     string titulo = Console.ReadLine();
    //     Console.WriteLine("SubTitulo do livro:");
    //     string subTitulo = Console.ReadLine();
    //     Console.WriteLine("Escritor do livro:");
    //     string escritor = Console.ReadLine();
    //     Console.WriteLine("Editora do livro:");
    //     string editora = Console.ReadLine();
    //     Console.WriteLine("Genero do livro:");
    //     string genero = Console.ReadLine();
    //     Console.WriteLine("AnoPublicacao do livro:");
    //     DateTime anoPublicacao = Convert.ToDateTime(Console.ReadLine());
    //     Console.WriteLine("TipoDaCapa do livro:");
    //     string tipoDaCapa = Console.ReadLine();
    //     Console.WriteLine("NumeroDePaginas do livro:");
    //     int numeroDePaginas = Convert.ToInt32(Console.ReadLine());

    //     livroEditar.Titulo = titulo;
    //     livroEditar.Subtitulo = subTitulo;
    //     livroEditar.Escritor = escritor;
    //     livroEditar.Editora = editora;
    //     livroEditar.Genero = genero;
    //     livroEditar.AnoPublicacao = anoPublicacao;
    //     livroEditar.TipoDaCapa = tipoDaCapa;
    //     livroEditar.NumeroDePaginas = numeroDePaginas;

    //     Console.WriteLine("Livro editado com sucesso");
    //     Console.WriteLine("Clique qualquer tecla para continuar");
    //     Console.ReadKey();
    // }
   
    // CRUD
    public string? MenuInicial(string? opcao){
        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine("     |ABCVeiculos|");
        Console.WriteLine("Escolha a opção que deseja informar:");
        Console.WriteLine("1 - Cadastrar ou editar revenda");
        Console.WriteLine("2 - Adicionar veículo");
        Console.WriteLine("3 - Listar todos os dados da revenda e de seus veículos");
        Console.WriteLine("4 - Listar veiculos por tipo");
        Console.WriteLine("S- Sair");
        opcao = Console.ReadLine();
        if(VerificarOpcaoValida(opcao))
        {
            switch(opcao.ToUpper())
            {
                case "1":
                    CadastrarRevenda();
                    break;
                case "2":
                    AdicionarVeiculo();
                    break;
                case "3":
                    ListarDadosRevendaEVeiculos();
                    break;
                case "4":
                    ListarVeiculosPorTipo();
                    break;
                case "S":
                    return opcao = "S";
                    break;
                default:
                    break;
            }
        }
        else{
            Console.WriteLine("Opção inválida. Tente novamente.");
        }
        return opcao = "N";
    }

    public void CadastrarRevenda()
    {
        try
        {
            Console.WriteLine("=== CADASTRO DE REVENDA ===");
            Console.Write("Nome responsável: ");
            string nome = Console.ReadLine();
            Console.Write("CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("\n=== ENDEREÇO DA REVENDA ===");
            Console.Write("Rua: ");
            string rua = Console.ReadLine();
            Console.Write("Número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();
            Console.Write("Estado (UF): ");
            string estado = Console.ReadLine();
            Console.Write("CEP: ");
            string cep = Console.ReadLine();
            Endereco enderecoRevenda = new Endereco(rua,numero,bairro,cidade,estado,cep);
            RevendaAtual = new Revenda(nome, cnpj, enderecoRevenda, telefone);
            Console.WriteLine("\nRevenda cadastrada com sucesso!");
            Console.WriteLine(RevendaAtual.ToString());
        }catch(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            Console.WriteLine("Deseja tentar novamente? (S/N)");
            string resposta = Console.ReadLine() ?? "";
            if(VerificarTentarNovamente(resposta) && resposta.Equals("S", StringComparison.CurrentCultureIgnoreCase))
            {
                CadastrarRevenda();
            }
            else if(resposta.Equals("N", StringComparison.CurrentCultureIgnoreCase))
            {
                return;
            }
        }
    }
    public void ListarDadosRevendaEVeiculos()
    {
        try
        {
            if(RevendaAtual == null)
            {
                Console.WriteLine("Revenda não cadastrada. Por favor, cadastre uma revenda primeiro.");
                Console.WriteLine("Clique qualquer tecla para continuar");
                Console.ReadKey();
                return;
            }
            Console.Clear();
            Console.WriteLine("======================");
            Console.WriteLine("Dados da revenda:");
            Console.WriteLine(RevendaAtual.ToString());
            Console.WriteLine("======================");
            Console.WriteLine("Veículos da revenda:");
            if(RevendaAtual.VeiculosDaRevenda.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado na revenda.");
                Console.WriteLine("Clique qualquer tecla para continuar");
            }
            foreach(var veiculo in RevendaAtual.VeiculosDaRevenda)
            {
                Console.WriteLine(veiculo.ToString());
            }
            Console.WriteLine("======================");
            Console.WriteLine("Clique qualquer tecla para continuar");
            Console.ReadKey();
        }catch(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            Console.WriteLine("Clique qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
    public void AdicionarVeiculo()
    {
        try
        {
            if(RevendaAtual == null)
            {
                Console.WriteLine("Revenda não cadastrada. Por favor, cadastre uma revenda primeiro.");
                Console.WriteLine("Clique qualquer tecla para continuar");
                Console.ReadKey();
                return;
            }

            Veiculo novoVeiculo;
            Console.WriteLine("=== CADASTRO DE VEÍCULO ===");
            Console.Write("Tipo do veículo: ");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Utilitário");
            Console.WriteLine("3 - Caminhonete");
            Console.WriteLine("4 - Caminhão");
            string tipoVeiculo = Console.ReadLine();
            if(!VerificarTipoCarroValido(tipoVeiculo))
            {
                Console.WriteLine("Tipo de veículo inválido. Tente novamente.");
                return;
            }else
            {
                Veiculo veiculo = CriarVeiculo(tipoVeiculo);
                RevendaAtual.VeiculosDaRevenda.Add(veiculo);
            }
        }catch(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            Console.WriteLine("Clique qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
    public Veiculo CriarVeiculo(string tipoVeiculo)
    {
        Veiculo veiculo = null;
        int id = RevendaAtual.VeiculosDaRevenda.Count + 1;
        Console.WriteLine("=== CADASTRO DE VEÍCULO ===");
        Console.Write("Marca: ");
        string marca = Console.ReadLine();
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Ano: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        Console.Write("Preço: ");
        decimal preco = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Cor: ");
        string cor = Console.ReadLine();
        switch(tipoVeiculo)
        {
            case "1":
                
                break;
            case "2":
                Console.Write("Capacidade de passageiros: ");
                int capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(capacidadePassageiros))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Capacidade de passageiros: ");
                    capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                }
                string respostaAdaptadoParaPCD;
                bool ehAdaptadoParaPCD = false;
                do{
                    Console.Write("Cabine dupla? S/N: ");
                    respostaAdaptadoParaPCD = Console.ReadLine();
                    if(respostaAdaptadoParaPCD.ToUpper() != "S" && respostaAdaptadoParaPCD.ToUpper() != "N")
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }else{
                        ehAdaptadoParaPCD = respostaAdaptadoParaPCD.ToUpper() == "S" ? true : false;
                    }
                }while(respostaAdaptadoParaPCD.ToUpper() != "S" && respostaAdaptadoParaPCD.ToUpper() != "N");
                
                Console.Write("Tipo de uso: ");
                string tipoUso = Console.ReadLine();
                veiculo = new Utilitario(id,marca,modelo,ano,preco,cor,capacidadePassageiros,tipoUso,ehAdaptadoParaPCD);
                break;
            case "3":
                Console.Write("Peso de carga: ");
                decimal pesoCarga = Convert.ToDecimal(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(pesoCarga))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Peso de carga: ");
                    pesoCarga = Convert.ToDecimal(Console.ReadLine());
                }
                Console.Write("Tipo de carga: ");
                string tipoCarga = Console.ReadLine();
                string cabineDupla;
                bool temCabineDupla = false;
                do{
                    Console.Write("Cabine dupla? S/N: ");
                    cabineDupla = Console.ReadLine();
                    if(cabineDupla.ToUpper() != "S" && cabineDupla.ToUpper() != "N")
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }else{
                        temCabineDupla = cabineDupla.ToUpper() == "S" ? true : false;
                    }
                }while(cabineDupla.ToUpper() != "S" && cabineDupla.ToUpper() != "N");
                string tracao4x4;
                bool temTracao4x4 = false;
                do{
                    Console.Write("Tração 4x4? S/N: ");
                    tracao4x4 = Console.ReadLine();
                    if(tracao4x4.ToUpper() != "S" && tracao4x4.ToUpper() != "N")
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }else{
                        temTracao4x4 = tracao4x4.ToUpper() == "S" ? true : false;
                    }
                }while(tracao4x4.ToUpper() != "S" && tracao4x4.ToUpper() != "N");
                Console.Write("Tipo de suspensão: ");
                string tipoSuspensao = Console.ReadLine();
                veiculo = new Caminhonete(id,marca,modelo,ano,preco,cor,pesoCarga,tipoCarga,temCabineDupla,temTracao4x4,tipoSuspensao);
                break;
            case "4":
                
                break;
            default:
                Console.WriteLine("Tipo de veículo inválido. Tente novamente.");
                break;
        }

        return veiculo;
    }
    
    public void ListarVeiculosPorTipo()
    {
        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine("Escolha o tipo de veículo que deseja listar:");
        Console.WriteLine("1 - Carro");
        Console.WriteLine("2 - Utilitário");
        Console.WriteLine("3 - Caminhonete");
        Console.WriteLine("4 - Caminhão");
        Console.WriteLine("6 - Motocicleta");
        string tipoVeiculo = Console.ReadLine();
        if(!VerificarTipoCarroValido(tipoVeiculo))
        {
            Console.WriteLine("Tipo de veículo inválido. Tente novamente.");
            return;
        }
        else
        {
            string opcaoSelecionada = "";
            switch (tipoVeiculo)
            {
                case "1":
                    opcaoSelecionada = "Carro";
                    break;
                case "2":
                    opcaoSelecionada = "Utilitario";
                    break;
                case "3":
                    opcaoSelecionada = "Caminhonete";
                    break;
                case "4":
                    opcaoSelecionada = "Caminhão";
                    break;
                case "6":
                    opcaoSelecionada = "Motocicleta";
                    break;
                default:
                    opcaoSelecionada = "";
                    break;
            }
            try{
                foreach(var veiculo in RevendaAtual.VeiculosDaRevenda)
                {
                    if(veiculo.TipoVeiculo.Equals(opcaoSelecionada))
                    {
                        Console.WriteLine(veiculo.ToString());
                    }
                }
                Console.WriteLine("Clique qualquer tecla para continuar");
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.WriteLine("Clique qualquer tecla para continuar");
                Console.ReadKey();
            }
        }
    }
    // Verificacoes
    public bool VerificarOpcaoValida(string? opcao)
    {
        if(string.IsNullOrEmpty(opcao) || opcao.GetType() != typeof(string))
        {
            return false;
        }
        if(opcao.Equals("1", StringComparison.CurrentCultureIgnoreCase) 
        || opcao.Equals("2", StringComparison.CurrentCultureIgnoreCase)
        || opcao.Equals("3", StringComparison.CurrentCultureIgnoreCase)
        || opcao.Equals("4", StringComparison.CurrentCultureIgnoreCase)
        || opcao.Equals("6", StringComparison.CurrentCultureIgnoreCase)
        || opcao.Equals("S", StringComparison.CurrentCultureIgnoreCase))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool VerificarTentarNovamente(string? resposta)
    {
        if(string.IsNullOrEmpty(resposta) || resposta.GetType() != typeof(string))
        {
            return false;
        }
        if(resposta.Equals("S", StringComparison.CurrentCultureIgnoreCase) || resposta.Equals("N", StringComparison.CurrentCultureIgnoreCase))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool VerificarTipoCarroValido(string opcao)
    {
        if(string.IsNullOrEmpty(opcao) || opcao.GetType() != typeof(string))
        {
            return false;
        }
        if(opcao.Equals("1", StringComparison.CurrentCultureIgnoreCase) 
        || opcao.Equals("2", StringComparison.CurrentCultureIgnoreCase)
        || opcao.Equals("3", StringComparison.CurrentCultureIgnoreCase)
        || opcao.Equals("4", StringComparison.CurrentCultureIgnoreCase)
        || opcao.Equals("6", StringComparison.CurrentCultureIgnoreCase))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool VerificarSerRespostaEhNumero(decimal resposta)
    {
        if(resposta.GetType() != typeof(decimal) || resposta.GetType() != typeof(int))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    
    
    
    private static void Main(string[] args)
    {
        _ = new Program();
    }
}
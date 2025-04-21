using ABCVeiculosLib;
using System.Linq;
internal class Program
{
    public static Revenda RevendaAtual;
    Program()
    {
        RevendaAtual = new Revenda("S", "123123", new Endereco(), "12312323");
        string? opcao = null;
        do{
            opcao = MenuInicial(opcao);
        }while(opcao.Equals("N", StringComparison.CurrentCultureIgnoreCase));
    }

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
        Console.WriteLine("5 - Editar dados de um veículo");
        Console.WriteLine("6 - Excluir um veículo");
        Console.WriteLine("S - Sair");
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
                case "5":
                    EditarVeiculo();
                    break;
                case "6":
                    ExcluirVeiculo();
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

    public void ExcluirVeiculo()
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
            for(int i = 0; i < RevendaAtual.VeiculosDaRevenda.Count; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"ID: [{i + 1}] - {RevendaAtual.VeiculosDaRevenda[i].ToString()}");
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("Escolha o ID do veículo que deseja excluir:");
            int opcao = Convert.ToInt32(Console.ReadLine()) - 1;
            if(opcao < 0 || opcao >= RevendaAtual.VeiculosDaRevenda.Count)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                return;
            }
            Veiculo veiculoSelecionado = RevendaAtual.VeiculosDaRevenda[opcao];
            try
            {
                Console.WriteLine("=== EXCLUSÃO DE VEÍCULO ===");
                Console.WriteLine($"Você tem certeza que deseja excluir o veículo? (S/N)");
                Console.WriteLine($"{veiculoSelecionado.ToString()}? (S/N)");
                string resposta = Console.ReadLine() ?? "";
                if(resposta.Equals("S", StringComparison.CurrentCultureIgnoreCase))
                {
                    RevendaAtual.VeiculosDaRevenda.Remove(veiculoSelecionado);
                    Console.WriteLine("Veículo excluído com sucesso!");
                }else if(resposta.Equals("N", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Exclusão cancelada.");
                    Console.WriteLine("Clique qualquer tecla para continuar");
                    Console.ReadKey();
                }else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine("Clique qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.WriteLine("Clique qualquer tecla para continuar");
                Console.ReadKey();
            }
        }catch(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            Console.WriteLine("Clique qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
    public void EditarVeiculo()
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
            for(int i = 0; i < RevendaAtual.VeiculosDaRevenda.Count; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"ID: [{i + 1}] - {RevendaAtual.VeiculosDaRevenda[i].ToString()}");
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("Escolha o ID do veículo que deseja editar:");
            int opcao = Convert.ToInt32(Console.ReadLine()) - 1;
            if(opcao < 0 || opcao >= RevendaAtual.VeiculosDaRevenda.Count)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                return;
            }
            Veiculo veiculoSelecionado = RevendaAtual.VeiculosDaRevenda[opcao];
            try
            {
                Console.WriteLine("=== EDIÇÃO DE VEÍCULO ===");
                Console.WriteLine("Novo tipo do veículo: ");
                Console.WriteLine("1 - Automóvel");
                Console.WriteLine("2 - Utilitário");
                Console.WriteLine("3 - Caminhonete");
                Console.WriteLine("4 - Caminhão");
                Console.WriteLine("5 - Bicicleta");
                Console.WriteLine("6 - Motocicleta");
                string tipoVeiculo = Console.ReadLine();
                if(!VerificarTipoCarroValido(tipoVeiculo))
                {
                    Console.WriteLine("Tipo de veículo inválido. Tente novamente.");
                    return;
                }else
                {   Veiculo veiculo = CriarVeiculo(tipoVeiculo);
                    var veiculoExistente = RevendaAtual.VeiculosDaRevenda.Find(x => x.Id == veiculoSelecionado.Id);
                    if (veiculoExistente != null)
                    {
                        CopiarPropriedades(veiculo, veiculoExistente);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.WriteLine("Clique qualquer tecla para continuar");
                Console.ReadKey();
            }
        }catch(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            Console.WriteLine("Clique qualquer tecla para continuar");
            Console.ReadKey();
        }
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
            Console.WriteLine("Tipo do veículo: ");
            Console.WriteLine("1 - Automóvel");
            Console.WriteLine("2 - Utilitário");
            Console.WriteLine("3 - Caminhonete");
            Console.WriteLine("4 - Caminhão");
            Console.WriteLine("5 - Bicicleta");
            Console.WriteLine("6 - Motocicleta");
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
                Console.Write("Tipo de carroceria: ");
                string tipoCarroceria = Console.ReadLine();
                Console.Write("Quantidade de portas: ");
                int qtdPortas = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(qtdPortas))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Quantidade de portas: ");
                    qtdPortas = Convert.ToInt32(Console.ReadLine());
                }
                string eletrico;
                bool ehEletrico = false;
                do{
                    Console.Write("É elétrico? S/N: ");
                    eletrico = Console.ReadLine();
                    if(eletrico.ToUpper() != "S" && eletrico.ToUpper() != "N")
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }else{
                        ehEletrico = eletrico.ToUpper() == "S" ? true : false;
                    }
                }while(eletrico.ToUpper() != "S" && eletrico.ToUpper() != "N");
                Console.Write("Capacidade do porta-malas: ");
                int capacidadePortaMalas = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(capacidadePortaMalas))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Capacidade do porta-malas: ");
                    capacidadePortaMalas = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Cavalos: ");
                int cavalos = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(cavalos))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Cavalos: ");
                    cavalos = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Capacidade de passageiros: ");
                int capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(capacidadePassageiros))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Capacidade de passageiros: ");
                    capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                }
                veiculo = new Automovel(id,marca,modelo, ano, preco,cor,tipoCarroceria,
                qtdPortas, ehEletrico, capacidadePortaMalas, cavalos, capacidadePassageiros);
                break;
                break;
            case "2":
                Console.Write("Capacidade de passageiros: ");
                capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
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
                Console.Write("Peso de carga: ");
                pesoCarga = Convert.ToDecimal(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(pesoCarga))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Peso de carga: ");
                    pesoCarga = Convert.ToDecimal(Console.ReadLine());
                }
                Console.Write("Tipo de carga: ");
                tipoCarga = Console.ReadLine();
                Console.Write("Número de eixos: ");
                int numeroEixos = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(numeroEixos))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Número de eixos: ");
                    numeroEixos = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Capacidade de combustível: ");
                decimal capacidadeCombustivel = Convert.ToDecimal(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(capacidadeCombustivel))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Capacidade de combustível: ");
                    capacidadeCombustivel = Convert.ToDecimal(Console.ReadLine());
                }
                Console.Write("Tipo de carroceria: ");
                tipoCarroceria = Console.ReadLine();
                Console.Write("Potência do motor: ");
                int potenciaMotor = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(potenciaMotor))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Potência do motor: ");
                    potenciaMotor = Convert.ToInt32(Console.ReadLine());
                }
                string dormitorio;
                bool temDormitorio = false;
                do{
                    Console.Write("Dormitório? S/N: ");
                    dormitorio = Console.ReadLine();
                    if(dormitorio.ToUpper() != "S" && dormitorio.ToUpper() != "N")
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }else{
                        temDormitorio = dormitorio.ToUpper() == "S" ? true : false;
                    }
                }while(dormitorio.ToUpper() != "S" && dormitorio.ToUpper() != "N");
                Console.Write("Quantidade de eixos: ");
                veiculo = new Caminhao(id,marca, modelo, ano, preco, cor, pesoCarga, tipoCarga, 
                numeroEixos, capacidadeCombustivel, tipoCarroceria, potenciaMotor,  
                temDormitorio);
                break;
            case "5":
                Console.Write("Tipo de Material: ");
                string tipoMaterial = Console.ReadLine();

                Console.Write("Tipo de Freio: ");
                string tipoFreio = Console.ReadLine();

                Console.Write("Capacidade de passageiros: ");
                capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(capacidadePassageiros))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Capacidade de passageiros: ");
                    capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                }

                veiculo = new Bicicleta(id, marca, modelo, ano, preco, cor, capacidadePassageiros, tipoMaterial, tipoFreio);
                break;
            case "6":
                Console.Write("Tipo Moto: ");
                string tipoMoto = Console.ReadLine();

                Console.Write("Potência CC: ");
                int cilindradas = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(cilindradas))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Potência CC: ");
                    cilindradas = Convert.ToInt32(Console.ReadLine());
                }

                string cortaVento;
                bool TemCortaVento = false;
                do{
                    Console.Write("Possui Corta-Vento? S/N: ");
                    cortaVento = Console.ReadLine();
                    if(cortaVento.ToUpper() != "S" && cortaVento.ToUpper() != "N")
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }else{
                        TemCortaVento = cortaVento.ToUpper() == "S" ? true : false;
                    }
                }while(cortaVento.ToUpper() != "S" && cortaVento.ToUpper() != "N");

                Console.Write("Capacidade de passageiros: ");
                capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                while(!VerificarSerRespostaEhNumero(capacidadePassageiros))
                {
                    Console.Write("Digite um número válido");
                    Console.Write("Capacidade de passageiros: ");
                    capacidadePassageiros = Convert.ToInt32(Console.ReadLine());
                }
                veiculo = new Motocicleta(id, marca, modelo, ano, preco, cor, capacidadePassageiros, tipoMoto, cilindradas, cortaVento);
                break;

        }

        return veiculo;
    }
    
    public void ListarVeiculosPorTipo()
    {
        Console.Clear();
        Console.WriteLine("======================");
        Console.WriteLine("Escolha o tipo de veículo que deseja listar:");
        Console.WriteLine("1 - Automóvel");
        Console.WriteLine("2 - Utilitário");
        Console.WriteLine("3 - Caminhonete");
        Console.WriteLine("4 - Caminhão");
        Console.WriteLine("5 - Bicicleta");
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
                    opcaoSelecionada = "Automóvel";
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
                case "5":
                    opcaoSelecionada = "Bicicleta";
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
        || opcao.Equals("5", StringComparison.CurrentCultureIgnoreCase)
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
        || opcao.Equals("5", StringComparison.CurrentCultureIgnoreCase)
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
    
    
    public void CopiarPropriedades<T>(T origem, T destino)
    {
        var propriedades = typeof(T).GetProperties();

        foreach (var prop in propriedades)
        {
            if (prop.CanRead && prop.CanWrite)
            {
                var valor = prop.GetValue(origem, null);
                prop.SetValue(destino, valor, null);
            }
        }
    }
    
    private static void Main(string[] args)
    {
        _ = new Program();
    }
}
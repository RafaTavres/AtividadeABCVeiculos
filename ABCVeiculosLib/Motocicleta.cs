namespace ABCVeiculosLib;

//Alan
//Alisson
//Osmar
//Rafael

// Herança: Motocicleta herda de DePassageiros, o que permite reutilizar propriedades e comportamentos comuns a veículos de passageiros.
public class Motocicleta : DePassageiros
{
    private string cortaVento;

    public string TipoMoto {get; set;}
    public int Cilindradas {get; set;}
    public bool CortaVento {get; set;}
    public override string TipoVeiculo => "Motocicleta";

    public Motocicleta (int id, string marca, string modelo, int ano, decimal preco, string cor,
    string tipoMoto, int cilindradas, bool cortaVento, int capacidadePassageiros) 
    : base(id, marca, modelo, ano, preco, cor, capacidadePassageiros)
    {
        TipoMoto = tipoMoto;
        Cilindradas = cilindradas;
        CortaVento = cortaVento;
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preco = preco;
        Cor = cor;
        Vendido = false;
        CapacidadePassageiros = capacidadePassageiros;
    }

    public Motocicleta(int id, string marca, string modelo, int ano, decimal preco, string cor, int capacidadePassageiros, string? tipoMoto, int cilindradas, string cortaVento) : base(id, marca, modelo, ano, preco, cor, capacidadePassageiros)
    {
        TipoMoto = tipoMoto;
        Cilindradas = cilindradas;
        this.cortaVento = cortaVento;
    }

    public override string ToString()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Tipo: {TipoVeiculo}, Ano: {Ano}, Preço: R${Preco}, Cor: {Cor}, " +
        $"Tipo: {TipoMoto}, Potência: {Cilindradas}CC, Corta-Vento: {CortaVento}, Passageiros: {CapacidadePassageiros}, Vendido: {Vendido}";    
    }
}

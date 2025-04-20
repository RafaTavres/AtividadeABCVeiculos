namespace ABCVeiculosLib;

public class Motocicleta : DePassageiros
{
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
    public override string ToString()
    {
        return $"{Marca}, {Modelo}, {TipoVeiculo}";    
    }
}

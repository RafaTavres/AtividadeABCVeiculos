namespace ABCVeiculosLib;

public abstract class Bicicleta : DePassageiros
{
    public string TipoMaterial {get; set;}
    public string TipoFreio {get; set;}
    public Bicicleta(int id, string marca, string modelo, int ano, decimal preco, string cor, int capacidadePassageiros, int quantidadeRodas, string tipoMaterial, string tipoFreio) :
    base(id, marca, modelo,ano, preco, cor, capacidadePassageiros, quantidadeRodas)
    {
        TipoFreio = tipoFreio;
        TipoMaterial = tipoMaterial;
        QuantidadeRodas = quantidadeRodas;
        CapacidadePassageiros = capacidadePassageiros;  
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preco = preco;
        Cor = cor;
        Vendido = false;
    }
    public override string ToString()
    {
        return $"{Marca}, {Modelo} {TipoVeiculo}";
    }
}
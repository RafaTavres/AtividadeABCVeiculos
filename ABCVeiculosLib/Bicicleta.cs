namespace ABCVeiculosLib;

//Alan
//Alisson
//Osmar
//Rafael

public class Bicicleta : DePassageiros 
{
    public string TipoMaterial {get; set;}
    public string TipoFreio {get; set;}

    // Polimorfismo: sobrescreve a propriedade abstrata ou virtual da classe base para retornar o tipo específico do veículo.
    public override string TipoVeiculo => "Bicicleta";

    public Bicicleta(int id, string marca, string modelo, int ano, decimal preco, string cor, int capacidadePassageiros, string tipoMaterial, string tipoFreio) :
    base(id, marca, modelo,ano, preco, cor, capacidadePassageiros)
    {
        TipoFreio = tipoFreio;
        TipoMaterial = tipoMaterial;
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
        return $"Marca: {Marca}, Modelo: {Modelo}, Tipo: {TipoVeiculo}, Tipo de Freio: {TipoFreio}, Tipo de Material: {TipoMaterial}, Ano: {Ano}, Cor: {Cor} Preço: {Preco}, Vendido: {Vendido}";
    }
}
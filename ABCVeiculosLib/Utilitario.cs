namespace ABCVeiculosLib;

//Alan
//Alisson
//Osmar
//Rafael

public class Utilitario : DeMisto
{
    public string TipoUso {get; set;}
    public bool AdaptadoParaPCD {get; set;}
    public override string TipoVeiculo => "Utilitario";
    public Utilitario(int id, string marca, string modelo, int ano, decimal preco, string cor, int capacidadePassageiros, string tipoUso, bool adptadoParaPCD) :
    base(id, marca, modelo,ano, preco, cor, capacidadePassageiros)
    {
        TipoUso = tipoUso;
        AdaptadoParaPCD = adptadoParaPCD;
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
        return $"Marca: {Marca}, Modelo: {Modelo}, Tipo: {TipoVeiculo}, Ano: {Ano}, Preço: R${Preco}, Cor: {Cor}, " +
        $"Tipo de uso: {TipoUso}, É adaptado para PCD: {AdaptadoParaPCD}, " +
        $"Vendido: {Vendido}";
    }
}
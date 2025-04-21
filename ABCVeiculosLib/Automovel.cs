using System.Dynamic;

namespace ABCVeiculosLib;

public class Automovel : DePassageiros
{
    public string TipoCarroceria {get; set;}
    public int QtdPortas {get; set;}
    public bool Eletrico {get; set;}
    public int CapacidadePortaMalas {get; set;}
    public int Cavalos {get; set;}

    public override string TipoVeiculo => "Automóvel";

    public Automovel (int id, string marca, string modelo, int ano, decimal preco, string cor, string tipoCarroceria,
    int qtdPortas, bool eletrico, int capacidadePortaMalas, int cavalos, int capacidadePassageiros) 
    : base(id, marca, modelo, ano, preco, cor, capacidadePassageiros) 
    {
        TipoCarroceria = tipoCarroceria;
        QtdPortas = qtdPortas;
        Eletrico = eletrico;
        CapacidadePortaMalas = capacidadePortaMalas;
        Cavalos = cavalos;
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
        return $"{Marca}, {Modelo}, {TipoVeiculo}";
    }
}
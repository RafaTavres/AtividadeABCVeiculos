using System.Dynamic;

namespace ABCVeiculosLib;

public class Automovel : DePassageiros
{
    public string TipoCarroceria {get; set;}
    public string QtdPortas {get; set;}
    public bool Eletrico {get; set;}
    public int CapacidadePortaMalas {get; set;}
    public int Cavalos {get; set;}

    public override string TipoVeiculo => "Automóvel";

    public Automovel (int id, string marca, string modelo, int ano, decimal preco, string cor, /*...herança DePassageiros...,*/ string tipoCarroceria,
    string qtdPortas, bool eletrico, int capacidadePortaMalas, int cavalos) 
    : base(id, marca, modelo, ano, preco, cor, /*...herança DePassageiros...,*/)
    
    {
        TipoCarroceria = tipoCarroceria;
        QtdPortas = qtdPortas;
        Eletrico = eletrico;
        CapacidadePortaMalas = capacidadePortaMalas;
        Cavalos = cavalos;
        /*...herança DePassageiros...,*/
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preco = preco;
        Cor = cor;
        Vendido = false; 
    }
    public override string ToString(string TipoCarroceria, int QtdPortas, bool Eletrico, int CapacidadePortaMalas,)
    {
        return $"{Marca}, {Modelo}, {TipoVeiculo}";    
    }
}
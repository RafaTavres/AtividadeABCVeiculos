namespace ABCVeiculosLib;

public class Caminhao : DeCarga
{
    public int NumeroEixos { get; set;}
    public decimal CapacidadeCombustivel {get; set;}
    public string TipoCarroceria { get; set;}
    public int PotenciaMotor {get; set;}
    public bool Dormitorio {get; set;}
    public override string TipoVeiculo => "Caminhao";
    public int QuantidadeEixos {get; set;}
    public Caminhao(int id, string marca, string modelo, int ano, decimal preco, string cor, decimal pesoCarga, string tipoCarga, 
    int numeroEixos, decimal capacidadeCombustivel, string tipoCarroceria, int potenciaMotor, bool dormitorio, int quantidadeEixos) :
    base(id, marca, modelo,ano, preco, cor, pesoCarga, tipoCarga)
    {
        NumeroEixos = NumeroEixos;
        CapacidadeCombustivel = capacidadeCombustivel;
        TipoCarroceria = tipoCarroceria;
        TipoCarroceria = tipoCarroceria;
        PotenciaMotor = potenciaMotor;
        Dormitorio = dormitorio;
        PesoCarga = pesoCarga;
        TipoCarga = tipoCarga;
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preco = preco;
        Cor = cor;
        Vendido = false;
        QuantidadeEixos = quantidadeEixos;
    }
    public override string ToString()
    {
        return $"{Marca}, {Modelo} {TipoVeiculo}";
    }
}
namespace ABCVeiculosLib;

public class Motocicleta : DePassageiros
{
    public string TipoMoto {get; set;}
    public int Cilindradas {get; set;}
    public bool CortaVento {get; set;}
    
    public override string TipoVeiculo => "Motocicleta";

    public Motocicleta (int id, string marca, string modelo, int ano, decimal preco, string cor, /*...herança DePassageiros...,*/
    string tipoMoto, int cilindradas, bool cortaVento) 
    : base(id, marca, modelo, ano, preco, cor, /*...herança DePassageiros...,*/)

    {
        TipoMoto = tipoMoto;
        Cilindradas = cilindradas;
        CortaVento = cortaVento;
        /*...herança DePassageiros...,*/
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

namespace ABCVeiculosLib;

public class Caminhonete : DeCarga
{
    public int CapacidadePassageiros {get; set;}
    public bool CabineDupla {get; set;}
    public bool Tracao4x4 {get; set;}
    public string TipoSuspensao {get; set;}

    public override string TipoVeiculo => "Caminhonete";

    public Caminhonete(int id, string marca, string modelo, int ano, decimal preco, string cor, decimal pesoCarga, string tipoCarga, 
    int capacidadePassageiros, bool cabineDupla, bool tracao4x4, string tipoSuspensao) :
    base(id, marca, modelo,ano, preco, cor, pesoCarga, tipoCarga)
    {
        CapacidadePassageiros = capacidadePassageiros;
        CabineDupla = cabineDupla;
        Tracao4x4 = tracao4x4;
        TipoSuspensao = tipoSuspensao;
        PesoCarga = pesoCarga;
        TipoCarga = tipoCarga;
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
namespace ABCVeiculosLib;

//Alan
//Alisson
//Osmar
//Rafael

public class Caminhonete : DeCarga
{
    public bool CabineDupla {get; set;}
    public bool Tracao4x4 {get; set;}
    public string TipoSuspensao {get; set;}

    public override string TipoVeiculo => "Caminhonete";

    public Caminhonete(int id, string marca, string modelo, int ano, decimal preco, string cor, decimal pesoCarga, string tipoCarga,
    bool cabineDupla, bool tracao4x4, string tipoSuspensao) : base(id, marca, modelo,ano, preco, cor, pesoCarga, tipoCarga)
    {
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
        return $"Marca: {Marca}, Modelo: {Modelo}, Tipo: {TipoVeiculo}, Ano: {Ano}, Preço: R${Preco}, Cor: {Cor}, " +
        $"Tipo de carga: {TipoCarga}, Tipo de suspensao: {TipoSuspensao}, Tem cabine dupla: {CabineDupla}, " +
        $"Tem tracao4x4: {Tracao4x4}CV, Vendido: {Vendido}";
    }
}
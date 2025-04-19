namespace ABCVeiculosLib;

public abstract class DeCarga : Veiculo
{
    public decimal PesoCarga { get; set;}
    public string TipoCarga { get; set;}

    public DeCarga(int id, string marca, string modelo, int ano, decimal preco, string cor, decimal pesoCarga, string tipoCarga) :
    base(id, marca, modelo,ano, preco, cor)
    {
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
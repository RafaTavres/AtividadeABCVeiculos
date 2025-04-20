namespace ABCVeiculosLib;

public abstract class DeMisto : Veiculo
{
    public int CapacidadePassageiros {get; set;}
    public override string TipoVeiculo => "DeMisto";
    public DeMisto(int id, string marca, string modelo, int ano, decimal preco, string cor, int capacidadePassageiros) :
    base(id, marca, modelo,ano, preco, cor)
    {
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
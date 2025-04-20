namespace ABCVeiculosLib;

public abstract class DePassageiros : Veiculo
{
    public int CapacidadePassageiros {get; set;}
    public int QuantidadeRodas {get; set;}
    public DePassageiros(int id, string marca, string modelo, int ano, decimal preco, string cor, int capacidadePassageiros, int quantidadeRodas) :
    base(id, marca, modelo,ano, preco, cor)
    {
        QuantidadeRodas = quantidadeRodas;
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
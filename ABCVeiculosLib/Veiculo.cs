namespace ABCVeiculosLib;

//Alan
//Alisson
//Osmar
//Rafael

public abstract class Veiculo
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public decimal Preco { get; set; }
    public string Cor { get; set; }
    public bool Vendido { get; protected set; }
    public int IdadeVeiculo => DateTime.Now.Year - Ano;
    public abstract string TipoVeiculo { get; }
    public override string ToString()
    {
        return $"Marca: {Marca},Modelo: {Modelo},Tipo: {this.GetType().Name}";
    }
    
    public Veiculo(int id, string marca, string modelo, int ano, decimal preco, string cor)
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preco = preco;
        Cor = cor;
        Vendido = false;
    }
}
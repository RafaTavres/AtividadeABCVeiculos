namespace ABCVeiculosLib;
public class Revenda
{
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public Endereco Endereço { get; set; }
    public string Telefone { get; set; }
    public List<Veiculo> VeiculosDaRevenda { get; set; } = new List<Veiculo>();
    public override string ToString()
    {
        return $"Nome: {Nome},CNPJ: {CNPJ},Endereço: {Endereço.ToString()},Telefone {Telefone}";
    }

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        VeiculosDaRevenda.Add(veiculo);
    }
    public Revenda(string nome, string cnpj, Endereco endereco, string telefone)
    {
        Nome = nome;
        CNPJ = cnpj;
        Endereço = endereco;
        Telefone = telefone;
    }
}
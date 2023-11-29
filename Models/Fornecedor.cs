namespace LHpet.Models;


public class Fornecedor  //Criando a classe publica chamada Cliente
{
    public int Id {get; set; }
    public string? Nome { get; set; }
    public string? Cnpj { get; set; }
    public string? Email { get; set; }
  

    public Fornecedor(int id, string nome, string cnpj, string email) //Criando uma instancia
    {
        this.Id = id; //Estou falando que o Id da linha 5 é o mesmo da instancia que criei
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Email = email;

    }
}
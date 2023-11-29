namespace LHpet.Models;


public class Cliente  //Criando a classe publica chamada Cliente
{
    public int Id {get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

    public Cliente(int id, string nome, string cpf, string email, string paciente) //Criando uma instancia
    {
        this.Id = id; //Estou falando que o Id da linha 5 é o mesmo da instancia que criei
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;

    }
}
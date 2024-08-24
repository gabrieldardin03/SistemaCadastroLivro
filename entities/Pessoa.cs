public abstract class Pessoa :IPessoa
{
	public string Nome { get; set; }
	public string CPF { get;set;}
	
	public Pessoa (string Nome,string CPF)
	
	{Nome = nome;
	CPF = cpf;}
	
	public abstract void ObterIdentificação();
}
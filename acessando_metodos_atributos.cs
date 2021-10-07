public class Pessoa{
    public int Idade;
    public string Nome;

    //método sem argumento e sem retorno
    public void Andar();
    //método com argumento do tipo Comida e sem retorno
    public void Comer(Comida comida);

    //método construtor não possui nome e nem retorno
    public Pessoa(int idade,string nome){
        Idade = idade;
        Nome = nome;
    }
}

//cria um objeto Pessoa
Pessoa pessoa = new Pessoa(25,"Wallace");
//copia a idade da pessoa para a variável minhaIdade
int minhaIdade = pessoa.Idade;
//copia o nome da pessoa para a variável meuNome
string meuNome = pessoa.Nome;
pessoa.Andar();
//chama o método Comer passando um novo objeto Comida como argumento
pessoa.Comer(new Comida());
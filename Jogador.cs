class Jogador
{
    Random random = new Random(); // random
    public string nome; //nome do jogador
    public string nickname; //apelido do jogador
    public int pontos; // pontos do jogador
    public void Jogar() // método para gerar um número aleatório
    {
        pontos = random.Next(1,101); //uso do random
    }
}
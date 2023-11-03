class Equipe
{
    public string nomeEquipe; // nome das equipes
    public Jogador j1 = new Jogador(); //criação dos jogadores
    public Jogador j2 = new Jogador();
    public Jogador j3 = new Jogador();
    public Jogador j4 = new Jogador();
    public Jogador j5 = new Jogador();

    public int PontosTotal() // método para soma dos pontos da equipe
    {
        return j1.pontos + j2.pontos + j3.pontos + j4.pontos + j5.pontos;
    }
    public void AdicionarJogador(Jogador jogador) // verifica a disponibilidade do jogador
    {
        if (j1 == null)
        {
            j1 = jogador;
        }
        else if (j2 == null)
        {
            j2 = jogador;
        }
        else if (j3 == null)
        {
            j3 = jogador;
        }
        else if (j4 == null)
        {
            j4 = jogador;
        }
        else if (j5 == null)
        {
            j5 = jogador;
        }
        
    }
}
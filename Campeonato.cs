class Campeonato
{
    public string nomeCampeonato; // nome do campeonato
    public Equipe equipe1 = new(); // criação das equipes
    public Equipe equipe2 = new();

    public void IniciarPartida(Equipe e1, Equipe e2) //metodo para a iniciar a partida
    {
        e1.j1.Jogar(); //jogadas
        e1.j2.Jogar();
        e1.j3.Jogar();
        e1.j4.Jogar();
        e1.j5.Jogar();

        e2.j1.Jogar();
        e2.j2.Jogar();
        e2.j3.Jogar();
        e2.j4.Jogar();
        e2.j5.Jogar();
    }
    public void Classificacao() // exbibição do vencedor
    {
        if (equipe1.PontosTotal() > equipe2.PontosTotal()) // condição para os resultados
        {
            Console.WriteLine("\n--------------------------------------------------------"); // estilização
            Console.WriteLine("  Equipe dos Terroristas foi a grande vencedora"); // estilização
            Console.WriteLine("--------------------------------------------------------"); // estilização
            Console.WriteLine(""); // estilização
        }
        else if (equipe1.PontosTotal() < equipe2.PontosTotal()) // condição para os resultados
        {
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("  Equipe dos Contra-Terroristas foi a grande vencedora");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");
        }
        else // condição para os resultados
        {
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("                         Empate");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
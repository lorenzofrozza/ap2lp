do // looping para gerar novos campeonatos
{
    Console.Clear(); // limpa o console

    Campeonato p1 = new(); //instanciando um objeto campeonato

    Console.Write("\nNome do Campeonato: "); //estilização
    p1.nomeCampeonato = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"\n -- {p1.nomeCampeonato} --");
    Equipe e1 = new(); //instanciando um objeto equipe
    Console.Write("\nNome da equipe dos Terroristas: "); //estilização
    e1.nomeEquipe = Console.ReadLine();

    Jogador j1 = new(); //instanciando um objeto jogador
    Console.Write("\nNome do 1° jogador: "); //estilização
    j1.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: "); //estilização
    j1.nickname = Console.ReadLine();
    e1.AdicionarJogador(j1); // chama o metodo e adiciona o jogador a equipe

    Jogador j2 = new();
    Console.Write("\nNome do 2° jogador: ");
    j2.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j2.nickname = Console.ReadLine();
    e1.AdicionarJogador(j2);

    Jogador j3 = new();
    Console.Write("\nNome do 3° jogador: ");
    j3.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j3.nickname = Console.ReadLine();
    e1.AdicionarJogador(j3);

    Jogador j4 = new();
    Console.Write("\nNome do 4° jogador: ");
    j4.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j4.nickname = Console.ReadLine();
    e1.AdicionarJogador(j4);

    Jogador j5 = new();
    Console.Write("\nNome do 5° jogador: ");
    j5.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j5.nickname = Console.ReadLine();
    e1.AdicionarJogador(j5);

    p1.equipe1= e1; // atribui todos resultados da equipe1

    Equipe e2 = new();
    Console.Write("\nNome da equipe dos Contra-Terroristas: ");
    e2.nomeEquipe = Console.ReadLine();

    Console.Write("\nNome do 1° jogador: ");
    j1.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j1.nickname = Console.ReadLine();
    e2.AdicionarJogador(j1);

    Console.Write("\nNome do 2° jogador: ");
    j2.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j2.nickname = Console.ReadLine();
    e2.AdicionarJogador(j2);

    Console.Write("\nNome do 3° jogador: ");
    j3.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j3.nickname = Console.ReadLine();
    e2.AdicionarJogador(j3);

    Console.Write("\nNome do 4° jogador: ");
    j4.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j4.nickname = Console.ReadLine();
    e2.AdicionarJogador(j4);

    Console.Write("\nNome do 5° jogador: ");
    j5.nome = Console.ReadLine();
    Console.Write("Digite seu nickname: ");
    j5.nickname = Console.ReadLine();
    e2.AdicionarJogador(j5);

    p1.equipe2 = e2; // atribui todos resultados da equipe2


    p1.IniciarPartida(e1, e2); //inicia a partida entre as equipes

    int pontuacao1 = p1.equipe1.PontosTotal(); // chama o metodo para fazer a soma de todos os resultados
    Console.Write($"\nPontuação total dos Terroristas    -- {e1.nomeEquipe} --\n --------> "); //estilização
    Console.WriteLine(pontuacao1); //exibe pontuação total na tela


    int pontuacao2 = p1.equipe2.PontosTotal();
    Console.Write($"\nPontuação total dos Contra-Terroristas   -- {e2.nomeEquipe} --\n --------> ");
    Console.WriteLine(pontuacao2);


    p1.Classificacao(); // exibe a mensagem do vencedor

    Console.WriteLine("");
    Console.WriteLine("\n- Digite 1 para gerar um novo campeonato - \n- Digite 0 para sair - ");//menu para geração de novos campeonatos
    Console.Write(" \n --> "); 
} while (Console.ReadLine() == "1"); //condição do looping
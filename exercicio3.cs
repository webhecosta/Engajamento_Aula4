using System;

public class MainClass
{ 
    public static void GeraCandidatos() {
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     33 - José Couve      |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     25 - Joana Bravo     |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     10 - Roberto Nove    |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     0 - Voto branco      |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     4 - Voto nulo        |");
      Console.WriteLine("|--------------------------|");
    }

    public static void Apuracao(int VotosJC,int VotosJB,int VotosRN,int VotosVB,int VotosVN) {
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|---------Resultado--------|");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     "+VotosJC+" - José Couve       |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     "+VotosJB+" - Joana Bravo      |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     "+VotosRN+" - Roberto Nove     |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     "+VotosVB+" - Votos branco     |");
      Console.WriteLine("|--------------------------|");
      Console.WriteLine("|     "+VotosVN+" - Votos nulos      |");
      Console.WriteLine("|--------------------------|");
      if (VotosJC > VotosJB && VotosJC > VotosRN) {
        Console.WriteLine("O vencedor foi: José Couve");
      } else if (VotosJB > VotosJC && VotosJB > VotosRN) {
        Console.WriteLine("O vencedor foi: Joana Bravo");
      } else if (VotosRN > VotosJC && VotosRN > VotosJB) {
        Console.WriteLine("O vencedor foi: Roberto Nove");
      } else {
        Console.WriteLine("Não houve um vencedor!");
      }
    }

    public static void Votacao() {
      string resposta = "s";
      string opcao;
      int VotosJC = 0;
      int VotosJB = 0;
      int VotosRN = 0;
      int VotosVB = 0;
      int VotosVN = 0;

      while (resposta == "s") {
        Console.WriteLine("Digite 's' para votar ou outra tecla para gerar a apuração:");
        resposta = Console.ReadLine();

        if (resposta != "s") {
          Apuracao(VotosJC,VotosJB,VotosRN,VotosVB,VotosVN);
          break;
        };

        GeraCandidatos();
        Console.WriteLine("Digite a opção desejada: ");
        opcao = Console.ReadLine();

        switch(opcao) {
          case "33":
            VotosJC++;
            break;
          case "25":
            VotosJB++;
            break;
          case "10":
            VotosRN++;
            break;
          case "0":
            VotosVB++;
            break;
          case "4":
            VotosVN++;
            break;
        }
      };
    }
    public static void Main()
    {
      Votacao();
    }
}
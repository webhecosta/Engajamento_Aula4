using System;

public class MainClass
{ 
    public static void GeraCardapio() {
      Console.WriteLine("------------------------------------");
      Console.WriteLine("100 | Cachorro quente | R$ 1,70");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("101 | Bauru Simples   | R$ 2,30");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("102 | Bauru com ovo   | R$ 2,60");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("103 | Hamburguer      | R$ 2,40");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("104 | Cheeseburguer   | R$ 2,50");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("105 | Refrigerante    | R$ 1,00");
      Console.WriteLine("------------------------------------");
    }

    public static double Calcula(string item,int quantidade) {
      double valor = 0;
      switch (item) {
        case "100":
          valor = 1.7;
          break;
        case "101":
          valor =  2.3;
          break;
        case "102":
          valor =  2.6;
          break;
        case "103":
          valor =  2.4;
          break;
        case "104":
          valor =  2.5;
          break;
        case "105":
          valor =  1.0;
          break;
      };
      return ((double)valor*quantidade);
    }

    public static void Consumindo() {
      string resposta = "s";
      string item;
      double total = 0.0;
      int quantidade = 0;

      while (resposta == "s") {
        Console.WriteLine("Digite s para escolher um item ou qualquer outra tecla para sair:");
        resposta = Console.ReadLine();

        if (resposta != "s") {
          break;
        } 

        Console.WriteLine("Digite o código do item gostaria de pedir:");
        item = Console.ReadLine();
        Console.WriteLine("Digite a quantidade desejada:");
        quantidade = int.Parse(Console.ReadLine());
        total = total + Calcula(item,quantidade);
        Console.WriteLine("----------------------------");
        Console.WriteLine("Total atual da compra: R$" + total);
        Console.WriteLine("----------------------------");
      };
    }
    public static void Main()
    {
      GeraCardapio();
      Consumindo();
    }
}
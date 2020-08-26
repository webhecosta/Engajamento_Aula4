using System;

class Calculadora {

  public static double mult (int num1, int num2) {
    return num1 * num2;
  }
  public static int adicao (int num1,int num2) {
    return num1 + num2;
  }
  public static int subtracao (int num1,int num2) {
    return num1 + num2;
  }
  public static double divisao (int num1,int num2) {
    return ((double)num1 / num2);
  }

  public static void calc () {

  int num1 = 0;
  int num2 = 0;
  string operador;
  double resultado = 0;

    Console.WriteLine("Digite um número inteiro");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um número inteiro");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Que operação deseja realizar?");
    operador = Console.ReadLine();

    switch (operador) {
      case "/":
        resultado = divisao(num1,num2);
        break;
      case "*":
        resultado = mult(num1,num2);
        break;
      case "+":
        resultado = adicao(num1,num2);
        break;
      case "-":
        resultado = subtracao(num1,num2);
        break;
      default:
        Console.WriteLine("Opção inválida!");
        break;
    };

    Console.WriteLine("O resultado é:" + resultado);
  }

  public static void Main () {
    calc();
  }
}
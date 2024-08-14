// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Olá, Mundo!");

int a = 10;
int b = 5;
int r = a+b;
//Console.WriteLine("Resultado: "+r);
Console.WriteLine($"Resultado:{r}");
//string str = "Texto qualquer";

Console.WriteLine("Informe a primeira nota:");
var nota1 = Console.ReadLine();
Console.WriteLine("Informe a segunda nota:");
var nota2 = Console.ReadLine();
var resultadoNota = Convert.ToDouble(nota1)+Convert.ToDouble(nota2); 
Console.WriteLine($"Valor da nota 1: {nota1}");
Console.WriteLine($"Valor da nota 2: {nota2}");
Console.WriteLine(resultadoNota);
//Console.WriteLine(str);
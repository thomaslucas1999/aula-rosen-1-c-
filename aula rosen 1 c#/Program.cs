
using System.Xml.Serialization;
using aula_rosen_1_c_;

int num1 = 20;
int num2 = 11, result;

somador soma;
soma = new somador();

result = soma.Soma(num1, num2);

Console.WriteLine(result);

// Conversor conversor = new Conversor ()

//altera a saida para que exiba:
//A soma dos números ____ + ____ é ____

result = soma.Soma($"A soma dos números {num1} + {num2} é {result}");

Console.WriteLine(result);
//altera a saida para que exiba:
//a medida _____ metros corresponde a ____ milimetros 

Console.WriteLine("A madida {0} metros corresponde a {1}",metros, Conversor.MetrosMilimetros(1.76)) ;

using System.Globalization;

var valor1 = int.Parse("123");
var valor2 =  bool.Parse("true");
var valor3 = DateTime.Parse("28/01/2022");

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);


var culture = new CultureInfo("pt-BR");
var valor4 = DateTime.Parse("28/10/2022");

Console.WriteLine(valor4);

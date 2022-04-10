// See https://aka.ms/new-console-template for more information

using ConsoleApp.Infra.ExtensionMethods;
using Data;

var noticiaService = new NoticiaService();
Console.WriteLine($"Total de noticias: {noticiaService.Noticias().TotalNoticias()}");
Console.WriteLine($"Total de noticias: {noticiaService.Noticias().Count()}");

foreach (var item in noticiaService.Noticias().TituloComPrimeiraLetraMaiscula())
{
    Console.WriteLine($"Titulo: {item.Titulo}, Descricao {item.Descricao}");

}

Console.ReadLine();


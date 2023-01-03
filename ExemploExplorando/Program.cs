using ExemploExplorando.Models;
using System.Globalization;


try
{
    string[] lines = File.ReadAllLines("Arquivos/file_Reading.txt");

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
} catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
}













// // --------------------------------------------------------------------------------

// string dateString = "2022-12-17 18:00";


// bool sucesso = DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm", 
//                     CultureInfo.InvariantCulture,
//                     DateTimeStyles.None, 
//                     out DateTime date);

// if ( sucesso )
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {date}");
// }
// else
// {
//     Console.WriteLine($"{dateString} não é uma data válida");
// }

// // --------------------------------------------------------------------------------

// Console.WriteLine(data.ToShortDateString());

// // --------------------------------------------------------------------------------

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal monetaryValue = 1582.40M;

// Console.WriteLine(monetaryValue.ToString("C2"));

// double percentage = .3421;

// Console.WriteLine(percentage.ToString("P"));

// int number = 123456;
// int number2 = 19062005;
// Console.WriteLine(number.ToString("##-##-##"));
// Console.WriteLine(number2.ToString("##/##/####"));

// // --------------------------------------------------------------------------------

// string numero1 = "10";
// string numero2 = "20";

// --------------------------------------------------------------------------------

//string resultado = numero1 + numero2;

// int resultado = Convert.ToInt16(numero1) + Convert.ToInt16(numero2);

// Console.WriteLine(resultado);

// --------------------------------------------------------------------------------

// Pessoa p1 = new Pessoa(nome: "Mateus", sobrenome: "Santos");
// Pessoa p2 = new Pessoa(nome: "Matias", sobrenome: "Santana");

// Curso cursoDeIngles = new Curso();
//     cursoDeIngles.Nome = "Inglês";
//     cursoDeIngles.Alunos = new List<Pessoa>();

//     cursoDeIngles.AdicionarAluno(p1);
//     cursoDeIngles.AdicionarAluno(p2);
//     cursoDeIngles.ListarAlunos();

// p1.Nome = "Mateus";
// p1.Sobrenome = "Santana";
// p1.Idade = 17;

// p1.Apresentar();
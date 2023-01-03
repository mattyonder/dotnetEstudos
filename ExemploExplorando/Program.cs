using ExemploExplorando.Models;

string numero1 = "10";
string numero2 = "20";

//string resultado = numero1 + numero2;

int resultado = Convert.ToInt16(numero1) + Convert.ToInt16(numero2);


Console.WriteLine(resultado);


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
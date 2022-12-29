using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Mateus", sobrenome: "Santos");
Pessoa p2 = new Pessoa(nome: "Matias", sobrenome: "Santana");

Curso cursoDeIngles = new Curso();
    cursoDeIngles.Nome = "Inglês";
    cursoDeIngles.Alunos = new List<Pessoa>();

    cursoDeIngles.AdicionarAluno(p1);
    cursoDeIngles.AdicionarAluno(p2);
    cursoDeIngles.ListarAlunos();

// p1.Nome = "Mateus";
// p1.Sobrenome = "Santana";
// p1.Idade = 17;

// p1.Apresentar();
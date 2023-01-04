using ExemploExplorando.Models;
using System.Globalization;

// // --------------------------------------------------------------------------------

// O Dictionary armazena dados e uma chave, essa que deve ser unica, lembra muito o conceito de orientação a objeto, de classe e objeto
// Tudo que eu faço no dicionario é por meio de sua chave 

Dictionary<string, string> states = new Dictionary<string, string>();

states.Add("SE", "Sergipe");
states.Add("BA", "Bahia");
states.Add("MG", "Minas Gerais");

Console.WriteLine(states["MG"]);

// foreach(KeyValuePair<string, string> item in states) Outra Sintaxe
// foreach(var item in states)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// states.Remove("BA");
// states["SE"] = "Sergipe - valor alterado";

// Console.WriteLine("-----------------------------");

// foreach(var item in states)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string key = "BA2";
// Console.WriteLine($"Verificando o elemento: {key}");

// if (states.ContainsKey(key))
// {
//     Console.WriteLine($"Valor existente: {key}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {key}");
// }

// // --------------------------------------------------------------------------------

//  O Stack funciona ao contrario da pilha, voce adiciona elementos como uma pilha mesmo, e o ultimo elemento dela que vai ser tratado em vez do primeiro
// LIFO - LAST IN FIRST OUT

// Stack<int> stack = new Stack<int>();

// stack.Push(4);
// stack.Push(6);
// stack.Push(8);
// stack.Push(10);

// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {stack.Pop()}");

// stack.Push(20);

// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }

// // --------------------------------------------------------------------------------

// O Queue funciona como uma fila, ele vai tratar o primeiro componente dela como prioridade
// FIFO - FIRST IN FIRST OUT

// Queue<int> queue = new Queue<int>();

// queue.Enqueue(2);
// queue.Enqueue(4);
// queue.Enqueue(6);
// queue.Enqueue(8);

// foreach(int item in queue)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {queue.Dequeue()}");
// queue.Enqueue(10);

// foreach(int item in queue)
// {
//     Console.WriteLine(item);
// }

// // --------------------------------------------------------------------------------

// new ExemploExecao().Metodo1();

// // --------------------------------------------------------------------------------

// try
// {
//     string[] lines = File.ReadAllLines("Arquivos/fileReading.txt");

//     foreach (string line in lines)
//     {
//         Console.WriteLine(line);
//     }
// }
// // Há uma ordem em que deve ser colocado os exceptions pelo visto
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado {ex.Message}");
// } 

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }

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
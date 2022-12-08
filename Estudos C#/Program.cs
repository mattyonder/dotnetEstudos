using Estudos_C_.Models;

int inteiro = 5;
string a = inteiro.ToString();
Console.WriteLine(a);
//Todos herdam por herança métodos da classe Object












// --------------------------------------------------------------------------------

// int a = 30;
// int b = 0;

// int c = a + b;
// c = c + 5; // 30 + 5
// c += 5; // É a mesma coisa de um c = c + 5
// c -= 5; // Mesma cisa que c = c - 5
// c *= 5; // Mesma coisa se aplica a outros sinais

// --------------------------------------------------------------------------------

// Cast - Casting
// int a = Convert.ToInt32("null");
// O Convert consegue lidar com valores nulos, retornando o 
// o valor 0

// Já o parse não consegue
// int a = int.Parse("A");
// Console.WriteLine(a);

// --------------------------------------------------------------------------------

// //Pega a data atual
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// --------------------------------------------------------------------------------

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// double altura = 1.70;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

//ToString no altura para fazer o valor double ser mostrado com aquela formatação escrita

// --------------------------------------------------------------------------------

/*Pessoa pessoa = new Pessoa();

pessoa.Nome = "Mateus";
pessoa.Idade = 17;
pessoa.Apresentar();

Pessoa pessoaFisica = new Pessoa();

pessoaFisica.Nome = "Teteu";
pessoaFisica.Idade = 17;
pessoaFisica.Apresentar();
*/

//Nome de variavel em camelCase 
//Sem caracter especial em classe, variavel ou propriedade
//Underline é uma exceção

// --------------------------------------------------------------------------------

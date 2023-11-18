// using ExemploExplorando.Models;
//
// Pessoa p1 = new Pessoa();
//
// p1.Nome = "Fulano";
// p1.Sobrenome = "Ciclano";
// // p1.Idade = 20;
// // p1.Apresentar();
//
// Pessoa p2 = new Pessoa();
// p2.Nome = "Taco";
// p2.Sobrenome = "Bell";
//
// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();
//
// Pessoa p3 = new Pessoa(nome: "Ronald", sobrenome: "McDonald");
//
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
//
// cursoDeIngles.ListarAlunos();
//
// double porcent = .3421;
//
// Console.WriteLine(porcent.ToString("P"));

string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}
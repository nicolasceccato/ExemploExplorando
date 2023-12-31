﻿// using ExemploExplorando.Models;
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

try
{
    string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"O arquivo nao foi encontrado. {e.Message}");
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine($"O diretório nao foi encontrado. {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu uma excecao generica. {e.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}
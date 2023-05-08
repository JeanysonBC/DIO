using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "jean",sobrenome: "campos");
Pessoa p2 = new Pessoa(nome: "jana",sobrenome: "neves sa");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



















// p1.Nome = "Jean";
// p1.Sobrenome = "Campos";
// p1.Idade = 30;
// p1.Apresentar();

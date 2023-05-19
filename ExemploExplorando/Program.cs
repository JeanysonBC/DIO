using ExemploExplorando.Models;
using System.Globalization;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MA", "Maranhão");
estados.Add("PI", "Piauí");
estados.Add("PA", "Pará");


foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("PA");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}










// Stack<int> pilha = new Stack<int>();


// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo elementos: {pilha.Pop()}");

// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }








// Queue<int> fila = new Queue<int>();

// fila.Enqueue(3);
// fila.Enqueue(5);
// fila.Enqueue(7);
// fila.Enqueue(9);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

















// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }



















// string dataString = "2023-15-30 14:50";


// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, 
//                         out DateTime data);


// if(sucesso)
// {
//     Console.WriteLine(data);    
// }else{
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1564482.40M;

// Console.WriteLine(valorMonetario.ToString("C4"));


// double porcentagem = .3245;

// Console.WriteLine(porcentagem.ToString("P"));

// long cpf = 12345678900;

// Console.WriteLine(cpf.ToString("###.###.###-##"));










// Pessoa p1 = new Pessoa(nome: "jean",sobrenome: "campos");
// Pessoa p2 = new Pessoa(nome: "jana",sobrenome: "neves sa");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



















// p1.Nome = "Jean";
// p1.Sobrenome = "Campos";
// p1.Idade = 30;
// p1.Apresentar();

using CSharp.Models;

List<string> listaString = new List<string>();

listaString.Add("Maranhão");
listaString.Add("Piauí");
listaString.Add("Pará");

for(int contador = 0; contador < listaString.Count; contador++)
{
    
    Console.WriteLine($"Posição Nº {contador} = {listaString[contador]}");
}

























// int[] arrayInteiros = new int [3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 43;
// arrayInteiros[2] = 54;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} = {arrayInteiros[contador]}");
// }

// int cont = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {cont} = {valor}");
//     cont++;
// }












// string opcao;

// while(true)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
        
//         case "3":
//             Console.WriteLine("Apagar de cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }














// Calculadora calc = new Calculadora();

// // calc.Somar(4, 6);
// // calc.Subtrair(10, 3);   
// // calc.Mutiplicar(3,40);
// // calc.Dividir(150,5);
// // calc.Potencia(9,3);

// // calc.Seno(30);
// // calc.Cosseno(30);
// // calc.Tangente(30);

// calc.RaizQuadrada(4);











// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual);   










// using CSharp.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Campos";
// pessoa1.Idade = 31;
// pessoa1.Apresentar();


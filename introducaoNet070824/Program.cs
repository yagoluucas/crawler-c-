// See https://aka.ms/new-console-template for more information
using introducaoNet070824.entities;
using System.Threading.Channels;

Console.WriteLine("Hello, World!"); // isso no java é System.out.println("Hello, World!");
var textoDigitado = Console.ReadLine(); // ler informações
Console.WriteLine(textoDigitado);


// o Write não pula linha, diferente do WriteLine
Console.Write("Top");


// tipos primittivos
var idade = 30;
var altura = 1.80;
var maiorDeIdade = true;
var nome = "Lucas";
var sexo = 'M';
var peso = 80.5f;
var salario = 1000.50m;
long populacao = 1000000000;
short quantidade = 10;
byte idadeEmMeses = 30;

// operadores
var soma = 10 + 5;
var subtracao = 10 - 5;
var multiplicacao = 10 * 5;
var divisao = 10 / 5;
var resto = 10 % 5;
var incremento = soma++;
var decremento = soma--;

// operadores de comparação
var igual = 10 == 5;
var diferente = 10 != 5;
var maior = 10 > 5;
var menor = 10 < 5;
var maiorOuIgual = 10 >= 5;
var menorOuIgual = 10 <= 5;

// operadores lógicos
var e = true && false;
var ou = true || false;
var negacao = !true;

// estruturas condicionais

if(idade >= 18)
{
    Console.WriteLine("Você é maior que 18 anos");
} else
{
    Console.WriteLine("Você é menor que 18 anos");
}

var eDeMaior = idade == 18 ? "Você é maior que 18 anos" : "Você é menor que 18 anos";


switch(idade)
{
    case >= 18:
        Console.WriteLine("É maior de idade");
        break;
    default:
        Console.WriteLine("Não é maior de idade");
        break;
}

// tipos de string

var nome2 = "Leonardo";

var textoMultiplasLinhas = """
    Uma pessoa tops
    Aqui pode escrever multiplas linhas e tals
    por causa dessas 3 aspas
""";

// usando em variáveis do tipo nula //

// bool maiorDe18Anos = null; // aqui vai á erro

bool? maiorDe18Anos = null; // aqui já não dá erro por causa do ? na frente do tipo

// usando var não funciona

// var idadeNula = null; // ele precisa antes saber o que ela é, para transformar aquela variável no tipo que ela é


// estrutura de repetição
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"interação {i}");
}

foreach(int i in Enumerable.Range(0, 10))
{
    Console.WriteLine($"interação {i}");
}


// como funciona a estrutura de um projeto .Net
// No Java temos a classe main que é o arquivo principal
// aqui, temos o arquivo Program.cs que é o arquivo principal e tambem a classe dependencies
// No c# você pode ter várias soluções no mesmo projeto, e aqui você pode organizar por pasta e o conceito de solução
// É legal ter essa estrutura de solução e projeto porque você pode fazer essa separação


// instanciando um objeto 

Produto produto = new Produto(1, "Celular");
Console.WriteLine(produto.ToString());
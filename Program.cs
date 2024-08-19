//1
int X = 10;         
float Y = 1.2f;     
string Z = "Olá";   
bool W = true;      
Console.WriteLine(X);
Console.WriteLine(Y);
Console.WriteLine(Z);
Console.WriteLine(W);
//2
Console.WriteLine("Insira dois números inteiros:");
string entrada = Console.ReadLine();
string[] valores = entrada.Split(' ');

int num1 = int.Parse(valores[0]);
int num2 = int.Parse(valores[1]);

Console.WriteLine($"A soma é: {num1 + num2}");
Console.WriteLine($"A subtração é: {num1 - num2}");
Console.WriteLine($"A divisão é: {num1 / num2}");
Console.WriteLine($"A multiplicação é: {num1 * num2}");
//3
Console.WriteLine("Informe seu nome e sua idade:");
string entrada = Console.ReadLine();
string[] dados = entrada.Split(' ');

string Nome = dados[0];
int anos = int.Parse(dados[1]);

Console.WriteLine($"Bem-vindo, {Nome}, você tem {anos} anos.");
//4
Console.WriteLine("Informe um número:");
string entrada = Console.ReadLine();
double valor = double.Parse(entrada);

if (valor > 0)
{
    Console.WriteLine("Este é um número positivo.");
}
else if (valor < 0)
{
    Console.WriteLine("Este é um número negativo.");
}
else if (valor == 0)
{
    Console.WriteLine("O número é zero.");
}
//5
for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine(contador);
}
//6
Console.WriteLine("Informe sua idade:");
double idade = double.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você está apto a votar e dirigir.");
} 
else if (idade == 16)
{
    Console.WriteLine("Você está apto a votar.");
}
else
{
    Console.WriteLine("Você não está apto a votar nem dirigir.");
}
//7
static float CalcularMedia(float nota1, float nota2, float nota3)
static float CalcularMedia(float nota1, float nota2, float nota3)
{
    float media = (nota1 + nota2 + nota3) / 3;
    return media;
}

static void Main()
{
    Console.WriteLine("Digite as três notas separadas por espaço:");

    string[] entrada = Console.ReadLine().Split(' ');
    float nota1 = float.Parse(entrada[0]);
    float nota2 = float.Parse(entrada[1]);
    float nota3 = float.Parse(entrada[2]);

    float media = CalcularMedia(nota1, nota2, nota3);

    Console.WriteLine("A média das notas é: " + media);
//8
Console.WriteLine("Informe 3 números:");
string[] valores = Console.ReadLine().Split(' ');
int numero1 = int.Parse(valores[0]);
int numero2 = int.Parse(valores[1]);
int numero3 = int.Parse(valores[2]);

int maiorNumero = numero1;
if (numero2 > maiorNumero)
{
    maiorNumero = numero2;
}
if (numero3 > maiorNumero)
{
    maiorNumero = numero3;
}

int menorNumero = numero1;
if (numero2 < menorNumero)
{
    menorNumero = numero2;
}
if (numero3 < menorNumero)
{
    menorNumero = numero3;
}

Console.WriteLine($"Maior número: {maiorNumero}");
Console.WriteLine($"Menor número: {menorNumero}");
//9
int soma = 0;
 int numero;
  do
          {
            Console.WriteLine("Digite um número (digite 0 para sair):");
            numero = int.Parse(Console.ReadLine());
            soma += numero;

           } while (numero != 0); 
  Console.WriteLine("A soma de todos os números digitados é: " + soma);
//10
Console.WriteLine("Digite o valor em reais que deseja converter.");
double reais = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a cotação atual do dólar.");
double dolar = double.Parse(Console.ReadLine());

double Resultado = reais * dolar;

Console.WriteLine("Resultado: " + Resultado +  " Dólares.");
//11

Console.Write("Digite um número para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = CalcularFatorial(n);

        if (resultado != -1)
        {
            Console.WriteLine($"O fatorial de {n} é: {resultado}");
        }
        else
        {
            Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
        }
    }

    static int CalcularFatorial(int n)
    {
        if (n < 0)
        {
            return -1; // Indica que o fatorial de números negativos não é definido.
        }
        else if (n == 0 || n == 1)
        {
            return 1; // O fatorial de 0 ou 1 é 1.
        }
        else
        {
            return n * CalcularFatorial(n - 1); // Chamada recursiva para calcular o fatorial.
        }
}
//12
Console.WriteLine("Digite um número positivo maior que zero para a sequência de Fibonacci:");  int n = int.Parse(Console.ReadLine());

 if (n <= 0)
{
 Console.WriteLine("Número inválido. Por favor, insira um número positivo maior que zero.");
  }
 else
  {
     Console.WriteLine($"Sequência de Fibonacci até {n}:");
 
       int a = 0, b = 1, proximo;

 
 Console.Write(a);

 
 while (b <= n)
 {
 Console.Write(", " + b);
 proximo = a + b;
 a = b;
 b = proximo;
  }
 }
 //13
 Console.WriteLine("Digite os nomes separados por vírgula:");
  string input = Console.ReadLine();


 string[] nomes = input.Split(',');

 for (int i = 0; i < nomes.Length; i++)
 {
 nomes[i] = nomes[i].Trim();
 }

 
 OrdenarNomes(nomes);

 
 Console.WriteLine("Lista de nomes ordenada:");
 foreach (string nome in nomes)
 {
 Console.WriteLine(nome);
 }
 }

 static void OrdenarNomes(string[] nomes)
 {
 int n = nomes.Length;
 bool houveTroca;

 for (int i = 0; i < n - 1; i++)
 {
 houveTroca = false;

 for (int j = 0; j < n - i - 1; j++)
 {
 if (nomes[j].CompareTo(nomes[j + 1]) > 0)
  {
string temp = nomes[j];
 nomes[j] = nomes[j + 1];
 nomes[j + 1] = temp;

 houveTroca = true;
 }
 }

 
 if (!houveTroca)
 break;


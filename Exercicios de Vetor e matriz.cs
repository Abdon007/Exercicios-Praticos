/*Faça um procedimento que recebe as 3 notas de um aluno por parâmetro e uma letra. Se a 
letra for ‘A’, o procedimento calcula e escreve a média aritmética das notas do aluno, se for 
‘P’, calcula e escreve a sua média ponderada (pesos: 5, 3 e 2). Faça um programa que leia 3 
notas de N alunos e acione o procedimento para cada aluno. (N deve ser lido do teclado)*/

using System;
class Program

{
    public static void calcNota(int n1, int n2, int n3, string l)
    {

        //se a opção for igual A, tira a media aritmética
        if (l.ToUpper() == "A")
        {
            int media;
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média aritmética das notas é: " + media);
        }
        //se a opção for igual p, tira a media ponderada.
        else if (l.ToUpper() == "P")
        {
            double media;
            media = (((double)n1 * 5) + ((double)n2 * 3) + ((double)n3 * 2)) / 10;
            Console.WriteLine("A média ponderada das notas é: " + media);
        }
        else
        {
            Console.WriteLine("Comando Inválido!");
        }
    }
    
      public static void Main(string[] args)
    {

        //declarando variavéis    
        int n1 = 0, n2 = 0, n3 = 0, n = 0;
        string l;


        Console.WriteLine("Insira a quantidade de alunos que vão inserir a nota: ");


        n = int.Parse(Console.ReadLine());
        //pede para o aluno inserir 3 notas

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Insira suas notas: (N1, N2, N3)");
            Console.WriteLine("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = int.Parse(Console.ReadLine());

            //Da ao usuario a opção de tirar media aritmetica ou ponderada.
            Console.WriteLine("Digite informe uma letra para escolher qual média calcular: (a) Aritmética, (p) Ponderada");
            l = Console.ReadLine();
            calcNota(n1, n2, n3, l);
            Console.WriteLine("\n... Indo para o próximo aluno ...\n\n\n");
        }
    }
}


/*A  prefeitura  de  uma  cidade  fez  uma  pesquisa  entre  os  seus  habitantes,  coletando  dados 
sobre  o  salário  e  número  de  filhos.  Faça  um  procedimento  que  leia  esses  dados  para  um 
número  não  determinado  de  pessoas,  calcule  e  exiba  a  média  de  salário  da  população  (a 
condição de parada pode ser um flag ou a quantidade N). Faça um programa que acione  o 
procedimento.*/


using System;
class Program
{
    public static void pesquisa(int n)
    {
        int salariot = 0, salario = 0, n_filhos = 0, M;
        //Coleta o salario e o numero de filhos do cidadão.

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite o salario:");
            salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de filhos:");
            n_filhos = int.Parse(Console.ReadLine());
            salariot += salario;
        }
        //Tira a media salarial e imprime
        M = salariot / n;
        Console.WriteLine("Media de salario da população: " + M);
    }
    public static void Main(string[] args)
    {
        //pergunta ao usuario a quantidade de pessoas que informaram salario e numero de filhos.
        int n;
        Console.WriteLine("Digite a quantidade pessoas:");
        n = int.Parse(Console.ReadLine());
        pesquisa(n);


    }
}



/*Faça um  procedimento que recebe 3  valores inteiros por parâmetro e os exiba em ordem 
crescente.  Faça  um  programa  que  leia  N  conjuntos  de  3  valores  e  acione  o  procedimento 
para cada conjunto. (N deve ser lido do teclado) */

using System;
class Program
{
    static void Exibir(int a, int b, int c)
    {
        //Imprime a ordem crescente dos numeros digitados.

        if (a < b && b < c) // A>B>C
        {
            Console.WriteLine("A ordem fica assim: {0} {1} {2} ", a, b, c);
        }

        else if (a < c && c < b)  // A>C>B
        {
            Console.WriteLine("A ordem fica assim: {0} {1} {2} ", a, c, b);
        }
        else if (b < a && a < c) // B>A>C
        {
            Console.WriteLine("A ordem fica assim: {0} {1} {2} ", b, a, c);
        }
        else if (b < c && c < a) // B>C>A 
        {
            Console.WriteLine("A ordem fica assim: {0} {1} {2} ", b, c, a);
        }

        else if (c < a && a < b) // C>A>B
        {
            Console.WriteLine("A ordem fica assim: {0} {1} {2} ", c, a, b);
        }

        else if (c < b && b < a) // C>B>A
        {
            Console.WriteLine("A ordem fica assim: {0} {1} {2} ", c, b, a);
        }

        else
        {
            Console.WriteLine("Insira os valores novamente");
        }

    }
    public static void Main(string[] args)
    {
        int n1 = 0, n2 = 0, n3 = 0, n = 0;
        //Pede ao usuario a quantidade de conjuntos.
        Console.WriteLine("Insira a quantidade de conjuntos:");
        n = int.Parse(Console.ReadLine());

        //pede ao usuario para inserir tres valores.
        for (int i = 0; i < n; i++)

        {
            Console.WriteLine("Insira três valores inteiros ");
            Console.WriteLine("Insira o Primeiro valor:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo valor:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Terceiro valor:");
            n3 = int.Parse(Console.ReadLine());
            //Imprime os valores em ordem crescente.
            Console.WriteLine("Ordem crescente dos valores:");
            Exibir(n1, n2, n3);
        }
    }
}


/*Escreva  um  procedimento  que  recebe  3  valores  reais  X,  Y  e  Z  e  que  verifique  se  esses 
valores podem ser os comprimentos dos lados de um triângulo e, neste caso, exibe qual é o 
tipo  de  triângulo  formado.  Para  que  X,  Y  e  Z  formem  um  triângulo  é  necessário  que  a 
seguinte propriedade seja satisfeita: o comprimento de cada lado de um triângulo é menor 
do  que  a  soma  do  comprimento  dos  outros  dois  lados.  O  procedimento  deve  identificar  o 
tipo de triângulo formado observando as seguintes definições:  
 
- Triângulo Equilátero: os comprimentos dos 3 lados são iguais; 
- Triângulo Isósceles: os comprimentos de pelo menos 2 lados são iguais.  
- Triângulo Escaleno: os comprimentos dos 3 lados são diferentes. 
 
      Faça um programa que leia um número indeterminado de triângulos (valores dos 3 lados) e  
      para cada triângulo, acione o procedimento. */

using System;
class Program
{
    static void Triangulo(int x, int y, int z)
    {

        //se os lados forem iguais imprime a mensagem triangulo equilatero.
        if (x == y && y == z)
        {
            Console.WriteLine("Triângulo Equilátero");
        }
        //se dois lados forem iguais imprime a mensagem triangulo isoceles.
        else if (x == y || y == z)
        {
            Console.WriteLine("Triângulo Isósceles");
        }
        //se os lados forem diferentes imprime a mensagem triangulo isoceles.
        else
        {
            Console.WriteLine("Triângulo Escaleno");
        }
    }
    public static void Main(string[] args)
    {
        int x, y, z, n;
        Console.WriteLine("---Programa que identifica um tipo de triângulo---");
        Console.WriteLine("Digite o numero de triangulos:");
        n = int.Parse(Console.ReadLine());

        //pede ao usuario para informar os valores referentes aos lados do triangulo.
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite 3 valores, esses valores serão os lados de um triangulo.");
            Console.WriteLine("Digite o valor de x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de z:");
            z = int.Parse(Console.ReadLine());

            //se um lado for menor que soma dos outro dois lados é um triangulo
            if (x < y + z || y < x + z || z < x + y)
            {
                Console.WriteLine("Triangulo identificado.");
                Triangulo(x, y, z);
            }
            //caso contrario não é  
            else
            {
                Console.WriteLine("Com esses valores não é possivel se formar um triângulo.");
            }
        }
        Console.WriteLine("---Fim do Programa---");
        Console.ReadLine();
    }
}


/*Em  matemática,  o  algoritmo  de  Euclides  é  um  método  simples  e  eficiente  de  encontrar  o 
Máximo Divisor Comum (MDC) entre dois números inteiros diferentes de zero. Crie uma 
função que receba dois números e calcule o MDC. */

using System;
class Program
{
    public static void Main(string[] args)
    {
        //Imprime o minimo divisor comum
        Console.WriteLine(Mdc());
    }


    public static int Mdc()
    {
        //declarando variaveis
        int a, b, aux, r;
        //entrada de dados
        Console.WriteLine("Digite um numero:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero:");
        b = int.Parse(Console.ReadLine());

        //checa se a é maior que b e faz a troca de valores
        if (a > b)
        {
            aux = a;
            a = b;
            b = aux;
        }
        //Encontra o minimo divisor comum enquanto o resto da divisão dos numeros for diferente de zero
        do
        {
            r = a % b;
            a = b;
            b = r;
        } while (r != 0);
        return a;

    }
}


/*Faça uma  função que recebe um valor inteiro e verifica se o valor é positivo ou negativo. 
A  função  deve  retornar  um  valor  lógico  (true  ou  false).  Faça  um  programa  que  lê  N 
números e para cada um deles exibe uma mensagem informando se ele é positivo ou não, 
dependendo se foi retornado verdadeiro ou falso pela função. */

using System;
class Program
{
    public static void Main(string[] args)
    {
        int n;
        bool resultado;
        Console.Write("Escreva um número: ");
        n = int.Parse(Console.ReadLine());
        resultado = par(n);

        //CONDIÇÃO PÁRA SABER SE O NUMERO É POSITIVO OU NEGATIVO
        if (resultado == true)
        {
            Console.WriteLine("O número é positivo");
        }
        else
        {
            Console.WriteLine("O número é negativo");
        }
    }

    static bool par(double n)
    {
        //CONDIÇÃO PARA RETORNAR TRUE OU FALSE
        if (n < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }


/*Faça  um  procedimento  que  recebe  a  média  final  de  um  aluno,  identifica  e  exibe  o  seu 
conceito,  conforme  a  tabela  abaixo.  Faça  um  programa  que  leia  a  média  de  N  alunos, 
acionando o procedimento para cada um deles. (N deve ser lido do teclado) 
 
Nota Conceito 
Até 39 F 
40 a 59 E 
60 a 69 D 
70 a 79 C 
80 a 89 B 
A partir de 90 A */

using System;
class Program
    {
        public static void Main(string[] args)
        {
            //declarando variaveis 
            int n, alunos = 5;
            //definindo numero de repetições e imprimindo a media do aluno.
            for (int i = 0; i < alunos; i++)
            {
                Console.Write("Escreva a sua média: ");
                n = int.Parse(Console.ReadLine());
                media(n);
            }
            static int media(int n)
            {
                //definindo condições que julga a nota do aluno como a, b, c, d, e ou f.
                if (n < 39)
                {
                    Console.WriteLine("Sua nota: F");
                }
                else if (n > 39 && n < 59)
                {
                    Console.WriteLine("Sua nota: E");
                }
                else if (n > 59 && n < 69)
                {
                    Console.WriteLine("Sua nota: D");
                }
                else if (n > 69 && n < 79)
                {
                    Console.WriteLine("Sua nota: C");
                }
                else if (n > 79 && n < 89)
                {
                    Console.WriteLine("Sua nota: B");
                }
                else
                {
                    Console.WriteLine("Sua nota: A");
                }
                return n;
            }
        }
    }


/*Escreva uma função que recebe por parâmetro um valor inteiro e positivo N e retorna o 
valor de S, calculado segundo a fórmula abaixo.  
 
S = 2/4 + 5/5 + 10/6 + 17/7 + 26/8 + ... +(n2+1)/(n+3) 
 
Faça um programa que leia N e imprima o valor retornado pela função. */

using System;
class Program
    {
        public static double Formula(double n)
        {
            double s = 0;
            //atribuindo a formula as repetições
            for (int i = 0; i < n; i++)
            {
                //formula
                double n1 = (Math.Pow(i, 2) + 1);
                double n2 = (i + 3);
                s = n1 / n2;

            }
            return s;

        }
        public static void Main(string[] args)
        {//declarando variaveis
            double n;
            Console.WriteLine("Digite um numero:");
            n = double.Parse(Console.ReadLine());

            //imprimindo o valor do calculo
            Console.WriteLine("O resultado do calculo é:" + Formula(n));
        }
    }


/*Faça uma função que lê um número indeterminado de notas de alunos, calcula e retorna a 
média das notas dos alunos aprovados (nota maior ou igual a 6). Faça um programa que lê 
o número de alunos e imprime a média retornada pela função. */
using System;
class Program
    {

        public static void Main(string[] args)
        {
            //declarando variaveis.
            double alunos = 5, m, p, h;
            //recebe a nota dos alunos em cada materia
            for (int i = 0; i < alunos; i++)
            {
                Console.WriteLine("Escreva sua nota em Matematica: ");
                m = double.Parse(Console.ReadLine());
                Console.WriteLine("Escreva sua nota em Portugues: ");
                p = double.Parse(Console.ReadLine());
                Console.WriteLine("Escreva sua nota em Historia: ");
                h = double.Parse(Console.ReadLine());
                //chama a função
                media(m, p, h);
            }
        }

        static double media(double m, double p, double h)
        {
            double resultado;
            //tira  a media do aluno
            resultado = (m + p + h) / 3;
            //imprime a media
            Console.WriteLine("Sua média: " + resultado);
            return resultado;
        }
    }


/* Faça uma função que recebe a idade de um nadador por parâmetro e retorna a categoria 
desse nadador de acordo com a tabela abaixo. 
 
Idade (anos) Categoria 
5 a 7 F 
8 a 10 E 
11 a 13 D 
14 a 15 C 
16 a 17 B 
Acima de 18 A 
 
      Faça um programa que lê a idade de um nadador e imprime a categoria retornada pela  
      função.*/

using System;
class Program
    {
        public static void Main(string[] args)
        {
            //declarando variaveis.
            int idade = 0, pessoas = 5;

            //recebe a idade de 5 pessoas.
            for (int i = 0; i < pessoas; i++)
            {
                Console.Write("Escreva sua idade: ");
                idade = int.Parse(Console.ReadLine());
                //chama a função.
                nadador(idade);

            }
            static int nadador(int idade)
            {
                //julga pela idade da pessoa em qual categoria ela se encaixa.
                if (idade > 5 && idade <= 7)
                {
                    Console.WriteLine("Categoria: F");
                }
                else if (idade > 7 && idade <= 10)
                {
                    Console.WriteLine("Categoria: E");
                }
                else if (idade > 10 && idade <= 13)
                {
                    Console.WriteLine("Categoria: D");
                }
                else if (idade > 13 && idade <= 15)
                {
                    Console.WriteLine("Categoria: C");
                }
                else if (idade > 15 && idade <= 17)
                {
                    Console.WriteLine("Categoria: B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Categoria: A");
                }
                return idade;
            }
        }
    }
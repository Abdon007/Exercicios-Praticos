//Programa que conta a quantidade de numeros negativos, positivos e iguais a zero.

using System;

class Program
{
    public static void Main(string[] args)
    {
        //declarando valores positivos,negativos eiguais a zero.
        int valorz, valorp, valorn, numero;

        valorp = 0;
        valorn = 0;
        valorz = 0;


        //criando repetições 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            //se o numero for mairo que 0 adiciona 1 em valorp
            if (numero > 0)
            {
                valorp++;
            }
            //se o numero for menor que zero ele adiciona 1 em valorn negativo
            else if (numero < 0)
            {
                valorn++;



            }
            //se o valor for igual a zero adiciona 1 em valorz
            else if (numero == 0)
            {
                valorz++;


            }

        }
        //Imprime os valores

        Console.WriteLine("Valores positivos: " + valorp);
        Console.WriteLine("Valores negativos: " + valorn);
        Console.WriteLine("Valores iguais a zero: " + valorz);



    }
}

//Programa que conta a quantidade de numeros negativos, positivos e iguais a zero e mostra a porcentagem desses valores.

using System;

class Program
{
    public static void Main(string[] args)
    {
        double valorz, valorp, valorn, numero, p;

        valorp = 0;
        valorn = 0;
        valorz = 0;


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());


            if (numero > 0)
            {
                valorp++;


            }
            else if (numero < 0)
            {
                valorn++;

            }
            else if (numero == 0)
            {
                valorz++;
            }

        }
        Console.WriteLine("Valores positivos: " + valorp);
        Console.WriteLine("Valores negativos: " + valorn);
        Console.WriteLine("Valores iguais a zero: " + valorz);
        Console.WriteLine("");
        //aplica a formula de porcentagem nos valores e imprime
        p = ((double)(valorp / 5) * 100);
        p = ((double)(valorn / 5) * 100);
        p = ((double)(valorz / 5) * 100);

        Console.WriteLine("Percentual de numeros positivos " + p + "%");
        Console.WriteLine("Percentual de numeros negativos " + p + "%");
        Console.WriteLine("Percentual de numeros iguais a zero " + p + "%");

    }


}
//Porgrama que checa se o numero digitado e divisivel por 3 e 9  e 2 e 5 e imprime a quantidad de numeros divisiveis. 
using System;

class Program
{
    public static void Main(string[] args)
    {
        double valord3, numero, valord2, nd;
        //declarando variaveis
        valord3 = 0;
        valord2 = 0;
        nd = 0;

        //criando repetições
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um numero");
            numero = double.Parse(Console.ReadLine());

            //checa se o numero e divisivel por 3 e 9 e 2 e 5
            if (numero % 3 == 0 && numero % 9 == 0)
            {
                valord3++;
            }
            else if (numero % 2 == 0 && numero % 5 == 0)
            {
                valord2++;
            }
            //caso nao seja divisivel adiciona 1 em nao divisiveis
            else
            {
                nd++;
            }
        }
        //imprime os numeros divisiveis por 3 e 9 e 2 e 5
        Console.WriteLine("Numeros divisiveis por 3 e 9: " + valord3);
        Console.WriteLine("Numeros divisiveis por 2 e 5: " + valord2);
        Console.WriteLine("Numeros não divisiveis: " + nd);
    }
}

//programa que le um valor de n e calcula a seguinte operação E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + .... + 1 / N!  
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Entrada de dados
        Console.WriteLine("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine());
        double fatorial = 1, E = 0;
        //Criando repetições
        for (int n = 1; n <= numero; n++)
        {
            E += 1 / fatorial;
            fatorial *= n;
        }
        //imprime o resultado da soma 
        Console.WriteLine("Resultado: " + E);
    }
}


//Programa que tira a media de salario de uma população, numero de filhos, maior salario e percentual de pessoas com salario até R$100,00.
using System;

class Program
{
    public static void Main(string[] args)
    {
        double salario1 = 1500, filhos1 = 2, salario2 = 3000, filhos2 = 5, salario3 = 1200, filhos3 = 6, mediaS, mediaF, percentual = 0;

        // Média de salarios:
        mediaS = (salario1 + salario2 + salario3) / 3;
        Console.Write("\nMédia do salário da população: " + mediaS);

        // Média do numero de filhos:
        mediaF = (filhos1 + filhos2 + filhos3) / 3;
        Console.Write("\nMédia de filhos: " + mediaF);

        // Compara os valores e imprime uma mensagem informando o maior salario:
        if (salario1 > salario2 && salario1 > salario3)
        {
            Console.Write("\nMaior salário: " + salario1);
        }
        else if (salario2 > salario1 && salario2 > salario3)
        {
            Console.Write("\nMaior salário: " + salario2);
        }
        else
        {
            Console.Write("\nMaior salário: " + salario3);
        }

        // Imprime uma mensagem com o percentual de salarios menores que 10000 checando se são menores que 10000:
        if (salario1 < 10000)
        {
            percentual++;
        }
        if (salario2 < 10000)
        {
            percentual++;
        }
        if (salario3 < 10000)
        {
            percentual++;
        }
        Console.Write("\nPessoas com salario ate 10000R$: " + percentual);
    }
}

//programa que le um valor de n e calcula a seguinte operação S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n. 
using System;

class Program
{
    public static void Main(string[] args)
    {
        //declarando variaveis
        double numero, soma = 1;
        //entrada do usuario
        Console.WriteLine("Digite um numero maior que zero: ");
        numero = double.Parse(Console.ReadLine());
        //repetição da soma 
        for (int n = 1; n <= numero; n++)
        {
            //acrescenta 1/numero digitado pelo usuario na soma
            soma += 1 / numero;
        }
        //imprime a soma
        Console.WriteLine("Resultado: " + soma);
    }

}

//Programa que imprime a sequência de elementos da serie fibonacci imposta pelo usuario.
using System;
class Program
{
    public static void Main(string[] args)
    {
        int n1 = 1, n2 = 0, n;

        Console.Write("Digite quantos termos da sequencia de Fibonacci você quer: ");
        n = int.Parse(Console.ReadLine());

        // Criando repetidor baseado no numero que o usuário digitou.
        for (int i = 1; i <= n; i++)
        {
            if (i < 2)
            {

                Console.Write(1);

            }
            else
            {
                n1 = n1 + n2;
                n2 = n1 - n2;


                Console.Write("," + n1);
            }
        }
    }
}


//Programa que imprime todos os elementos da serie fibonacci menores que o numero de repetições.
using System;
class Program
{
    public static void Main(string[] args)
    {
        int n1 = 1, n2 = 0, n;

        Console.Write("Digite o numero de termos da sequência de Fibonacci: ");
        n = int.Parse(Console.ReadLine());

        //Faz a soma de Fibonacci e da os valores até o numero que o usuário digitou:
        for (int i = 1; i <= n; i++)
        {
            if (i < 2)
            {

                Console.Write(1);

            }
            else
            {
                n1 = n1 + n2;
                n2 = n1 - n2;

                if (n1 >= n)
                {
                    return;
                }
                else
                {
                    Console.Write("," + n1);
                }
            }
        }
    }
}


/*Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele 
comercializa.  Para  isto,  mandou  digitar  uma  linha  para  cada  mercadoria  com  o  preço  de 
compra e de venda de cada uma. A última linha contém preço de compra igual a 0. Escreva 
um programa que: 
 
a) Determine e escreva quantas mercadorias proporcionaram: 
i) Lucro < 10% 
ii) 10% <= lucro <= 20% 
iii) Lucro > 20% 
b) Determine e escreva o valor total de compra e de venda de todas as mercadorias, 
assim como o lucro total.*/
using System;
class Program
{
    public static void Main(string[] args)
    {
        //declarando variáveis

        double pc1, pv1, pc2, pv2, pc3, pv3, i, LMD, LDAV, LMV, L;
        pc1 = 0; pv1 = 0; pc2 = 0; pv2 = 0; pc3 = 0; pv3 = 0; LMD = 0; LMV = 0; LDAV = 0; L = 0;
        
        //Criando duas repetições para preço de compra e venda da primeira mercadoria
        
        for (i = 0; i < 1; i++)
        {
            Console.WriteLine("Digite o preço de compra da primeira mercadoria:");
            pc1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de venda da primeira mercadoria:");
            pv1 = double.Parse(Console.ReadLine());
            //formula de lucro
            L = (pv1 / pc1 - 1) * 100;
           
            //se o lucro for menor que 10 adicionada 1 em LMD
            if (L < 10)
            {
                LMD++;
            }
            //se o lucro for entre 10 e 20 % adiciona 1 em lDAV
            else if (L >= 10 && L <= 20)
            {
                LDAV++;
            }
            //se o lucro for maior que 20 adiciona em LMV
            else if (L > 20)
            {
                LMV++;
            }

            //segundo laço de repetição
           
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine("Digite o preço de compra da segunda mercadoria:");
                pc2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preço de venda da segunda mercadoria:");
                pv2 = double.Parse(Console.ReadLine());
                L = (pv2 / pc2 - 1) * 100;
                if (L < 10)
                {
                    LMD++;
                }
                else if (L >= 10 && L <= 20)
                {
                    LDAV++;
                }
                else if (L > 20)
                {
                    LMV++;
                }
            } 
            
            //terceiro laço de repetição
            
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine("Digite o preço de compra da terceira mercadoria:");
                pc3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preço de venda da terceira mercadoira:");
                pv3 = double.Parse(Console.ReadLine());
                L = (pv3 / pc3 - 1) * 100;
                if (L < 10)
                {
                    LMD++;
                }
                else if (L >= 10 && L <= 20)
                {
                    LDAV++;
                }
                else if (L > 20)
                {
                    LMV++;
                }
            }
            
            
            //imprimindo os valores
            Console.WriteLine("Mercadorias com lucro menor que 10%: " + LMD);
            Console.WriteLine("Mercadorias com lucro entre 10% a 20%: " + LDAV);
            Console.WriteLine("Mercadorias com lucro maior que 20%: " + LMV);
            Console.WriteLine("");
            double VTC = pc1 + pc2 + pc3;
            Console.WriteLine("Valor total de compra: " + "R$" + VTC);
            double VTV = pv1 + pv2 + pv3;
            Console.WriteLine("Valor total de vendas: " + "R$" + VTV);
            double LT = VTV - VTC;
            Console.WriteLine("Lucro total:" + "R$" + LT);
        }
    }
}

//Programa que faz a contagem de votos das eleições.
using System;
class Program
{
    public static void Main(string[] args)
    {
        int L = 0, B = 0, C = 0, T = 0, N = 0, BR = 0, v;
        Console.Write("VOTAÇÂO 2022 ");
        //Da as opções de voto para o usuário:
        Console.Write("Candidatos: \n L = 1 \n B = 2 \n C = 3 \n T = 4 \n Para Nulo digite 5 \n Para Branco digite 6");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("\n\nEscolha o candidato: ");
            v = int.Parse(Console.ReadLine());
            // Contagem dos votos:
            if (v == 1)
            {
                L++;
            }
            else if (v == 2)
            {
                B++;
            }
            else if (v == 3)
            {
                C++;
            }
            else if (v == 4)
            {
                T++;
            }
            else if (v == 5)
            {
                N++;
            }
            else if (v == 6)
            {
                BR++;
            }
        }
        //Impressão dos valores:
        Console.Write("\nTotal de votos");
        Console.Write("\nL: " + L);
        Console.Write("\nB: " + B);
        Console.Write("\nC: " + C);
        Console.Write("\nT: " + T);
        Console.Write("\nNULO: " + N);
        Console.Write("\nBRANCO: " + BR);
    }
}


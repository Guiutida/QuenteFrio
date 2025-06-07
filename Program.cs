int numeroSecreto, tentativas = 0, palpite, diferenca;
bool acertou = false;

Random random = new Random();
numeroSecreto = random.Next(1, 101);

Console.Clear();

Console.WriteLine("Tente adivinhar o número entre 1 e 100.");
Console.WriteLine($"Você tem 7 tentativas. ");

while (tentativas < 7 && !acertou)
{
    Console.Write($"\nTentativas {tentativas + 1}: ");
    palpite = Convert.ToInt16(Console.ReadLine());

    tentativas++;

    if (palpite == numeroSecreto)
    {
        acertou = true;
        Console.WriteLine("Parabens você acertou o número secreto");
    }
    else
    {
        diferenca = Math.Abs(palpite - numeroSecreto);

        if (diferenca <= 3)
        {
            Console.WriteLine("Esta pelando");
        }
        else if (diferenca <= 10)
        {
            Console.WriteLine("Esta quente");
        }
        else if (diferenca <= 30)
        {
            Console.WriteLine("Esta Congelando");
        }
        else
        {
            Console.WriteLine("Esta frio");
        }


        if (palpite < numeroSecreto)
        {
            Console.WriteLine("Dica: O número secreto é Maior");
        }
        else
        {
            Console.WriteLine("Dica: O numero secreto é Menor");
        }
    }
}

if (!acertou)
{
      Console.WriteLine($"\n'Você perdeu! O número secreto era {numeroSecreto}.");
}

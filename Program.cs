Console.WriteLine("- Quadrante -");

Console.WriteLine("Digite as coordenadas para serem localizadas no quadrante. ");

Console.Write("Digite a coordenada X..... ");

double coordenadax = Convert.ToDouble(Console.ReadLine());

Console.Write("Agora digite a coordenada y..... ");

double coordenaday = Convert.ToDouble(Console.ReadLine());
string mensagem;


if (coordenadax > 0 && coordenaday > 0)
{
Corzinha();
mensagem = $"O ponto ({coordenadax}, {coordenaday}) fica no primeiro quadrante. (I)";
}

else if (coordenadax > 0 && coordenaday < 0)
{
Corzinha();
mensagem = $"O ponto ({coordenadax}, {coordenaday}) fica no quarto quadrante. (IV)";
}

else if (coordenadax < 0 && coordenaday > 0)
{
Corzinha();
mensagem = $"O ponto ({coordenadax}, {coordenaday}) fica no segundo quadrante. (II)";
}

else if (coordenadax < 0 && coordenaday < 0)
{
Corzinha();
mensagem = $"O ponto ({coordenadax}, {coordenaday}) fica no terceiro quadrante. (III)";
}

else
{
Corzinha();
mensagem = $"O ponto ({coordenadax}, {coordenaday}) fica na origem do quadrante.";
}

void Corzinha()
{
Console.ForegroundColor = ConsoleColor.Cyan;
}

Console.WriteLine();
Console.WriteLine(mensagem);
Console.WriteLine();
Console.ResetColor();
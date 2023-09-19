using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira sua data de nascimento
        Console.Write("Digite sua data de nascimento (AAAA-MM-DD): ");
        string dataNascimentoString = Console.ReadLine();

        // Converte a string de data de nascimento em um objeto DateTime
        DateTime dataNascimento;
        if (DateTime.TryParse(dataNascimentoString, out dataNascimento))
        {
            // Calcula a idade atual do usuário
            int idade = CalcularIdade(dataNascimento);

            // Exibe a idade
            Console.WriteLine("Sua idade é: " + idade + " anos.");
        }
        else
        {
            Console.WriteLine("Data de nascimento inválida. Certifique-se de usar o formato AAAA-MM-DD.");
        }
    }

    // Função para calcular a idade com base na data de nascimento
    static int CalcularIdade(DateTime dataNascimento)
    {
        DateTime dataAtual = DateTime.Now;
        int idade = dataAtual.Year - dataNascimento.Year;

        // Verifica se o aniversário já ocorreu este ano
        if (dataNascimento.Date > dataAtual.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }
}

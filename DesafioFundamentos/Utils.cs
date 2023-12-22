namespace DesafioFundamentos;

public static class Utils
{
    public static int ObterValorInteiro(string mensagemObterValor)
    {
        int resultado = 0;

        Console.WriteLine(mensagemObterValor);

        string valor = Console.ReadLine();

        bool valorInvalido = string.IsNullOrEmpty(valor) || //retorna verdadeiro caso seja digitado nulo ou espaço vazio
                             !int.TryParse(valor, out resultado); //retorna verdadeiro caso consiga converte o string em inteiro
                                                                  //para entrar no while quando der erro na conveçao do string foi usado a exclamaçao

        while (valorInvalido)
        {
            Console.WriteLine("Valor invalido, tente novamente");
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(mensagemObterValor);
            valor = Console.ReadLine();
            valorInvalido = string.IsNullOrEmpty(valor) || !int.TryParse(valor, out resultado);
        }

        return resultado;
    }

    public static decimal ObterValorDecimal(string mensagemObterValor)
    {
        decimal resultado = 0;

        Console.WriteLine(mensagemObterValor);

        string valor = Console.ReadLine();

        bool valorInvalido = string.IsNullOrEmpty(valor) || //retorna verdadeiro caso seja digitado nulo ou espaço vazio
                             !decimal.TryParse(valor, out resultado); //retorna verdadeiro caso consiga converte o string em decimal
                                                                      //para entrar no while quando der erro na conveçao do string foi usado a exclamaçao

        while (valorInvalido)
        {
            Console.WriteLine("Valor invalido, tente novamente");
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(mensagemObterValor);
            valor = Console.ReadLine();
            valorInvalido = string.IsNullOrEmpty(valor) || !decimal.TryParse(valor, out resultado);
        }

        return resultado;
    }

    public static string ObterValorTexto(string mensagemObterValor)
    {

        Console.WriteLine(mensagemObterValor);

        string valor = Console.ReadLine();

        bool valorInvalido = string.IsNullOrEmpty(valor); //retorna verdadeiro se o valor for falso ou vazio

        while (valorInvalido)
        {
            Console.WriteLine("Valor invalido, tente novamente");
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(mensagemObterValor);
            valor = Console.ReadLine();
            valorInvalido = string.IsNullOrEmpty(valor);
        }

        return valor.ToUpper();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiinhaCalculadora_de_Signos
{
    class Program
    {
        static void Main(string[] args)
        {
//          VARIAVEIS
            string dia;
            string mes;

//          MENSAGEM ITRODUTÓRIA
            Console.WriteLine("Olá, sou o profeta Yacov. Responda-me as perguntas abaixo e direi a qual tribo você pertence.");
            Console.WriteLine(" ");
            Console.WriteLine("Isto é apenas uma brincadeira, contudo se você entender que tem agido como a tribo que te for revelada, Vigia!");
            Console.WriteLine(" ");
            Console.WriteLine("Use formas númerais para responder.");

//          ENTRADAS
//          ISERÇÃO DO DIA
            Console.WriteLine("Em que dia você nasceu?");
            dia = Console.ReadLine();
//          ISERÇÃO DO MÊS
            Console.WriteLine("Em que dia você nasceu?");
            mes = Console.ReadLine();

//          TRATAMENTO DE ERRO (DIA OU MÊS POR ESTENSO)
            uint diaInt = 0;
            uint mesInt = 0;

//          TESTE DE COVERSÃO (STRING -> INT)
            try
            {
                diaInt = Convert.ToUInt32(dia);
                mesInt = Convert.ToUInt32(mes);
            }
//          RECEBIMENTO DO TESTE E MENSAGEM DE ERRO
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }

//          INTERPRETAÇÃO DA INFORMAÇÃO
            Profeta Interpretador = new Profeta();
            Tribo tribo = Interpretador.OuvirDeus(diaInt, mesInt);

//          RESPOSTA DO INTERPRETADOR
            if (tribo != null)
            {
//              RESPOSTA
                Console.WriteLine("Aquele que tem ouvidos ouça o que o Espirito diz a Igreja 'Analize pois, o homem, seu caminho'. Sua tribo é:" + tribo.nome);
                Console.WriteLine(tribo.caracteristicas);
            } else {
//              MENSAGEM DE ERRO
                Console.WriteLine(" ");
                Console.WriteLine("ERRO!");
                Console.WriteLine("Não foi possivel profetizar sua tribo, pois o dia ou mês que informou não são válidos.");
            }

            Console.ReadLine();
        }
    }
}

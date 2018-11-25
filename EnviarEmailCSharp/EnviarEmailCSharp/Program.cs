using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviarEmailCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviarEmail enviarEmail = new EnviarEmail();
            string Mensagem = "Olá Estou te enviando um E-mail com C#";
            string EnviarPara ="Conta_que_vai_receber_mensagem@gmail.com";
            Console.WriteLine(enviarEmail.Enviar(Mensagem, EnviarPara));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Aula31WhatsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda a = new Agenda();
            a.Nome =  "Ana";
            a.Telefone = "9503412860";

            a.Cadastrar(a);
            a.Remover("Ana");
        }
    }
}

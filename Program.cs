using System;
using System.Collections.Generic;

namespace Aula31WhatsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Agenda a = new Agenda();
            Contato c1 = new Contato ("Ana", "92148121");

            Contato c2 = new Contato ();
            c2.Nome = "Andreia";
            c2.Telefone = "921563610";
            
            

            a.Cadastrar ( c1 );
            a.RemoverContato("Ana");
        }
    }
}

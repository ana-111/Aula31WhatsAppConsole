using System.Collections.Generic;

namespace Aula31WhatsAppConsole
{
    public class Agenda : IAgenda
    {
        List<Contato> agenda = new List<Contato>();
        private Contato _contato;

        public void CadastrarContato(int _cod, Agenda _contatoCadastrado)
        {
            
            
            
        }

        public void RemoverContato(Agenda _agenda)
        {
            agenda.Remove(_contato);
        }

        public void Listar()
        {
            foreach(Contato item in agenda){
               System.Console.WriteLine($"R$ {item.Nome} - {item.Telefone}");
           }
        }
    }
}
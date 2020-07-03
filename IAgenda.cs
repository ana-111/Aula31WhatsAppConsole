namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
        void CadastrarContato(int _cod, Agenda _contatoCadastrado);
        void RemoverContato(Agenda _agenda);
        void Listar();
    }
}
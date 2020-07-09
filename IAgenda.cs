namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
        void Cadastrar(Contato c);
        void RemoverContato(string _termo);
        void Listar();
    }
}
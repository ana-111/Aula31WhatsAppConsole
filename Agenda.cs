using System;
using System.Collections.Generic;
using System.IO;

namespace Aula31WhatsAppConsole
{
    public class Agenda : IAgenda
    {

        public Agenda(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;

        }
        public string Nome { get; set; }

        internal void Cadastrar(Agenda a)
        {
            string[] linha = new string[] { PrepararLinha(a) };
            File.AppendAllLines(PATH, linha);
        }

        internal void Remover(string v)
        {
            throw new NotImplementedException();
        }

        public string Telefone { get; set; }
        private const string PATH = "Database/produto.csv";
        private object contatos;

        public Agenda()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public void CadastrarContato(Agenda a)
        {
            string[] linha = new string[] { PrepararLinha(a) };
            File.AppendAllLines(PATH, linha);
        }

        private string PrepararLinha(Agenda a)
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            List<Agenda> prod = new List<Agenda>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {
                string[] dado = linha.Split(";");

            }

        }

        public void RemoverContato(string _agenda)
        {
            List<string> contatos = new List<string>();

            using (StreamReader file = new StreamReader(PATH))
            {
                string contato;
                while ((contato = file.ReadLine()) != null)
                {
                    contatos.Add(contato);
                }
                contatos.RemoveAll(l => l.Contains( _agenda ));
            }

            using (StreamWriter output = new StreamWriter(PATH))
            {
                output.Write(string.Join(Environment.NewLine, contatos.ToArray()));
            }
        }

        public void CadastrarContato(int _cod, Agenda _contatoCadastrado)
        {
            throw new NotImplementedException();
        }

        public void RemoverContato(Agenda _agenda)
        {
            throw new NotImplementedException();
        }
    }
}
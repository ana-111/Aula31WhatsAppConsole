using System;
using System.Collections.Generic;
using System.IO;

namespace Aula31WhatsAppConsole
{
    public class Agenda : IAgenda
    {
        private const string PATH = "Database/produto.csv";

        public Agenda()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Contato c)
        {
            string[] linha = new string[] { PrepararLinha(c) };
            File.AppendAllLines(PATH, linha);
        }

        private string PrepararLinha(Contato c)
        {
            return $"R$ {c.Nome};{c.Telefone}";
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

        public void RemoverContato(string _termo)
        {
            List<string> contatos = new List<string>();

            using (StreamReader file = new StreamReader(PATH))
            {
                string contato;
                while ((contato = file.ReadLine()) != null)
                {
                    contatos.Add(contato);
            }        
                }
            contatos.RemoveAll(l => l.Contains(_termo));
                
            using (StreamWriter output = new StreamWriter(PATH))
            {
                output.Write(string.Join(Environment.NewLine, contatos.ToArray()));
            }
            
        }
    }

}

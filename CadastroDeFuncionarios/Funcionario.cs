using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CadastroDeFuncionarios
{
    /// <summary>
    /// Classe criada para gerenciar dados do usuario e salva-los corretamente
    /// </summary>
   public class Funcionario
    {
        private string nome;
        private string telefoneNormal;
        private string telefoneEmergencia;
        private string profissao;
        private string email;
        private string salario;
        private string endereco;
        private string numeroEndereco;

        /// <summary>
        /// Construtor da classe funcionário
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefoneNormal"></param>
        /// <param name="telefoneEmergencia"></param>
        /// <param name="profissao"></param>
        /// <param name="email"></param>
        /// <param name="salario"></param>
        /// <param name="endereco"></param>
        /// <param name="numeroEndereco"></param>
        public Funcionario(string nome, string telefoneNormal, string telefoneEmergencia, string profissao, string email, string salario, string endereco, string numeroEndereco)
        {
            this.nome = nome;
            this.telefoneNormal = telefoneNormal;
            this.telefoneEmergencia = telefoneEmergencia;
            this.profissao = profissao;
            this.email = email;
            this.salario = salario;
            this.endereco = endereco;
            this.numeroEndereco = numeroEndereco;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string TelefoneNormal
        {
            get
            {
                return telefoneNormal;
            }

            set
            {
                telefoneNormal = value;
            }
        }

        public string TelefoneEmergencia
        {
            get
            {
                return telefoneEmergencia;
            }

            set
            {
                telefoneEmergencia = value;
            }
        }

        public string Profissao
        {
            get
            {
                return profissao;
            }

            set
            {
                profissao = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string NumeroEndereco
        {
            get
            {
                return numeroEndereco;
            }

            set
            {
                numeroEndereco = value;
            }
        }

        /// <summary>
        /// Método para juntar todos os dados do usuario, para salvar no arquivo TXT
        /// </summary>
        /// <returns>Retorna uma string para salvar os dados no arquivo TXT</returns>
        public string salvarTudo()
        {
            string dadosCompletos = Nome + "|" + TelefoneNormal + "|" + telefoneEmergencia 
                + "|" + profissao + "|" + email + "|"
                 + Convert.ToString(salario) + "|" + endereco + "|" + numeroEndereco;

            return dadosCompletos;
        }

        /// <summary>
        /// Método para gravar os dados do funcionário no arquivo txt
        /// </summary>
        public void fazerCadastro()
        { 
            Stream arq = File.Open("dados.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(arq);
            writer.WriteLine(salvarTudo());
            writer.Close();
            arq.Close();
        }

        /// <summary>
        /// Método para ler todos os dados do txt
        /// </summary>
        /// <returns>Retorna uma lista com todos os dados dos funcionários</returns>
        public static List<Funcionario> exibirDadosDoFuncionario()
        {
            string linha;
            List<Funcionario> funcionarios = new List<Funcionario>();
            Stream arq = File.Open("dados.txt", FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(arq);

            while((linha = reader.ReadLine()) != null)
            {
                string[] todasLinhas = linha.Split('|');
                funcionarios.Add(new Funcionario(todasLinhas[0],todasLinhas[1],todasLinhas[2],todasLinhas[3],todasLinhas[4],todasLinhas[5],todasLinhas[6],todasLinhas[7]));
            }
            reader.Close();
            arq.Close();
            return funcionarios;
        }
    }
}

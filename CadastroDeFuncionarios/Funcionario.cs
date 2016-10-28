using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeFuncionarios
{
    /// <summary>
    /// Classe criada para gerenciar dados do usuario e salva-los corretamente
    /// </summary>
   public class Funcionario
    {
        private int id;
        private string nome;
        private string telefoneNormal;
        private string telefoneEmergencia;
        private string profissao;
        private string relacionamento;
        private string email;
        private string salario;
        private string endereco;
        private string numeroEndereco;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
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

        public string Relacionamento
        {
            get
            {
                return relacionamento;
            }

            set
            {
                relacionamento = value;
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
            string dadosCompletos = Convert.ToString(id) + "|" + Nome + "|" + TelefoneNormal + "|" + telefoneEmergencia 
                + "|" + profissao + "|" + relacionamento + "|" + email + "|"
                 + Convert.ToString(salario) + "|" + endereco + "|" + numeroEndereco;

            return dadosCompletos;
        }
    }
}

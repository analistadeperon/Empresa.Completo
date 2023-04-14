public class Empresa
{
    public int EmpresaId { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string CNPJ { get; set; }
    ............

    public string UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    public ICollection<Funcionario> Funcionarios { get; set; }
}

public class Funcionario{
    public int FuncId (get; set;)
}
 [Required(ErrorMessage = "Campo obrigatório")]
    [StringLength(100, ErrorMessage = "Use menos caracteres")]
    public string Nome { get; set; }
    ...........
    public string Demissao { get; set; }

    public int EmpresaId { get; set; }
    public Empresa Empresa { get; set; }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
public static class FormatCnpjCpf
{
    /// <summary>
    /// Formatar uma string CNPJ
    /// </summary>
    /// <param name="CNPJ">string CNPJ sem formatacao</param>
    /// <returns>string CNPJ formatada</returns>
    /// <example>Recebe '99999999999999' Devolve '99.999.999/9999-99'</example>
 
    public static string FormatCNPJ(string CNPJ)
    {
        return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
    }
 
    /// <summary>
    /// Formatar uma string CPF
    /// </summary>
    /// <param name="CPF">string CPF sem formatacao</param>
    /// <returns>string CPF formatada</returns>
    /// <example>Recebe '99999999999' Devolve '999.999.999-99'</example>
 
    public static string FormatCPF(string CPF)
    {
        return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
    }
    /// <summary>
    /// Retira a Formatacao de uma string CNPJ/CPF
    /// </summary>
    /// <param name="Codigo">string Codigo Formatada</param>
    /// <returns>string sem formatacao</returns>
    /// <example>Recebe '99.999.999/9999-99' Devolve '99999999999999'</example>
 
    public static string SemFormatacao(string Codigo)
    {
        return Codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
    }
}
................................................................................................................

using System;
using System.IO;
using System.Xml;
namespace CShp_XML_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("../../dados.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // O node é um elemento raiz
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Exibe o texto para cada elemento
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Exibe o final do elemento
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

lista dentro do construtor (Revisitado):

public class Usuario {
        public string Nome {get; set;}
        public int Idade {get;set}
        public List<Endereco> Endereco {get; set;}
        public List<Telefone> Telefone { get; set; }

        public Usuario(string nome, int idade, Endereco endereco, Telefone telefone){
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
        }
}

public class Endereco {
        public string Logradouro {get; set;}
        public string Numero {get; set;}
        public string Complemento {get; set;}
        public string Bairro {get; set;}
        public string Cidade {get; set;}
        public string Estado {get; set;}
        public string Cep {get; set;}
        public Tipo Tipo {get; set;}

}


public class Telefone {
        public int DDD {get; set;}
        public string Telefone {get; set:}
        public Tipo Tipo {get; set;}

}

enum Tipo {
    Comercial = 1,
    Residencial = 2
}

public class Usuario {
        public string Nome {get; set;}
        public int Idade {get;set}
        public List<Endereco> Enderecos {get; set;}
        public Telefone Telefone { get; set; }

        public Usuario(string nome, int idade, List<Endereco> enderecos, Telefone telefone){
            Nome = nome;
            Idade = idade;
            Enderecos = enderecos;
            Telefone = telefone;
        }
    }

var listaUsuarios = new CriarUsuarioDTO(
        usuario = umDTOorigem.Nome,
        idade = umDTOorigem.Idade,
        endereco = new List<EnderecoDTO>(umDTOorigem.Endereco),
        telefone = new List<TelefoneDTO>(umDTOorigem.Telefone)
);

...............................................................................

// SqlConnection conn = new SqlConnection(strConn); Acessa o banco de dados SQL.



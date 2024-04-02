    public class Pessoa {
        private String nome;
        private int idade;
        private String cpf;
        //Construtor da classe Pessoa
        public Pessoa(string nome, int idade, string cpf) {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
        }
        //Propriedades da classe Pessoa que permite acesso controlado a um campo privado
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade {
            get { return idade; }
            set { idade = value; }
        }
        public string CPF {
            get { return cpf; }
            set { cpf = value; }
        }
    }
    public class Estudante : Pessoa {
        private String curso;

        //Construtor da classe estudante
        public Estudante(string nome, int idade, string cpf, string curso) : base(nome, idade, cpf) {
            Curso = curso;
        }

        //Propriedades da classe Estudante que permite acesso controlado a um campo privado
        public string Curso{
            get { return curso; }
            set { curso = value; }
        }
    }
    public class Personagem {
        private string classe;
        private string elemento;
        private  int idade;
        private string nome;
        //construção classe Personagem
        public Personagem(string classe, string elemento, int idade, string nome) {
            this.classe = classe;
            this.elemento = elemento;
            this.idade = idade;
            this.nome = nome;
        } 
         //Propriedades da classe Personagem que permite acesso controlado a um campo privado
        public string Classe {
            get { return classe; }
            set { classe = value; }
        }
        public decimal Elemento {
            get { return elemento; }
            set { elemento = value; }
        }
        public int Idade {
            get { return idade; }
            set { idade = value; }
        }
        public int Nome {
            get { return nome; }
            set { nome = value; }
        }
         public void Atacar() {
            Console.WriteLine("Ataque básico");
        }
        public void Atacar(string habilidade) {
            Console.WriteLine("Ataque Ultimate" + habilidade);
        }
    } 
    public class Guerreiro : Personagem {
        private string armamento;

        //Construtor da classe Guerreiro
        public Guerreiro(string classe, string elemento, int idade, string nome, string armamento) : base(classe, elemento, idade, nome) {
            Armamento = armamento;
        }

        //Propriedades da classe Guerreiro que permite acesso controlado a um campo privado
        public string Armamento{
            get { return armamento; }
            set { armamento = value; }
        }
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com armamento");
        }
    public void Atacar(string habilidade) {
        Console.WriteLine("Meteoro de magma" + habilidade);
    }
    
    }
    public class Mago : Personagem {
        private string feitico;

        //Construtor da classe Mago
        public Mago(string classe, string elemento, int idade, string nome, string feitico) : base(classe, elemento, idade, nome) {
            Feitico = feitico;
        }

        //Propriedades da classe Mago que permite acesso controlado a um campo privado
        public string Feitico{
            get { return feitico; }
            set { feitico = value; }
        }
    public void Atacar() {
        Console.WriteLine("Mago ataca com a feitico");
        }
    public void Atacar(string habilidade) {
        Console.WriteLine("Esqueleto gigante" + habilidade);
    }    
    
    }
    public class Arqueiro : Personagem {
        private string flechaEncantada;

        //Construtor da classe Arqueiro
        public Arqueiro(string classe, string elemento, int idade, string nome, string flechaEncantada) : base(classe, elemento, idade, nome) {
            FlechaEncantada = flechaEncantada;
        }

        //Propriedades da classe Arqueiro que permite acesso controlado a um campo privado
        public string FlechaEncantada{
            get { return flechaEncantada; }
            set { flechaEncantada = value; }
        }
    public void Atacar() {
        Console.WriteLine("Arqueiro atira flechas com encantamento");
        }
    public void Atacar(string habilidade) {
        Console.WriteLine("Flecha gigante" + habilidade);
    }    
    
    }
    public class Program {
        public static void main (String[] args) {
            Guerreiro guerreiro = new Guerreiro("Paladino", "Fogo", 45, "David", "Espada de Lava");
            guerreiro.Atacar();
            guerreiro.Atacar("Corte flamejante");

            Mago mago = new Mago("Necromante", "Morte", 282, "Gal", "Ressuscitar os Mortos");
            mago.Atacar();
            mago.Atacar("Exercito de esqueletos");

            Arqueiro arqueiro = new Arqueiro("Elfo", "Natureza", 116, "Vex", "Encantamento Enraizar");
            arqueiro.Atacar();
            arqueiro.Atacar("Chuva de flechas");
        }    
    } 
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
         public virtual void Atacar() {
            Console.WriteLine("Ataque básico");
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
    public override void Atacar() {
        Console.WriteLine("Guerreiro ataca com armamento");
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
    public override void Atacar() {
        Console.WriteLine("Mago ataca com a feitico");
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
    public override void Atacar() {
        Console.WriteLine("Arqueiro atira flechas com encantamento");
        }
    
    }
    public class Program {
        public static void main (String[] args) {
            Guerreiro guerreiro = new Guerreiro("Paladino", "Fogo", 45, "David", "Espada de Lava");
            guerreiro.Atacar();

            Mago mago = new Mago("Necromante", "Morte", 282, "Gal", "Ressuscitar os Mortos");
            mago.Atacar();

            Arqueiro arqueiro = new Arqueiro("Elfo", "Natureza", 116, "Vex", "Encantamento Enraizar");
            arqueiro.Atacar();
        }    
    } 
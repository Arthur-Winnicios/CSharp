    using System;

    public class Heroi {
        //Atributos
        private string nome;
        private string cor;
        private int idade;
        private double altura;
        private char genero;
        
        //Construtor
        public Heroi(string nome, string cor, int idade, double altura, char genero) {
            this.nome = nome;
            this.cor = cor;
            this.idade = idade;
            this.altura = altura;
            this.genero = genero;
        }
        //Metodos
        public void infoHeroi() {
            Console.WriteLine($"Nome: {nome}, idade: {idade}, altura: {altura}, genero: {genero}");
        }
        public void correr() {
            Console.WriteLine("Correndo.");
        }
        public void pular() {
            Console.WriteLine("Pulando.");
        }
    }
    public class Batman : Heroi {

        public Batman() {
            this.nome = "Batman";
            this.cor = "Preto";
            this.idade = 30;
            this.altura = 1.88;
            this.genero = "M";

            public void CinturaoDeUtilidades() {
                Console.WriteLine("Batman está utilizando seu cinturão de utilidades.");
            }
        }
    }
    public class Superman : Heroi {

        public Superman() {
            this.nome = "Superman";
            this.cor = "Azul";
            this.idade = 30;
            this.altura = 1.90;
            this.genero = "M";

            public void RaioLaser() {
                Console.WriteLine("Superman está utilizando seu raio laser.");
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            Batman batman = new Batman();
            Superman superman = new Superman();

            Console.WriteLine($"Nome: {batman.Name}, Cor: {batman.Cor}, Idade: {batman.Idade}, Altura: {batman.Altura}, Gênero: {batman.Genero}");

            batman.Correr();
            batman.Pular();
            batman.CinturaoDeUtilidades();

            Console.WriteLine();
            Console.WriteLine($"Nome: {superman.Name}, Cor: {superman.Cor}, Idade: {superman.Idade}, Altura: {superman.Altura}, Gênero: {superman.Genero}");

            superman.Correr();
            superman.Pular();
            superman.RaioLaser();
        }
    }


using System;

interface IAtacante {
    void Atacar();
}
public abstract class Heroi {
    private string nome;
    private int nivel;
    private string elemento;

    public Heroi(string nome, int nivel, string elemento) {
        this.nome = nome;
        this.nivel = nivel;
        this.elemento = elemento;
    } 

    // Getter para o nome 
    public string GetNome(){
        return nome;
    }
    // Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }
    // Getter para o nivel
    public int GetNivel(){
        return nivel;
    }
    // Setter para o nivel
    public void SetNivel(int nivel){
        this.nivel = nivel;
    }
    // Getter para o elemento
    public string GetElemento(){
        return elemento;
    }
    // Setter para o elemento
    public void SetElemento(string elemento){
        this.elemento = elemento;
    }
    public abstract void Especial();
}

public class Paladino : Heroi, IAtacante {
    public Paladino(string nome, int nivel, string elemento) : base(nome, nivel, elemento) {}

    public override void Especial() {
        Console.WriteLine($"{GetNome()} invoca o espirito da luz para te ajudar!");
    }
    public void Atacar() {
        Console.WriteLine($"{GetNome()} ataca com sua espada de luz!");
    }
}
public class Barbaro : Heroi, IAtacante {
    public Barbaro(string nome, int nivel, string elemento) : base(nome, nivel, elemento) {}

    public override void Especial() {
        Console.WriteLine($"{GetNome()} fica furioso aumentando sua velocidade de ataque e dano!");
    }
    public void Atacar() {
        Console.WriteLine($"{GetNome()} ataca com seu machado sangrento!");
    }
}

public class Ladino : Heroi, IAtacante {
    public Ladino(string nome, int nivel, string elemento) : base(nome, nivel, elemento) {}

    public override void Especial() {
        Console.WriteLine($"{GetNome()} escurece a regiao possibilitando o ataque escuro por toda a regiAo de sombra!");
    }
    public void Atacar() {
        Console.WriteLine($"{GetNome()} ataca com suas adagas da escuridao!");
    }
}

public class Program {
    public static void Main(string[] args) {

        Paladino paladino = new Paladino("Cristovao", 50, "Luz");
        Barbaro barbaro = new Barbaro("Guilherme", 350, "Terra");
        Ladino ladino = new Ladino("Christopher", 1000, "Sombra");

        paladino.Atacar();
        barbaro.Atacar();
        ladino.Atacar();

        paladino.Especial();
        barbaro.Especial();
        ladino.Especial();
    }    
}
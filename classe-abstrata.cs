using System;

public abstract class NivelNinja {
    private string nome;
    private string aldeia;
    private string estilo;
    private int energia;

    public NivelNinja(string nome, string aldeia, string estilo, int energia) {
        this.nome = nome;
        this.aldeia = aldeia;
        this.estilo = estilo;
        this.energia = energia;
    } 

    // Getter para o nome 
    public string GetNome(){
        return nome;
    }
    // Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }
    // Getter para o aldeia
    public string GetAldeia(){
        return aldeia;
    }
    // Setter para o aldeia
    public void SetAldeia(string aldeia){
        this.aldeia = aldeia;
    }
    // Getter para o estilo
    public string GetEstilo(){
        return estilo;
    }
    // Setter para o estilo
    public void SetEstilo(string estilo){
        this.estilo = estilo;
    }
    // Getter para o energia
    public int GetEnergia(){
        return energia;
    }
    // Setter para o nome
    public void SetEnergia(int energia){
        this.energia = energia;
    }
    public abstract void Jutsu();

    public abstract void EquipamentoNinja();

    public void GastarChakra(int chakra) {
        energia -= chakra;
        Console.WriteLine($"{nome} gastou {chakra} de {energia} de energia.");
        if (energia <= 0) {
            Desmaiar();
        }
    }    

    public void Cansar() {
        Console.WriteLine($"{nome} cansou!");
    }

    private void Desmaiar() {
        Console.WriteLine($"{nome} desmaiou!");
    }
}

public class Chunnin : NivelNinja {
    public Chunnin(string nome, string aldeia, string estilo, int energia) : base(nome, aldeia, estilo, energia) {}

    public override void Jutsu() {
        Console.WriteLine($"{GetNome()} usa o jutsu bola de fogo!");
    }

    public override void EquipamentoNinja() {
        Console.WriteLine($"{GetNome()} utiliza a kunai da sua mochila!");
    }
}

public class Gennin : NivelNinja {
    public Gennin(string nome, string aldeia, string estilo, int energia) : base(nome, aldeia, estilo, energia) {}

    public override void Jutsu() {
        Console.WriteLine($"{GetNome()} usa o jutsu de substituição!");
    }

    public override void EquipamentoNinja() {
        Console.WriteLine($"{GetNome()} utiliza a shuriken da sua mochila!");
    }
}

public class Jounnin : NivelNinja {
    public Jounnin(string nome, string aldeia, string estilo, int energia) : base(nome, aldeia, estilo, energia) {}

    public override void Jutsu() {
        Console.WriteLine($"{GetNome()} usa o jutsu de invocação!");
    }

    public override void EquipamentoNinja() {
        Console.WriteLine($"{GetNome()} utiliza o papel bomba da sua mochila!");
    }
}

public class Program {
    public static void Main(string[] args) {
        Chunnin chunnin = new Chunnin("Eduardo", "Aldeia do Som", "Estilo raio", 200);
        chunnin.Jutsu();
        chunnin.EquipamentoNinja();
        chunnin.GastarChakra(200);

        Gennin gennin = new Gennin("Samuel", "Aldeia da Chuva", "Estilo fogo", 400);
        gennin.Jutsu();
        gennin.EquipamentoNinja();
        gennin.GastarChakra(350);

        Jounnin jounnin = new Jounnin("Juan", "Aldeia da Areia", "Estilo pedra", 800);
        jounnin.Jutsu();
        jounnin.EquipamentoNinja();
        jounnin.GastarChakra(600);
    }    
}
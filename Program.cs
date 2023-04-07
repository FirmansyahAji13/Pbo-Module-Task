using System;

public class Program{
    static void Main(string[] args){
        Laptop laptop1 = new Vivobook(new Nvidia(), new Corei5());
        Laptop laptop2 = new IdeaPad(new AMDv(), new Ryzen());
        Predator predator = new Predator(new AMDv(), new Corei7());

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        // laptop1.Ngoding();

        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.proc.merk);
        Console.WriteLine(laptop1.proc.type);

        predator.BermainGame();

        ACER acer = new Predator(new AMDv(), new Corei7());
        // acer.BermainGame();
    }
}

public class Processor{
    public string merk;
    public string type;

    public Processor(string merk, string type){
        this.merk = merk;
        this.type = type;
    }
}

public class Intel : Processor{
    public Intel(string type) : base("Intel", type){
    }
}

public class Amd : Processor{
    public Amd(string type) : base("AMD", type){
    }
}

public class Ryzen : Amd{
    public Ryzen() : base("Rayzen"){
    }
}

public class Athlon : Amd{
    public Athlon() : base("Athlon"){
    }
}

public class Corei3 : Intel{
    public Corei3() : base("Core i3"){
    }
}

public class Corei5 : Intel{
    public Corei5() : base("Core i5"){
    }
}

public class Corei7 : Intel{
    public Corei7() : base("Core i7"){
    }
}

public class VGA{
    public string merk;

    public VGA(string merk){
        this.merk = merk;
    }
}

public class AMDv : VGA{
    public AMDv() : base("AMD"){
    }
}

public class Nvidia : VGA{
    public Nvidia() : base("Nvidia"){
    }
}

public class Laptop{
    public string merk;
    public string type;
    public VGA vga;
    public Processor proc;

    public Laptop(string merk, string type, VGA vga, Processor proc)
    {
        this.merk = merk;
        this.type = type;
        this.vga = vga;
        this.proc = proc;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop " + merk + " " + type + " menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop " + merk + " " + type + " mati");
    }
}

public class Lenovo : Laptop
{
    public Lenovo(string type, VGA vga, Processor proc) : base("Lenovo", type, vga, proc){
    }
}

public class ACER : Laptop
{
    public ACER(string type, VGA vga, Processor proc) : base("ACER", type, vga, proc){
    }
}

public class ASUS : Laptop{
    public ASUS(string type, VGA vga, Processor proc) : base("ASUS", type, vga, proc){
    }
}

public class IdeaPad : Lenovo
{
    public IdeaPad(VGA vga, Processor proc) : base("IdeaPad", vga, proc){
    }
}

public class Legion : Lenovo
{
    public Legion(VGA vga, Processor proc) : base("Legion", vga, proc){
    }
}

public class Swift : ACER
{
    public Swift(VGA vga, Processor proc) : base("Swift", vga, proc){
    }
}

public class Predator : ACER
{
    public Predator(VGA vga, Processor proc) : base("Predator", vga, proc){
    }

    public void BermainGame()
    {
        Console.WriteLine("Laptop " + merk + " " + type + " sedang memainkan game", merk, type);
    }
}

public class ROG : ASUS{
    public ROG(VGA vga, Processor proc) : base("ROG", vga, proc){
    }
}

public class Vivobook : ASUS{
    public Vivobook(VGA vga, Processor proc) : base("Vivobook", vga, proc){
    }

    public void Ngoding(){
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
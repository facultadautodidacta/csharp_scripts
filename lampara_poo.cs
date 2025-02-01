 class Lampara
 {
     private bool encendido;
     //constructor
     public Lampara()
     {
         this.encendido = false;
     }
     private bool estaEncendida()
     {
         return this.encendido;
     }
     public void encender()
     {
         if (!this.estaEncendida())
         {
             this.encendido = true;
             Console.WriteLine("Lampara encendida");
         } else
         {
             Console.WriteLine("La Lampara ya esta encendida");
         }
     }
     public void apagar()
     {
         if (this.encendido)
         {
             this.encendido = false;
             Console.WriteLine("La lampara se ha apagado");
         } else
         {
             Console.WriteLine("Ya estaba apagada");
         }
     }
     public void mostrarEstado()
     {
         if (this.estaEncendida())
         {
             Console.WriteLine("Esta encendida");
         } else
         {
             Console.WriteLine("Esta apagada");
         }
     }

 }
 internal class Program
 {
     static void Main(string[] args)
     {
         Lampara lampara = new Lampara();
         lampara.mostrarEstado();
         lampara.encender();
         lampara.mostrarEstado();
         lampara.apagar();
         lampara.mostrarEstado();
     }
 }

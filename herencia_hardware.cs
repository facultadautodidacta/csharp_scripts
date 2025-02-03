namespace herencia_hardware
{
    class Hardware
    {
        public string _nombre;
        public string _fabricante;
        public Hardware(string nombre, string fabricante)
        {
            this._nombre = nombre;
            this._fabricante = fabricante;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine($"Hardaware {this._nombre}" 
                + $" Fabricante {this._fabricante}");
        }
    }
    class Processador : Hardware
    {
        public int _nucleos;
        public Processador(string nombre, string fabricante, 
                              int nucleos) : base(nombre, fabricante)
        {
            this._nucleos = nucleos;
        }
        public void mostrarDetallesProcessador()
        {
            this.mostrarInformacion();
            Console.WriteLine($"Los nucleos son {this._nucleos}");
        }
    }
    class MemoriaRam : Hardware
    {
        public int _capacidadGB;
        public MemoriaRam(string nombre, string fabricante,
                            int capacidadGB) : base(nombre, fabricante)
        {
            this._capacidadGB = capacidadGB;
        }
        public void mostrarDetallesRAM()
        {
            this.mostrarInformacion();
            Console.WriteLine($"Los GB de ram son {this._capacidadGB}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Processador processador = new Processador("Ryzen 5", 
                "AMD", 6);
            processador.mostrarDetallesProcessador();
            Console.WriteLine("*****************************");
            MemoriaRam mem = new MemoriaRam("Rampage","Kingston",32);
            mem.mostrarDetallesRAM();
        }
    }
}

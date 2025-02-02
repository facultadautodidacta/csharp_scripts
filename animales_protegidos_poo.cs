namespace animales
{
    class Animal
    {
        //atributos
        protected string _nombre;
        //constructor
        public Animal(string nombre)
        {
            _nombre = nombre;
        }
        protected void EmitirSonido()
        {
            Console.WriteLine("Este animal hace sonido");
        }
        public void obtener_nombre()
        {
            Console.WriteLine("El nombre " + this._nombre);
        }
        
    }
    class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }
        public void Ladrar()
        {
            Console.WriteLine(this._nombre + " esta ladrando");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal("Rex");
            perro.obtener_nombre();
        }
    }
}

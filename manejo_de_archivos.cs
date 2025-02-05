using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class Archivos
    {
        public string ruta = "D:\\Documentos\\2025\\IO\\Archivos\\Archivos";
        public string nombreArchivo = "prueba.txt";
        //crear un archivo y escribir sobre el
        public void crearArchivo()
        {
            File.WriteAllText(this.ruta + "\\" + this.nombreArchivo, "Hola");
            Console.WriteLine("Archivo creado y escrito");
        }
        //Leer un archivo de texto
        public void leerArchivo()
        {
            string contenido = File.ReadAllText(this.ruta + "\\" + this.nombreArchivo);
            Console.WriteLine(contenido);
        }
        //Añadir texto a un archivo existente
        public void agregarTexto()
        {
            string archivo = this.ruta + "\\" + this.nombreArchivo;
            File.AppendAllText(archivo, "\nAutodidactas");
            Console.WriteLine("texto agregado con exito");
        }
        //Leer un archivo línea por línea
        public void leerLineas()
        {
            string archivo = this.ruta + "\\" + this.nombreArchivo;
            string[] lineas = File.ReadAllLines(archivo);
            int contador = 1;
            foreach (string line in lineas) { 
                Console.WriteLine(line);
                Console.WriteLine("Linea numero " + contador++);
            }
        }
        //Manejo de excepciones
        public void excepcionArchivo()
        {
            try
            {
                this.leerArchivo();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("No se encontro el archivo");
            }
        }
        //Copiar un archivo
        public void copiarArchivo()
        {
            string origen = this.ruta + "\\" + this.nombreArchivo;
            string destino = this.ruta + "\\" + "copia_prueba.txt";
            File.Copy(origen, destino, true);
            Console.WriteLine("El archivo fue copiado");
        }
        //Listar archivos en un directorio
        public void listarArchivos()
        {
            string directorio = this.ruta;
            string[] archivos = Directory.GetFiles(directorio);
            foreach (string archivo in archivos)
            {
                Console.WriteLine(archivo);
            }
        }
        //Crear un directorio o carpeta
        public void crearCarpeta()
        {
            string directorio = this.ruta + "\\" + "carpeta_autodidacta";
            Directory.CreateDirectory(directorio);
            Console.WriteLine("Carpeta creada");
        }
        //eliminar un archivo
        public void eliminarArchivo()
        {
            string origen = this.ruta + "\\" + "copia_prueba.txt";
            File.Delete(origen);
            Console.WriteLine("Archivo eliminado!!");
        }
        //verificar si un archivo existe
        public void existeArchivo()
        {
            string archivo = this.ruta + "\\" + "copia_prueba.txt";
            if (File.Exists(archivo))
            {
                Console.WriteLine("El archivo existe");
            } else
            {
                Console.WriteLine("El archivo ya no existe :(");
            }
        }

        //Mover un archivo
        public void moverArchivo()
        {
            string origen = this.ruta + "\\" + this.nombreArchivo;
            string destino = this.ruta + "\\" + "carpeta_autodidacta\\" + this.nombreArchivo;
            File.Move(origen, destino);
            Console.WriteLine("Archivo movido con exito!");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Archivos archivos = new Archivos();
            archivos.moverArchivo();
        }
    }
}

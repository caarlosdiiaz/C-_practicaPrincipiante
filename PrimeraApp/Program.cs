using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.Title = "Emanuel DobleA";
            song.Seconds = 200;
            song.Position = new ShelvePosition(1, 1);
            song.play();

            Song song2 = new Song();
            song2.Title = "Emanuel DobleA";
            song2.Seconds = 120;
            song2.Position = new ShelvePosition(1, 2);
            song2.play();

            PlayList<Song> playListSongs = new PlayList<Song>();

            playListSongs.AddSong(song);
            playListSongs.AddSong(song2);

            WriteLineSpecial(song, "Starting with", "Enjoy");

            Console.WriteLine(song2.ToString());

            Tuple <int, string, Song> tupla = new Tuple <int , string, Song>(3, "Yes", song);

            // Diferentes explicaciones
            ListExplanation();
            StackExplanation();
            QueueExplanation();
            DictionaryExplanation();

            Console.ReadKey();
        }

        //ArrayList, la más usada
        private static void ListExplanation() {
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            //numbers.Count();
        }

        private static void StackExplanation() {
            Stack<Song> salesSongs = new Stack<Song>();

            //Meter nueva cancion
            salesSongs.Push(new Song());
            //Sacar canciones
            salesSongs.Pop();
        }

        //Crear una "cola"
        private static void QueueExplanation() {
            Queue<int> queueNumbers = new Queue<int>();
            //Poner x en la posicion [x]
            queueNumbers.Enqueue(1);
            //Retorna el primero de la cola y lo almacena en variable
            int firstNumber = queueNumbers.Dequeue();
        }

        private static void DictionaryExplanation()
        {
            // Creamos un diccionario con una clave y una clase
            // La clase es irrepetible, saltaría error
            Dictionary<string, Client> clients = new Dictionary<string, Client>();

            clients.Add("54173986Q", new Client() { Name = "Carlos Diaz" });
            // Comprobar si ya existe x clave
            if (!clients.ContainsKey("54173986Q")) 
            {
                clients.Add("54173986Q", new Client() { Name = "Carlos Diaz" });
            }

            // Sobreescribir un cliente a partir de su clave
            clients["54173986Q"] = new Client();

            // Almacenar los valores del cliente con x clave en una variable
            Client myClient = clients[" 54173986Q"];

            // Mostrar x de todos los datos del diccionario
            // En este caso la clave
            foreach (KeyValuePair<string, Client> keyValue in clients)
            {
                Console.WriteLine(keyValue.Key);
            }

            var elements = new List<KeyValuePair<string, Client>>();
            elements.Add(new KeyValuePair<string, Client>("54173985S", new Client()));
            elements.Add(new KeyValuePair<string, Client>("54173987V", new Client()));

            // Añadir mas de uno (Clase utils)
            //Utils.AddRangeDictionary(clients, elements);
           
            // tambien creado en Utils
            clients.AddRange(elements);
        }

        //Añadir x caracteristicas de una canción
        static void WriteLineSpecial<T>(T data, string prefix, string suffix) {
            Console.WriteLine($"{prefix}, {data}, {suffix}");
        }

        //Diferentes variables en C#
        static void Variables()
        {
            int number = 100;
            double numerboDecimal = 20.20d;
            bool sioNo = true;
            string hola = "Hola Mundo";
        }

        //Condicionales en C#
        static void condicional()
        {
            int number = 10;
            if (number == 10) Console.WriteLine("Es 10");
            else if (number > 10) Console.WriteLine("No es 10 y es mayor a 10");
            else Console.WriteLine("No es 10 y es menor a 10");
            switch (number) {
                case 0: Console.WriteLine("Es 0");
                    break;
                case 10: Console.WriteLine("Es 10");
                    break;
                case 20: Console.WriteLine("Es 20");
                    break;
                default: Console.WriteLine("No se, soy un gordo");
                    break;
            }
        }

        //Bucles en C#
        static void bucles()
        {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }
            int x = 0;
            while (x != 10) {
                x++;
                Console.WriteLine(x);
            }
            int[] numeros = new int[5] {1, 2, 3, 4, 5};
            foreach (int num in numeros) {
                
            }
        }
    }
}
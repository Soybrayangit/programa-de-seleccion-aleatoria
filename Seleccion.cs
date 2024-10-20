using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        
        
        Console.WriteLine("****************************************************************");
        Console.WriteLine("****************************************************************");
        Console.WriteLine("BIENVENIDOS/AS AL PROGRAMA DE SELECCION ALEATORIA DE ESTUDIANTES");
        Console.WriteLine("****************************************************************");
        Console.WriteLine("****************************************************************");

        // Se declara la lista que se va a usar en el programa
       
        List<string> alumnos = new List<string>
        {
        "Albany Nicole Solano Montero",
        "Alvaro Estefan Santana Corporan",
        "Anderson David Montero González",
        "Andy Muñoz Capellan",
        "Antony Jose Mendez Guerrero",
        "Benjamin Aguero Madera",
        "Carlos Daniel Tejada Marte",
        "Carlos Enrique Matos Feliz",
        "Cristopher Franco Veras",
        "Cruz Abel Montero Mercado",
        "Daimon Alexander Aquino Chalas",
        "Dariana Cabreja Castillo",
        "Darlyn Olivo Payano",
        "Denzel Alexander Rodriguez Ferreras",
        "Elías Manuel Rosario Rosario",
        "Emil Junior Piron Marcelo",
        "Ernesto Antonio Castillo Herrera",
        "Fernando Brayan Juliao De Los Santos",
        "Francisco Jose Lopez Ozuna",
        "Génesis Jahel Mojica Mateo",
        "Jan Marco Romero Peralta",
        "Jesús Alejandro Peña Soto",
        "Jhon Axell Almanzar Fernandez",
        "Joely Morales",
        "José Ismael León Cuevas",
        "Joseph Ruben Lopez Feliz",
        "Kelvin Andres Feliz Santana",
        "Luis Alejandro Hernandez Gonzalez",
        "Luis Francisco Geronimo Dipp",
        "Meinard Martínez Beltres",
        "Nicole Tremols Samboy",
        "Nicolle Batista Soto",
        "Oliver Abreu Mateo",
        "Omar De Jesus Fajardo Burgos",
        "Roither Sanchez Sosa",
        "Ryan Svelti Dominguez",
        "Sebastian Valdez Espaillat",
        "Tahis Paola Hernandez Sanchez",
        "Thomas De Los Santos Aracena De La Cruz",
        "Waniel Alexander Torres Ramírez",
        "Waskar Enrique Añil",
        "Yanser Manuel Núñez Rodríguez",
        "Yeicol Jose Camacho Calderon",
        "Yeremy Sánchez Rodríguez"
        };

        List<string> elegidos = new List<string>();

        int primerInfeliz;
        int segundoInfeliz;

        // Se instancia la clase Random para generar numeros aleatorios
        Random random = new Random();

        Console.WriteLine("Presione Espacio para obtener 2 estudiantes");

        // Se utiliza un ciclo infinito para detectar cuando se presiona
        // una tecla
        while (true)
        {
            Console.ReadKey();
            Console.WriteLine("\n");

            // Se buscan 2 numeros aleatorios del 0 al 43
            primerInfeliz = random.Next(0, 43);
            segundoInfeliz = random.Next(0, 43);

            // Se verifica que el primer numero nunca sea igual al segundo
            while (primerInfeliz == segundoInfeliz)
            {
                segundoInfeliz = random.Next(0, 43);
            }

            // Se verifica que no salgan numeros que ya salieron anteriormente
            // comparando el array alumnos con el array elegidos
            while (elegidos.Contains(alumnos[primerInfeliz]))
            {
                primerInfeliz = random.Next(0, 43);
            }

            while (elegidos.Contains(alumnos[segundoInfeliz]))
            {
                segundoInfeliz = random.Next(0, 43);
            }

            // Se termina el programa cuando ya no queden alumnos por elegir
            if (elegidos.Count == alumnos.Count) {
                Console.WriteLine("Ya no quedan estudiantes");
                Console.WriteLine("Presione cualquier tecla para finalizar\n");
                Console.ReadKey();
                break;
            }

            Console.WriteLine(alumnos[primerInfeliz] + " debe asignar un programa.");
            Console.WriteLine(alumnos[segundoInfeliz] + " debe hacer el programa asignado en vivo.");

            // Se agrega a una lista secundaria los numeros que ya fueron elegidos
            // para luego compararlos y evitar que se repitan
            elegidos.Add(alumnos[primerInfeliz]);
            elegidos.Add(alumnos[segundoInfeliz]);

            Console.WriteLine("\nPresione Espacio para continuar\nPresione Ctrl + C para terminar\n");
        }
    }
}




/*
 * EXERCISE 51
 * Description
 * Create a dictionary with the following key value pairs: 
 * hello => hola, food => comida, world => mundo, computer => computadora, exercise => ejercicio.  
 * Prompt the user to enter a word and output the translation.
 * 
 * stretch - TRy using the Contains key method.
 * https://www.dotnetperls.com/containskey ...
 * 
 * 
 * */

Dictionary<string, string> variableWord = new Dictionary<string, string>();
variableWord.Add("hello", "hola");
variableWord.Add("food", "comida");
variableWord.Add("world", "mundo");
variableWord.Add("computer", "computadora");
variableWord.Add("exercise", "ejercicio");

foreach (KeyValuePair<string, string> word in variableWord)
{
    Console.WriteLine($"{word.Key}"); // - {word.Value}");
}

// Another way to instantiate a dictionary
Dictionary<string, string> anotherWord = new Dictionary<string, string>()
{
    {"coffe", "café" },
    {"tea", "té" },
    {"milk", "leche" },
    {"creamer", "crema" },
    {"sugar", "azúcar" },
    {"honey", "miel" },
    {"sweet and low", "dulce y bajo" },
    {"equal", "igual" }
};

foreach (KeyValuePair<string, string> word in anotherWord)
{
    Console.WriteLine($"{word.Key}"); // - {word.Value}");
}


var yn = "y";

while (yn == "y")
{
    Console.WriteLine();
    Console.Write("Please enter a word to translate from the list: ");
    var userInput = Console.ReadLine().ToLower();

    if (variableWord.ContainsKey(userInput))
    {
        Console.WriteLine($"Your word, '{userInput}', translated to Spanish is '{variableWord[userInput]}'");
        Console.WriteLine();
    }
    else if(anotherWord.ContainsKey(userInput))
    {
        Console.WriteLine($"Your word, '{userInput}', translated to Spanish is '{anotherWord[userInput]}'");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("I'll need you to enter one of the options from the list.");
    }

    Console.Write("Would you like to continue (y/n)? ");
    yn = Console.ReadLine().ToLower();
}
var message = readFile("message_01.txt");
var palabras = message.Split(' ');

var animales = new List<Animal>();
foreach (var palabra in palabras)
{
    var animalItem = animales.FirstOrDefault(a => a.nombre == palabra);
    if (animalItem == null)
    {
        animales.Add(new Animal { nombre = palabra, ocurrencias = 1 });
    }
    else
    {
        animalItem.ocurrencias++;
    }
}

foreach (var animal in animales)
{
    Console.Write($"{animal.nombre}{animal.ocurrencias}");
}

string readFile(string file)
{    
    return File.ReadAllText(file);
}

class Animal {
    public string nombre { get; set; } = "";
    public int ocurrencias { get; set; } = 0;
}
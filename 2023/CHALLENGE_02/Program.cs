// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
var message = readFile("message_02.txt");
var instrucciones = message.ToCharArray();

var value = 0;
var result = string.Empty;

// Console.WriteLine(message);
// Console.WriteLine($"Instrucciones: {instrucciones.Count()}");

foreach (var instruccion in instrucciones)
{
    // Console.Write(@$"[{value}]");
    switch (instruccion)
    {
        case '#':
            // Increment
            value++;
            //Console.Write(@$"[{value}]+1");
            break;
        case '@':
            // decrement
            value--;
            // Console.Write(@$"[{value}]-1");
            break;
        case '*':
            //Multiply
            value = value * value;
            // Console.Write(@$"[{value}]**");
            break;
        case '&':
            //print            
            //result.Concat(value.ToString());
            result += value;
            //Console.Write(@$"[{value}]PRINT[{result}]");
            break;
    }
}

Console.WriteLine(result);



string readFile(string file)
{
    return File.ReadAllText(file);
}
//024899455
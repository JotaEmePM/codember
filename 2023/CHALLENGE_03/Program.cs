using System;
using System.Linq;

var encriptionsCodes = readFile("encryption_policies.txt");

string[] lines = encriptionsCodes.Split(
    new string[] { Environment.NewLine },
    StringSplitOptions.None
);

int i = 0;
foreach (var code in lines)
{
    var isValid = true;
    var rule = code.Split(":");
    var pass = rule[1];
    var ocurrencias = rule[0].Split(" ")[0].Split("-");

    int min = Convert.ToInt32(ocurrencias[0]);
    int max = Convert.ToInt32(ocurrencias[0]);

    char letra = char.Parse(rule[0].Split(" ")[1]);

    int freq = pass.Count(c => (c == (char)letra));


    if (min > freq || max < freq)
        isValid = false;


    if (!isValid) i++;
    Console.WriteLine($"code: {code} -> pass: {pass} | min: {ocurrencias[0]} | max: {ocurrencias[1]} | caracter: {letra} frec: {freq} | isValid: {isValid.ToString()} index: {i.ToString()}");





}




string readFile(string file)
{
    return File.ReadAllText(file);
}
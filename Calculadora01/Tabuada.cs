using System;

public class Tabuada
{
    public static void Program()
    {

        List<String> names = new List<String>();

        names.Add("Fulano 01");
        names.Add("Lucas Bretzke");
        names.Add("Fulano");
        names.Add("Fulano");
        names.Add("Fulano");

        Console.WriteLine(names.Contains("Lucas Bretzke") ? "Existe" : "Não existe");
    }

}

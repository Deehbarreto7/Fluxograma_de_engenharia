string estaMovendoTexto, deveriaTexto;
bool estaMovendo, deveria;

Console.WriteLine("Fluxograma da Engenharia");

Console.Write("O Objeto está se movendo? ");
estaMovendoTexto = Console.ReadLine()!;


Console.Write("Deveria? ");
deveriaTexto = Console.ReadLine()!;


estaMovendo = estaMovendoTexto.ToUpper().Substring(0,1) == "S";

deveria = deveriaTexto.ToUpper().Substring(0,1) == "S";


if (estaMovendo && !deveria)
{
    Console.WriteLine("Use Silver Tape.");
}
else if (!estaMovendo && deveria)
{
    Console.WriteLine("Use WD-40.");
}
else 
{
    Console.WriteLine("Ótimo");
}


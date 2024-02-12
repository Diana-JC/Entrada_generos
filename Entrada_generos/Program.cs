// See https://aka.ms/new-console-template for more information


// definir un metodo que reciba por parametro la edad y el genero de la persona y devuelva un mensje

Console.WriteLine("Ingrese su edad:");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su género ");
char genero = Convert.ToChar(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();


string mensaje = PedirDatos(edad, genero);
Console.WriteLine(mensaje);

Console.WriteLine();
Console.WriteLine();


static string PedirDatos(int edad, char genero)

{

    if (edad >= 18 && genero == 'f')
    {
        return "Puede pasar gratis.";
    }
    else if (edad >= 18 && genero == 'm')
    {
        return " Tiene que pagar para pasar.";
    }
    else
    {
        return "Eres menor, No puedes pasar";
    }

}

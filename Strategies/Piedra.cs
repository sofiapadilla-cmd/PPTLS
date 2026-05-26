namespace PPTLS.Strategies;

public class Piedra : IJugada
{
    public string Nombre => "Piedra";

    public string ResolverContra(IJugada oponente)
    {
        if (oponente is Tijera)
            return "Gana: Piedra rompe Tijera";

        //AGREGAR LAS DEMÁS REGLAS
    }
}

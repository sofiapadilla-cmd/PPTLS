using System.Windows.Automation;

namespace PPTLS.Strategies;

public class Tijera : IJugada
{
    public string Nombre => "Tijera";

    public string ResolverContra(IJugada oponente)
    {
         if (oponente is Tijera)
            return "Empate: Tijera y Tijera";

         if (oponente is Papel)
            return "Gana: Tijera corta Papel";

         if (oponente is Piedra)
            return "Pierde: Piedra aplasta Tijera";
        
        if (oponente is Spock)
            return "Pierde: Spock rompe Tijera";

        else
            return "Gana: Tijera decapita Lagarto";
    }
}

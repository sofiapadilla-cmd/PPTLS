using System.Windows.Automation;

namespace PPTLS.Strategies;

public class Lagarto : IJugada
{
    public string Nombre => "Lagarto";

    public string ResolverContra(IJugada oponente)
    {
         if (oponente is Tijera)
            return "Pierde: Tijera decapita Lagarto";

         if (oponente is Papel)
            return "Gana: Lagarto devora Papel";

         if (oponente is Piedra)
            return "Pierde: Piedra aplasta lagarto";
        
        if (oponente is Spock)
            return "Gana: Lagarto envenena Spock";

        else
            return "Empate: Lagarto y Lagarto";
    }
}

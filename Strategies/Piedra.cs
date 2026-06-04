using System.Windows.Automation;

namespace PPTLS.Strategies;

public class Piedra : IJugada
{
    public string Nombre => "Piedra";

    public string ResolverContra(IJugada oponente)
    {
        if (oponente is Tijera)
            return "Gana: Piedra rompe Tijera";

         if (oponente is Papel)
            return "Pierde: Papel envuelve Piedra";

         if (oponente is Piedra)
            return "Empate: Piedra y Piedra";
        
        if (oponente is Spock)
            return "Pierde: Spock vaporiza piedra";

        else
            return "Gana: Piedra aplasta lagarto";
    }
}

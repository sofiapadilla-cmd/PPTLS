using System.Windows.Automation;

namespace PPTLS.Strategies;

public class Spock : IJugada
{
    public string Nombre => "Spock";

    public string ResolverContra(IJugada oponente)
    {
         if (oponente is Tijera)
            return "Gana: Spock rompe Tijera";

         if (oponente is Papel)
            return "Pierde: Papel desautoriza Spock";

         if (oponente is Piedra)
            return "Gana: Spock vaporiza Piedra";
        
        if (oponente is Spock)
            return "Empate: Spock y Spock";

        else
            return "Pierde: Lagarto evenena Spock";
    }
}

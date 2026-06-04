using System.Windows.Automation;

namespace PPTLS.Strategies;

public class Papel : IJugada
{
    public string Nombre => "Piedra";

    public string ResolverContra(IJugada oponente)
    {
         if (oponente is Tijera)
            return "Pierde: Tijera corta Papel";

         if (oponente is Papel)
            return "Empate: Papel y Papel";

         if (oponente is Piedra)
            return "Gana: Papel envuelva Piedra";
        
        if (oponente is Spock)
            return "Gana: Papel desautoriza Spock";

        else
            return "Pierde: Lagarto devora Papel";
    }
}

using PPTLS.Strategies;

namespace PPTLS.Models;

public class Juego
{
    public Jugador JugadorHumano { get; private set; }
    public Jugador CPU { get; private set; }

    private List<IJugada> jugadas;
    private Random random;

    public int PuntosJugador { get; private set; }
    public int PuntosCPU { get; private set; }
    public int Empates { get; private set; }

    public Juego()
    {
        JugadorHumano = new Jugador("Jugador");
        CPU = new Jugador("CPU");

        jugadas = new List<IJugada>()
        {
            new Piedra(),
            new Papel(),
            new Tijera(),
            new Lagarto(),
            new Spock()
        };

        random = new Random();
    }

    public string Jugar(IJugada jugadaHumana)
    {
        JugadorHumano.ElegirJugada(jugadaHumana);
        //AQUÍ FALTA ALGO
        IJugada jugadaCPU = ObtenerJugadaAleatoria();
        string resultado = jugadaHumana.ResolverContra(jugadaCPU);

        ActualizarMarcador(resultado);

        return
            $"Jugador eligio: {jugadaHumana.Nombre}\n" +
            $"CPU eligio: {jugadaCPU.Nombre}\n" +
            $"{resultado}";
    }

    public string ActualizarMarcador(string resultado)
    {
        return resultado;
    }

    private IJugada ObtenerJugadaAleatoria()
    {
        int indice = random.Next(jugadas.Count);
        return jugadas[indice];
    }

 }

namespace PPTLS.Strategies;

public interface IJugada
{
    string Nombre { get; }
    string ResolverContra(IJugada oponente);
}

using System.Windows;
using PPTLS.Models;
using PPTLS.Strategies;

namespace PPTLS;

public partial class MainWindow : Window
{
    IJugada Jugada;
    private Juego juego;

    public MainWindow()
    {
        InitializeComponent();
        juego = new Juego();
    }

    private void BtnPiedra_Click(object sender, RoutedEventArgs e)
    {
        Jugada = new Piedra();
        MessageBox.Show(juego.Jugar(Jugada));
    }

    //AGREGAR LAS DEMÁS REGLAS
}

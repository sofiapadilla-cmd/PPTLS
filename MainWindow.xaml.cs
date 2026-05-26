using System.Windows;
using PPTLS.Models;
using PPTLS.Strategies;

namespace PPTLS;

public partial class MainWindow : Window
{
    private Juego juego;

    public MainWindow()
    {
        InitializeComponent();
        juego = new Juego();
    }

    private void BtnPiedra_Click(object sender, RoutedEventArgs e)
    {
        //ACCIÓN
    }

    //AGREGAR LAS DEMÁS REGLAS

    private void Jugar(IJugada jugada)
    {
        txtResultado.Text = juego.Jugar(jugada);
    }
}

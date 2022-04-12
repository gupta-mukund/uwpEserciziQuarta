using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=234238

namespace esercizio1
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        List<Libro> libri;
        public Page2()
        {
            this.InitializeComponent();
            libri = new List<Libro>();
            libri.Add(new Libro("Matematica a colori", "Matematica", "Petrini", "https://deascuola-nephila-bucket-prod.s3.amazonaws.com/catalogs/DEASCUOLA/draft/cover/by_opera/thumb/13092.jpg.413x500_q85.jpg"));
            libri.Add(new Libro("Cult", "Inglese", "DEA", "https://deascuola-nephila-bucket-prod.s3.amazonaws.com/catalogs/DEASCUOLA/draft/cover/by_opera/thumb/13014.jpg.413x500_q85.jpg"));
            //Binding bind = new Binding();
            //bind.Source = libri;
            //title.SetBinding(TextBlock.TextProperty, bind);
            this.DataContext = libri;

        }
    }
    public class Libro
    {
        public Libro(string titolo, string materia, string editore, string immagine)
        {
            Titolo = titolo;
            Materia = materia;
            Editore = editore;
            Immagine = immagine;
        }

        public string Titolo { get; set; }
        public string Materia { get; set; }
        public string Editore { get; set; }
        public string Immagine { get; set; }
    }
}

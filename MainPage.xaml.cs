using System;

namespace Dinosaurio;
/// <summary>
///<Createdate>28/06/2023</Createdate>
///<Company>SANDBOX</Company>
///<Lastmodificationdate>29/06/2023</Lastmodificationdate>
///<Lastmodificationdescription>
///se aplica la formula correcta para calcular el peso
///</Lastmodificationdescription>
///<Lastmodificationautor>Ingrid Gabriel</Lastmodificationautor>
/// </summary>

public partial class MainPage : ContentPage
{
    /// <summary>
    /// Constructor de la clase
    /// </summary>
    public MainPage()
    {
        InitializeComponent();
    }
    /// <summary>
    /// en el boton calcular se calculara el peso kg a lb 
    /// y la altura de mts a cm
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(peso.Text) || (!string.IsNullOrEmpty(altura.Text) ||(!string.IsNullOrEmpty(nombre.Text))))
        {
            double pesokg, alturamts, pesoLi, alturacms;
            pesokg = Convert.ToDouble(peso.Text);
            alturamts = Convert.ToDouble(altura.Text);

            pesoLi = pesokg * 2.2046 / 1;
            alturacms = alturamts * 100 / 1;

            pesoL.Text = pesoLi.ToString();
            Alturacm.Text = alturacms.ToString();
        }
        else
        {
            DisplayAlert("Error", "Introduce los datos requeridos", "OK");

        }
    }
}


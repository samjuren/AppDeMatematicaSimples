namespace AppDeMatematicaSimples;

public partial class MainPage : ContentPage
{
    int Num1, Num2, result;
    public MainPage()
	{
		InitializeComponent();
	}
    public void Btn_somar_Clicked(object sender, EventArgs e)
    {   
        if (Rd_Somar.IsChecked)
        {
            Num1 = int.Parse(Number1.Text);
            Num2 = int.Parse(Number2.Text);
            result = Num1 + Num2;

            DisplayAlert("SOMA", result.ToString(), "OK");
        }
        else if (Rd_Mult.IsChecked)
        {
            Num1 = int.Parse(Number1.Text);
            Num2 = int.Parse(Number2.Text);
            result = Num1 / Num2;

            DisplayAlert("Divisão", result.ToString(), "OK");
        }
        else if (Rd_Sub.IsChecked)
        {
            Num1 = int.Parse(Number1.Text);
            Num2 = int.Parse(Number2.Text);
            result = Num1 - Num2;

            DisplayAlert("Subtração", result.ToString(), "OK");
        }
        else
        {
            Num1 = int.Parse(Number1.Text);
            Num2 = int.Parse(Number2.Text);
            result = Num1 * Num2;

            DisplayAlert("Multipliacação", result.ToString(), "OK");
        }

    }
}


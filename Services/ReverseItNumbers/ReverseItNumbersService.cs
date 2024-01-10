namespace MiniChallengeFiveToSeven_Endpoints.Services.ReverseItNumbers;

public class ReverseItNumbersService : IReverseItNumbersService
{
    public string ReversedNumber(string number)
    {
        string reversed = "";
        if (double.TryParse(number, out double num))
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }
            return $"You entered {number}, reversed is {reversed}";
        }
        else
        {
            return "ERROR! You entered an invalid input, please enter in a number";
        }
    }
}

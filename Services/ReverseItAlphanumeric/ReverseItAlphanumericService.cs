namespace MiniChallengeFiveToSeven_Endpoints.Services.ReverseItAlphanumeric;

public class ReverseItAlphanumericService : IReverseItAlphanumericService
{
    public string ReverseIt(string alphanumeric)
    {
        string reversed = "";
            for(int i = alphanumeric.Length - 1; i >= 0; i--){
                reversed += alphanumeric[i];
            }
            return $"You entered {alphanumeric}, reversed is {reversed}";
    }
}

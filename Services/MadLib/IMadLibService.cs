namespace MiniChallengeFiveToSeven_Endpoints.Services.MadLib;

    public interface IMadLibService
    {
        string MadLib(string celebrityName, string animal, string bodyPart, string nounThatEndsWithS, string wholeNumberGreaterThan1, string time, string height, string adjective, string name, string condiment);
    }

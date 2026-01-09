class ATMApp
{
    static void Main()
    {
        ATMScenario[] scenarios =
        {
            new ScenarioA(),
            new ScenarioB(),
            new ScenarioC()
        };

        foreach (ATMScenario scenario in scenarios)
        {
            scenario.Execute();
        }
    }
}

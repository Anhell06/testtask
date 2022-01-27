using UnityEngine.UI;

internal class Program
{
    private IFactory factory;

    public Program(IFactory factory, Button buttonStart, Button buttonEnd)
    {
        this.factory = factory;
        buttonStart.onClick.AddListener(StartView);
        buttonEnd.onClick.AddListener(GoBack);
    }

    private void StartView()
    {
        factory.CreateAllBlocks();
        factory.ViewData();
    }

    private void GoBack()
    {
        factory.HideView();
    }
}
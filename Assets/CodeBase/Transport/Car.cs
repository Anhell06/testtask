using UnityEngine;

[CreateAssetMenu]
public class Car : Transport
{
    [SerializeField]
    private string Color = "";
    public override string GetText()
    {
        return base.GetText() + $"Цвет {Color}";
    }
}

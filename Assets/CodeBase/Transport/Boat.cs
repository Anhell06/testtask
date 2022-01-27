using UnityEngine;

[CreateAssetMenu]
public class Boat : Transport
{
    [SerializeField]
    private int Displacement = 2000;
    public override string GetText()
    {
        return base.GetText() + $"Водоизмещение {Displacement}";

    }
}

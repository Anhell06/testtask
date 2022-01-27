using UnityEngine;

[CreateAssetMenu]
public class Plane : Transport
{
    [SerializeField]
    private float Power = 0f;
    public override string GetText()
    {
        return base.GetText() + $"Подьемная сила {Power}";

    }
}

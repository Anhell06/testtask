
using System.Text;
using UnityEngine;

public abstract class Transport : ScriptableObject, IData
{
    [SerializeField]
    private string transportName;
    [SerializeField]
    private int mass;
    [SerializeField]
    private int cargo;
    [SerializeField]
    private int maxSpeed;
    [SerializeField]
    private Sprite image;

    public string ID => transportName;
    public Sprite Image => image;

    public virtual string GetText()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Масса {mass}");
        sb.AppendLine($"Вместимость {cargo}");
        sb.AppendLine($"Максимальная скорость {maxSpeed}");

        return sb.ToString();
    }
}

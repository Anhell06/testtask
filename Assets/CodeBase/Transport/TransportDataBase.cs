using UnityEngine;

internal class TransportDataBase : IDataBase
{
    private IData[] transport;

    public TransportDataBase(string dataBasePath)
    {
        transport = Resources.LoadAll<Transport>(dataBasePath);
    }

    public IData[] GetData()
    {
        return transport;
    }
}
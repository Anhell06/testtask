using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BootStrapper : MonoBehaviour
{
    [SerializeField]
    private Button buttonStart;
    [SerializeField]
    private Button buttonEnd;
    [SerializeField]
    private GameObject viewCanvas;
    [SerializeField]
    private GameObject block;
    [SerializeField]
    private string dataBasePath;

    private IDataBase dataBase;
    private Program program;
    private IFactory factory;

    private void Start()
    {
        dataBase = new TransportDataBase(dataBasePath);
        factory = new Factory(buttonStart, buttonEnd, dataBase.GetData(), viewCanvas, block);
        program = new Program(factory, buttonStart, buttonEnd);
    }
}

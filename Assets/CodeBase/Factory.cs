using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Factory : IFactory
{
    private Button buttonStart;
    private Button buttonEnd;
    private IData[] transports;
    private GameObject viewCanvas;
    private GameObject block;
    private List<GameObject> pool = new List<GameObject>();

    public Factory(Button buttonStart, Button buttonEnd, IData[] data, GameObject viewCanvas, GameObject block)
    {
        this.buttonStart = buttonStart;
        this.buttonEnd = buttonEnd;
        this.transports = data;
        this.viewCanvas = viewCanvas;
        this.block = block;
    }

    public void CreateAllBlocks()
    {
        foreach (var transport in transports)
        {
            CreateBlock(transport);
        }
    }

    public void HideView()
    {
        buttonStart.gameObject.SetActive(true);
        buttonEnd.gameObject.SetActive(false);
        viewCanvas.gameObject.SetActive(false);
        ClearData();
    }

    public void ViewData()
    {
        buttonStart.gameObject.SetActive(false);
        buttonEnd.gameObject.SetActive(true);
        viewCanvas.gameObject.SetActive(true);
    }

    private void ClearData()
    {
        foreach (var block in pool)
        {
            Object.Destroy(block);
        }
        pool.Clear();
    }

    private void CreateBlock(IData data)
    {
        GameObject cell = Object.Instantiate(block, viewCanvas.GetComponentInChildren<LayoutGroup>().transform);
        pool.Add(cell);


        BlockData blockData = cell.GetComponent<BlockData>();
        blockData.blockName.text = data.ID;
        blockData.image.sprite = data?.Image;
        blockData.text.text = data.GetText();
    }
}

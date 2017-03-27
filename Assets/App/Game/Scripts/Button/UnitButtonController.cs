using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitButtonController : MonoBehaviour
{
    public int mode = 0;
    public Image[] unitPanelImage;

    public void ButtonPush()
    {
        for (int i = 0; i < 6; i++)
        {
            unitPanelImage[i].enabled = !unitPanelImage[i].enabled;
        }
    }
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
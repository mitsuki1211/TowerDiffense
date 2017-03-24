using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
    public int mode = 0;
    public GameObject unitPanel;
    public GameObject obj;

    public void ButtonPush()
    {
        if(mode == 0)
        {
            
            obj.SetActive(true);
            mode = 1;
        }
        if(mode == 1)
        {
            obj.SetActive(false);
            mode = 0;
        }
    }
    // Use this for initialization
    void Start () {
        obj = Instantiate(unitPanel);
    }
	
	// Update is called once per frame
	void Update () {

	}
}

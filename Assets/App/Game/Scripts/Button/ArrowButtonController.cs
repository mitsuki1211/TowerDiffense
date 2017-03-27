using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButtonController : MonoBehaviour {
    public GameObject cursor;
    public static float posX = 1;
    public static float posY = 1;

    public void RightButtonPush()
    {
        posX = posX + 4; 
        cursor.transform.position = new Vector2 (posX,posY);
        Debug.Log("R");
    }
    public void LeftButtonPush()
    {
        posX = posX - 4;
        cursor.transform.position = new Vector2(posX, posY);        
        Debug.Log("L");
    }
    public void UpButtonPush()
    {
        posY = posY + 2;
        cursor.transform.position = new Vector2(posX, posY);
        Debug.Log("U");
    }
    public void DownButtonPush()
    {
        posY = posY - 2;
        cursor.transform.position = new Vector2(posX, posY);
        Debug.Log("D");
    }

    // Use this for initialization
    void Start () {
        posX = cursor.transform.position.x;
        posY = cursor.transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
}

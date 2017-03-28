using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.VersionControl;

public class AllyGenerator : MonoBehaviour {
    public GameObject allyPrefab1;
    public GameObject allyPrefab2;
    public GameObject allyPrefab3;
    public GameObject allyPrefab4;
    [SerializeField]
    private RectTransform mapParent;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AllyGenerate()
    {
        if (ButtonController.unitPosX < 0 && ButtonController.unitPosY > 0)
        {
            GameObject go = Instantiate(allyPrefab1) as GameObject;
            //親を設定
            go.transform.SetParent(mapParent);
            go.GetComponent<RectTransform>().localScale = Vector3.one;
            go.GetComponent<RectTransform>().localPosition = new Vector2(ButtonController.mapPosX, ButtonController.mapPosY);
            go.GetComponent<RectTransform>().sizeDelta = new Vector2(MapLoader.size, MapLoader.size);
        }
        if (ButtonController.unitPosX > 2 && ButtonController.unitPosY > 0)
        {
            GameObject go = Instantiate(allyPrefab2) as GameObject;
            //親を設定
            go.transform.SetParent(mapParent);
            go.GetComponent<RectTransform>().localScale = Vector3.one;
            go.GetComponent<RectTransform>().localPosition = new Vector2(ButtonController.mapPosX, ButtonController.mapPosY);
            go.GetComponent<RectTransform>().sizeDelta = new Vector2(MapLoader.size, MapLoader.size);
        }
        if (ButtonController.unitPosX < 0 && ButtonController.unitPosY < 0)
        {
            GameObject go = Instantiate(allyPrefab3) as GameObject;
            //親を設定
            go.transform.SetParent(mapParent);
            go.GetComponent<RectTransform>().localScale = Vector3.one;
            go.GetComponent<RectTransform>().localPosition = new Vector2(ButtonController.mapPosX, ButtonController.mapPosY);
            go.GetComponent<RectTransform>().sizeDelta = new Vector2(MapLoader.size, MapLoader.size);
        }
        if (ButtonController.unitPosX > 0 && ButtonController.unitPosY < 0)
        {
            GameObject go = Instantiate(allyPrefab4) as GameObject;
            //親を設定
            go.transform.SetParent(mapParent);
            go.GetComponent<RectTransform>().localScale = Vector3.one;
            go.GetComponent<RectTransform>().localPosition = new Vector2(ButtonController.mapPosX, ButtonController.mapPosY);
            go.GetComponent<RectTransform>().sizeDelta = new Vector2(MapLoader.size, MapLoader.size);
        }
    }
}

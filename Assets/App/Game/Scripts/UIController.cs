using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {
    public GameObject mapCursor;
    private GameObject hpText;
    [SerializeField]//privateな変数をインスペクタから設定できるようにするAttribute
    private RectTransform mapParent;
    [SerializeField]
    private Canvas canvas;

    // Use this for initialization
    void Start () {
        this.hpText = GameObject.Find("HP");
        mapCursor.transform.SetParent(mapParent);
        mapCursor.GetComponent<RectTransform>().localScale = Vector3.one;
        mapCursor.GetComponent<RectTransform>().sizeDelta = new Vector2(MapLoader.size, MapLoader.size);
        mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        this.hpText.GetComponent<Text>().text = "HP " + GameManager.hp.ToString();
    }
}

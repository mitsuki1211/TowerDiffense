using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.VersionControl;

public class AllyGenerator : MonoBehaviour {
    public GameObject allyPrefab;
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
        GameObject go = Instantiate(allyPrefab) as GameObject;
        //親を設定
        go.transform.SetParent(mapParent);
        go.transform.position = new Vector2(0.87f * 7, 0);
        go.GetComponent<RectTransform>().sizeDelta = new Vector2(0.87f, 0.87f);
    }
}

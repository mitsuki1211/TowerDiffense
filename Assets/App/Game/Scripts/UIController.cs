using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

    private GameObject hpText;
    // Use this for initialization
    void Start () {
        this.hpText = GameObject.Find("HP");
    }
	
	// Update is called once per frame
	void Update () {
        this.hpText.GetComponent<Text>().text = "HP " + GameManager.hp.ToString();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static int hp = 20;

	// Use this for initialization
	void Start () {
		
	}
	public static void Damage()
    {
        hp--;
    }
	// Update is called once per frame
	void Update () {
		if(hp == 0)
        {
            Debug.Log("GameOver");
        }

	}
}

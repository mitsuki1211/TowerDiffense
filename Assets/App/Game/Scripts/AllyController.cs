using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyController : MonoBehaviour {
    private int attack;
    private GameObject target;

    // Use this for initialization
    void Start() {
        BoxCollider2D bc = this.GetComponent<BoxCollider2D>();
        bc.size = new Vector2(MapLoader.size * 2, MapLoader.size * 2);
        bc.offset = new Vector2(MapLoader.size / 2, MapLoader.size / 2);
        attack = 1;
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            other.gameObject.tag = "Target";

            target = GameObject.FindGameObjectWithTag("Target");

            target.SendMessage("Damage");

            other.gameObject.tag = "Target";

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    private float speed = -0.16f;
    int x = 9;
    int y = 9;
    int count = 0;
    int time = 0;
    int stop = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time++;
        if (stop == 0)
        {
            if (time % 10 == 0) {
                if (MapManager.GetMapInfo(x - 1, y) == 1)
                {
                    transform.Translate(0, -this.speed, 0);
                    x--;
                    count = 1;
                }
                if (MapManager.GetMapInfo(x, y - 1) == 1 && count == 0)
                {
                    transform.Translate(this.speed, 0, 0);
                    y--;
                    count = 1;
                }
                if (MapManager.GetMapInfo(x - 1, y) == 2 && count == 0)
                {
                    transform.Translate(0, -this.speed, 0);
                    stop++;
                    GameManager.Damage();
                }
                if (MapManager.GetMapInfo(x, y - 1) == 2 && count == 0)
                {
                    transform.Translate(this.speed, 0, 0);
                    stop++;
                    GameManager.Damage();
                }
                count = 0;
            }
        }

    }
}

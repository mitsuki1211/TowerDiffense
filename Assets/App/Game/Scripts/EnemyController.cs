using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float posX;
    private float posY;
    private float speed;
    private int x = 9;
    private int y = 9;
    private int count = 0;
    private int time = 0;
    public int hp;

    // Use this for initialization
    void Start()
    {
        posX = MapLoader.size * (MapLoader.devide - 1);
        posY = 0;
        speed = MapLoader.size;
        x = MapLoader.devide - 1;
        y = MapLoader.devide - 1;
        hp = 2;


    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.gameState == GameManager.GameState.PLAY)
        {
            time++;
            if (time % 10 == 0)
            {
                if (MapManager.GetMapInfo(x - 1, y) == 1)
                {
                    posY = posY + speed;
                    this.GetComponent<RectTransform>().localPosition = new Vector2(posX, posY);
                    x--;
                    count = 1;
                }
                if (MapManager.GetMapInfo(x, y - 1) == 1 && count == 0)
                {
                    posX = posX - speed;
                    this.GetComponent<RectTransform>().localPosition = new Vector2(posX, posY);
                    y--;
                    count = 1;
                }
                if (MapManager.GetMapInfo(x - 1, y) == 2 && count == 0)
                {
                    posY = posY + speed;
                    this.GetComponent<RectTransform>().localPosition = new Vector2(posX, posY);
                    GameManager.Damage();
                    Destroy(gameObject);
                }
                if (MapManager.GetMapInfo(x, y - 1) == 2 && count == 0)
                {
                    posX = posX - speed;
                    this.GetComponent<RectTransform>().localPosition = new Vector2(posX, posY);
                    GameManager.Damage();
                    Destroy(gameObject);
                }
                count = 0;
            }

            if(hp == 0)
            {
                Destroy(this.gameObject);
                
            }
        }
    }

    public void Damage()
    {
        hp--;
        AudioClip clip = gameObject.GetComponent<AudioSource>().clip;
        gameObject.GetComponent<AudioSource>().PlayOneShot(clip);
    }
}


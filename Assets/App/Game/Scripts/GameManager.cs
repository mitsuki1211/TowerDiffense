using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static int hp;

    private int time;
    private GameObject enemyGenerator;

    public enum GameState
    {
        UNIT,
        PLAY,
        PAUSE,
        NONE,
        UNITPANEL         
    }

    public static GameState gameState;

    // Use this for initialization
    void Start()
    {
        gameState = GameState.PLAY;
        hp = 10;

        enemyGenerator = GameObject.Find("EnemyGenerator");
    }


    // Update is called once per frame
    void Update()
    {
        switch (gameState) {
            case GameState.PLAY:
                time++;
                if (hp == 0)
                {
                    gameState = GameState.NONE;
                }
                if (time % 40 == 0)
                {
                    enemyGenerator.SendMessage("EnemyGenerate");
                }
                break;

            case GameState.PAUSE:

                break;

            case GameState.UNIT:

                break;

            case GameState.NONE:
                break;
          }
    }

    public static void Damage()
    {
        if (hp > 0)
        {
            hp--;
        }        
    }
}
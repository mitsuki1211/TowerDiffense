using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int hp;

    private int time;
    private GameObject enemyGenerator;
    private GameObject allyGenerator;
    private GameObject enter;

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
        allyGenerator = GameObject.Find("AllyGenerator");
        enter = GameObject.Find("EnterButtonController");

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
                /*if(Input.GetKeyDown(KeyCode.Return))
                {
                    SceneManager.LoadSceneAsync("TowerDiffense");
                }*/
                break;
          }
    }

    public static void Damage()
    {
            hp--;        
    }

    public void EnterButtonPush()
    {
        switch (gameState)
        {
            case GameState.PLAY:               
                break;

            case GameState.PAUSE:
                break;

            case GameState.UNITPANEL:
                gameState = GameState.UNIT;
                break;

            case GameState.UNIT:
                allyGenerator.SendMessage("AllyGenerate");
                Debug.Log(1);
                break;


            case GameState.NONE:
                    SceneManager.LoadSceneAsync("TowerDiffense");
                break;
        }
    }

    public void UnitButtonPush()
    {
        switch (gameState)
        {
            case GameState.PLAY:
                gameState = GameState.UNITPANEL;
                break;

            case GameState.PAUSE:
                break;

            case GameState.UNITPANEL:
                break;

            case GameState.UNIT:
                break;

            case GameState.NONE:
                break;
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject unitCursor;
    public GameObject mapCursor;
    public static float unitPosX = 1;
    public static float unitPosY = 1;
    public static float mapPosX;
    public static float mapPosY;
    private float mapSize;
    public Image[] unitPanelImage;
    private GameObject allyGenerator;

    public void UnitButtonPush()
    {
        switch (GameManager.gameState)
        {
            case GameManager.GameState.PLAY:
                GameManager.gameState = GameManager.GameState.UNITPANEL;
                for (int i = 0; i < 7; i++)
                {
                    unitPanelImage[i].enabled = !unitPanelImage[i].enabled;
                }
                break;


            case GameManager.GameState.UNITPANEL:
                GameManager.gameState = GameManager.GameState.PLAY;
                for (int i = 0; i < 7; i++)
                {
                    unitPanelImage[i].enabled = !unitPanelImage[i].enabled;
                }
                break;

            case GameManager.GameState.UNIT:
                GameManager.gameState = GameManager.GameState.PLAY;
                break;
        }
        
    }

    public void RightButtonPush()
    {
        switch (GameManager.gameState)
        {
            case GameManager.GameState.PLAY:
                mapSize = MapLoader.size;
                mapPosX = mapPosX + mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNIT:
                mapSize = MapLoader.size;
                mapPosX = mapPosX + mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNITPANEL:
                if (unitPosX < 2)
                {
                    unitPosX = unitPosX + 3.8f;
                    unitCursor.transform.position = new Vector2(unitPosX, unitPosY);
                }
                break;
        }
    }

    public void LeftButtonPush()
    {
        switch (GameManager.gameState)
        {
            case GameManager.GameState.PLAY:
                mapSize = MapLoader.size;
                mapPosX = mapPosX - mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNIT:
                mapSize = MapLoader.size;
                mapPosX = mapPosX - mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNITPANEL:
                if (unitPosX > 2)
                {
                    unitPosX = unitPosX - 3.8f;
                    unitCursor.transform.position = new Vector2(unitPosX, unitPosY);
                }
                break;
        }
    }

    public void UpButtonPush()
    {
        switch (GameManager.gameState)
        {
            case GameManager.GameState.PLAY:
                mapSize = MapLoader.size;
                mapPosY = mapPosY + mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNIT:
                mapSize = MapLoader.size;
                mapPosY = mapPosY + mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNITPANEL:
                if (unitPosY < 0)
                {
                    unitPosY = unitPosY + 2.1f;
                    unitCursor.transform.position = new Vector2(unitPosX, unitPosY);
                }
                break;
        }
    }

    public void DownButtonPush()
    {
        switch (GameManager.gameState)
        {
            case GameManager.GameState.PLAY:
                mapSize = MapLoader.size;
                mapPosY = mapPosY - mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNIT:
                mapSize = MapLoader.size;
                mapPosY = mapPosY - mapSize;
                mapCursor.GetComponent<RectTransform>().localPosition = new Vector2(mapPosX, mapPosY);
                break;

            case GameManager.GameState.UNITPANEL:
                if (unitPosY > 0)
                {
                    unitPosY = unitPosY - 2.1f;
                    unitCursor.transform.position = new Vector2(unitPosX, unitPosY);
                }
                break;
        }
    }

    public void SpeedUpButtonPush()
    {
    }

    public void SpeedDownButtonPush()
    {
    }

    public void PauseButtonPush()
    {
        switch (GameManager.gameState)
        {
            case GameManager.GameState.PLAY:
                GameManager.gameState = GameManager.GameState.PAUSE;
                break;

            case GameManager.GameState.PAUSE:
                GameManager.gameState = GameManager.GameState.PLAY;
                break;
        }
    }

    public void EnterButtonPush()
    {
        switch(GameManager.gameState)
        {
            case GameManager.GameState.UNITPANEL:
                for (int i = 0; i < 7; i++)
                {
                    unitPanelImage[i].enabled = !unitPanelImage[i].enabled;
                }
                GameManager.gameState = GameManager.GameState.UNIT;
                break;

            case GameManager.GameState.UNIT:
                allyGenerator.SendMessage("AllyGenerate");
                GameManager.gameState = GameManager.GameState.PLAY;
                break;

            case GameManager.GameState.NONE:
                SceneManager.LoadScene("TowerDiffense");
                break;
        }

    }

    // Use this for initialization
    void Start()
    {
        unitPosX = unitCursor.transform.position.x;
        unitPosY = unitCursor.transform.position.y;
        mapPosX = mapCursor.transform.position.x;
        mapPosY = mapCursor.transform.position.y;

        allyGenerator = GameObject.Find("AllyGenerator");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.VersionControl;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    [SerializeField]
    private RectTransform mapParent;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void EnemyGenerate()
    {
        {
            GameObject go = Instantiate(enemyPrefab) as GameObject;
            //親を設定
            go.transform.SetParent(mapParent);
            go.GetComponent<RectTransform>().localScale = Vector3.one;
            go.GetComponent<RectTransform>().localPosition = new Vector2(MapLoader.size * (MapLoader.devide - 1), 0);
            go.GetComponent<RectTransform>().sizeDelta = new Vector2(MapLoader.size, MapLoader.size);
            BoxCollider2D bc = go.GetComponent<BoxCollider2D>();
            bc.size = new Vector2(MapLoader.size, MapLoader.size);
            bc.offset = new Vector2(MapLoader.size / 2, MapLoader.size / 2);
        }
    }
}
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
            go.transform.position = new Vector2(0.87f * 9, 0);
            go.GetComponent<RectTransform>().sizeDelta = new Vector2(0.87f, 0.87f);
        }
    }
}
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
    int time = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if (time % 20 == 0)
        {
            GameObject go = Instantiate(enemyPrefab) as GameObject;
            go.transform.parent = mapParent;
            go.transform.position = new Vector2(1.44f, 0);
        }
    }
}
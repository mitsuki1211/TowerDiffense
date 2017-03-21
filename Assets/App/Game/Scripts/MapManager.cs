using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {
    public static MapManager Singleton;

    void Start()
    {
    }

    public static int GetMapInfo(int x, int y)
    {
        int z = MapLoader.mapArray[x, y];
        return z;
    }
}
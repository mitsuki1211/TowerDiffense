using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MapLoader : MonoBehaviour
{
    int i;
    int j;
    public const int devide = 10;
    public GameObject road;
    public GameObject forest;
    public GameObject goal;
    public static float size;
    private float posX = 0;
    private float posY = 0;
    public static int[,] mapArray = new int[devide, devide];
    [SerializeField]//privateな変数をインスペクタから設定できるようにするAttribute
    private RectTransform mapParent;
    [SerializeField]
    private Canvas canvas;


    // Use this for initialization
    void Start()
    {
        float height = canvas.GetComponent<RectTransform>().rect.height;
        size = height / devide;

        for (i = 0; i >= devide; i++)
        {
            for (j = 0; j >= devide; j++)
            {
                mapArray[i, j] = 0;
            }
        }
        mapArray[devide - 1, devide - 1] = 1;
        mapArray[1, 1] = 2;

        i = 1;
        j = 1;

        while (i < (devide - 1) || j < (devide - 1))
        {
            int z = UnityEngine.Random.Range(0, 2);
            if (z == 1 && i < (devide - 1))
            {
                i++;
            }
            if (z == 0 && j < (devide - 1))
            {
                j++;
            }
            mapArray[i, j] = 1;
        }

        for (i = (devide - 1); i > -1; i--)
        {
            for (j = 0; j < devide; j++)
            {
                if (mapArray[i, j] == 1)
                {
                    GameObject go = Instantiate(road) as GameObject;
                    go.transform.SetParent(mapParent);
                    go.GetComponent<RectTransform>().localScale = Vector3.one;
                    go.GetComponent<RectTransform>().localPosition = new Vector2(this.posX, this.posY);
                    go.GetComponent<RectTransform>().sizeDelta = new Vector2(size,size);
                }
                if (mapArray[i, j] == 0)
                {
                    GameObject go = Instantiate(forest) as GameObject;
                    go.transform.SetParent(mapParent);
                    go.GetComponent<RectTransform>().localScale = Vector3.one;
                    go.GetComponent<RectTransform>().localPosition = new Vector2(this.posX, this.posY);
                    go.GetComponent<RectTransform>().sizeDelta = new Vector2(size,size);
                }
                if (mapArray[i, j] == 2)
                {
                    GameObject go = Instantiate(goal) as GameObject;
                    go.transform.SetParent(mapParent);
                    go.GetComponent<RectTransform>().localScale = Vector3.one;
                    go.GetComponent<RectTransform>().localPosition = new Vector2(this.posX, this.posY);
                    go.GetComponent<RectTransform>().sizeDelta = new Vector2(size,size);
                }
                this.posX = this.posX + size;
            }
            this.posX = 0;
            this.posY = this.posY + size;
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
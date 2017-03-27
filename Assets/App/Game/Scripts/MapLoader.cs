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
        float width = canvas.GetComponent<RectTransform>().rect.width;
        float height = canvas.GetComponent<RectTransform>().rect.height;

        for (i = 0; i >= devide; i++)
        {
            for (j = 0; j >= devide; j++)
            {
                mapArray[i, j] = 0;
            }
        }
        mapArray[devide - 1, devide - 1] = 1;
        mapArray[1, 1] = 2;

        /*road.GetComponent<RectTransform>().sizeDelta = new Vector2(height/devide,height/devide);
        forest.GetComponent<RectTransform>().sizeDelta = new Vector2(height / devide, height / devide);
        goal.GetComponent<RectTransform>().sizeDelta = new Vector2(height / devide, height / devide);
        */
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
                    go.transform.position = new Vector2(this.posX, this.posY);
                    go.GetComponent<RectTransform>().sizeDelta = new Vector2(0.85f,0.85f);
                }
                if (mapArray[i, j] == 0)
                {
                    GameObject go = Instantiate(forest) as GameObject;
                    go.transform.SetParent(mapParent);
                    go.transform.position = new Vector2(this.posX, this.posY);
                    go.GetComponent<RectTransform>().sizeDelta = new Vector2(0.85f,0.85f);
                }
                if (mapArray[i, j] == 2)
                {
                    GameObject go = Instantiate(goal) as GameObject;
                    go.transform.SetParent(mapParent);
                    go.transform.position = new Vector2(this.posX, this.posY);
                    go.GetComponent<RectTransform>().sizeDelta = new Vector2(0.87f,0.87f);
                }
                this.posX = this.posX + 0.85f;
            }
            this.posX = 0;
            this.posY = this.posY + 0.85f;
        }
        Debug.Log(canvas.GetComponent<RectTransform>().rect.width);
        Debug.Log(canvas.GetComponent<RectTransform>().rect.height);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
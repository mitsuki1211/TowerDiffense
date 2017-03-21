using UnityEngine;
using System.Collections;


public class MapLoader : MonoBehaviour
{
    int i;
    int j;
    float width = Screen.width;
    float height= Screen.height;
    public const int devide = 10;
    public GameObject road;
    public GameObject forest;
    public GameObject goal;
    private float posX = 0;
    private float posY = 0;
    public static int[,] mapArray = new int[devide, devide];

    
    


    // Use this for initialization
    void Start()
    {
        for (i = 0; i >= devide; i++)
        {
            for (j = 0; j >= devide; j++)
            {
                mapArray[i, j] = 0;
            }
        }

        mapArray[devide - 1, devide - 1] = 1;
        mapArray[1, 1] = 2; 

        /*road.GetComponent<Transform>().localScale = new Vector2(height/devide, height/devide);
        forest.GetComponent<Transform>().localScale = new Vector2(height/devide, height/devide);
        goal.GetComponent<Transform>().localScale = new Vector2(height/devide, height/devide);
        */


        i = 1;
        j = 1;
       


        while(i < (devide - 1) || j < (devide - 1)) {
            int z = UnityEngine.Random.Range(0,2);

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
        



        for (i = (devide - 1); i > -1; i--) {
            for (j = 0; j < devide; j++)
            {
                if(mapArray[i,j] == 1)
                {
                    GameObject go = Instantiate(road) as GameObject;
                    go.transform.position = new Vector2(this.posX, this.posY);
                }
                if(mapArray[i,j] == 0)
                {
                    GameObject go = Instantiate(forest) as GameObject;
                    go.transform.position = new Vector2(this.posX, this.posY);
                }
                if (mapArray[i, j] == 2)
                {
                    GameObject go = Instantiate(goal) as GameObject;
                    go.transform.position = new Vector2(this.posX, this.posY);
                }
                this.posX = this.posX + 0.16f;
            }
            this.posX = 0;
            this.posY = this.posY + 0.16f;
        }
        Debug.Log(width);
        Debug.Log(height);
      
    }

        // Update is called once per frame
        void Update()
    {

    }
}

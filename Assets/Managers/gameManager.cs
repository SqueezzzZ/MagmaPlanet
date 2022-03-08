using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [SerializeField] private mapData MapData; //потом убрать  Serialize
    [SerializeField] private bool createMapFromDB;
    [SerializeField] private GameObject Player;
    [SerializeField] private Transform lava1;
    [SerializeField] private Transform LeftWall;
    [SerializeField] private Transform RightWall;

    


    private int trAmount; //количество триггеров
    private int shAmount; //количество островов

    public int worldID = 1;
    public int mapID = 1;
    public int LastShoreCollidedID = 0;

    // Start is called before the first frame update
    void Start()
    {
        MapData = (mapData)Resources.Load("maps/map"+mapID+"World"+worldID, typeof(mapData));

        if (createMapFromDB)
        {
            for (int i = 0; i < MapData.MaxNextObj[0]; i++)
            {
                Instantiate(MapData.ShorePrefab[MapData.ShoreType[i]], MapData.ShoresPos[i], Quaternion.identity);
                shAmount++;
                Debug.Log("i: "+i+", MNO: "+MapData.MaxNextObj[i]);
            }
        }
    }

    void Update()
    {
        
    }

    void InstantiateGameBarrier(GameObject prefab, Vector3 pos, Quaternion rot)
    { 

    }

    public void OnMapGenerator()
    {
        trAmount++;
        if (trAmount < MapData.LenthByTriggers)
        {
            lava1.position = new Vector3(lava1.position.x, lava1.position.y, lava1.position.z + 20);
            LeftWall.position = new Vector3(LeftWall.position.x, LeftWall.position.y, LeftWall.position.z + 20);
            RightWall.position = new Vector3(RightWall.position.x, RightWall.position.y, RightWall.position.z + 20);
            /*for (int i = 0; i < MapData.MaxNextObj[shAmount]; i++)
            {
                Instantiate(MapData.ShorePrefab[MapData.ShoreType[shAmount]], MapData.ShoresPos[shAmount], Quaternion.identity);
                shAmount++;
            }*/
        }
        Debug.Log("Triggers amount: "+trAmount+" / "+MapData.LenthByTriggers + " | Shores: "+shAmount+" / ");
    }

}

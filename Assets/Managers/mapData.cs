using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New MapData",menuName = "MapData", order = 51)]
public class mapData : ScriptableObject
{

    [SerializeField] private int lenthByTriggers; //длина карты в триггерах
    [SerializeField] private GameObject[] shorePrefab; //префабы островов
    [SerializeField] private Vector3[] shoresPos; //база данных позиций островов
    [SerializeField] private int[] shoreType; //типы островов (ID префаба)
    [SerializeField] private int[] maxNextObj;  //сколько объектов отрисуется в тумане после касания триггера
    //[SerializeField] private int[,] bober = new int[2,2];
//private List<Vector3> sPos = new List<Vector3>();

public int LenthByTriggers
    {
        get
        {
            return lenthByTriggers;
        }
    }

    public int[] MaxNextObj
    {
        get
        {
            return maxNextObj;
        }
    }
    public Vector3[] ShoresPos
    {
        get
        {
            return shoresPos;
        }
    }

    public GameObject[] ShorePrefab
    {
        get
        {
            return shorePrefab;
        }
    }

    public int[] ShoreType
    {
        get
        {
            return shoreType;
        }
    }
}

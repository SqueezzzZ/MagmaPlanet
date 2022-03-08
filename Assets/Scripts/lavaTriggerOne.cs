using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaTriggerOne : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    private GameObject GameManager;
    private gameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            gm.OnMapGenerator();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    [SerializeField]
    public Transform Player;
    private float offsetZ;

    void Start()
    {
        //offset = transform.position - Player.transform.position;
        offsetZ = transform.position.z - Player.position.z;
    }

    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(Player.position.x/1.38f, transform.position.y, Player.position.z + offsetZ); //Player.transform.position + offset;
        //transform.rotation = new Quaternion(transform.rotation.x,-Player.position.x*3.3f,transform.rotation.z,transform.rotation.w);
        //transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, 0f);

    }
}

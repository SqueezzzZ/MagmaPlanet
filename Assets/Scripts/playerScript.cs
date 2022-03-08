using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    [SerializeField] private DynamicJoystick joystick;
    [SerializeField] private TrajectoryScript Trajectory;
    [SerializeField] private Transform FogPos;
    [SerializeField] private GameObject lava;
    [SerializeField] private GameObject joystickObj;
    public float startVelocityXZ = 10;
    public float startVelocityY = 20;
    [SerializeField] public Vector3 axisSpeed;

    [SerializeField] private Animator GameOverAnim;
    private bool canJump = false;
    private Rigidbody rb;
    private float fogOffset;
    private GameObject LastCollidedGO;
    //private Animator GameOverAnim;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fogOffset = FogPos.position.z - transform.position.z;
    }
    private void FixedUpdate()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float len = joystick.Direction.magnitude;
        float jx = joystick.Direction.x, jy = joystick.Direction.y;

        if (jy < 0)
        {
            axisSpeed = new Vector3(-jx * startVelocityXZ, len * startVelocityY, -jy * startVelocityXZ);
            Trajectory.ShowTrajectory(transform.position, axisSpeed);
            canJump = true;

        }
        //перемещаем стену с туманом, чтоб не видеть горизонт
        FogPos.position = new Vector3(FogPos.position.x,FogPos.position.y,transform.position.z+fogOffset);

    }

    private void LateUpdate()
    {
        if (canJump == true && joystick.Direction.magnitude == 0f)
        {
            this.transform.SetParent(null);
            rb.AddForce(axisSpeed, ForceMode.Impulse);
            canJump = false;
            Trajectory.DestroyTrajectory();
        }
    }
    /*private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject == lava)
        {
            joystickObj.SetActive(false);
            Debug.Log("Lava collided");
        }
    }*/
    private void OnCollisionEnter(Collision c)
    {
        /*if(LastCollidedGO != c.gameObject)
        {

        }*/
        LastCollidedGO = c.gameObject;
        Debug.Log("Collision: "+ c.gameObject);
        if (c.gameObject == lava)
        {

            joystickObj.SetActive(false);
            Debug.Log("Lava collided");
        }
        else if (c.gameObject.tag.Equals("shore"))
        {
            this.transform.SetParent(c.gameObject.transform);
            Debug.Log("Shore collided and attached");
        }
    }

}


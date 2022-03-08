using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ostrov1Script : MonoBehaviour
{
    [SerializeField] private int movingType; //0 - стоит, 1 - по горизонтали (Х), 2 - по вертикали (Z)
    [SerializeField] private float movingSpeed; //скорость движения
    [SerializeField] private float maxDistance; //максимальное удаление от точки создания
    [SerializeField] private int additions; // 0- ничего, 1 - моентка, 2... - бустеры

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       /* if(movingType > 0)
        {
            if(movingType  == 1)
            {
                if (this.transform.position.x - startPos.x > maxDistance)
                {
                    this.transform.Translate(movingSpeed * Time.deltaTime, 0, 0);
                }
                else this.transform.Translate(-movingSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                this.transform.Translate(0, 0, movingSpeed * Time.deltaTime);
            }
        }*/
    }
}

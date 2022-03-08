using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryScript : MonoBehaviour
{
    private LineRenderer lineRendererComp;
    // Start is called before the first frame update
    void Start()
    {
        lineRendererComp = GetComponent<LineRenderer>();
    }

    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[100];
        
        for(int i=0; i< points.Length;i++)
        {
            float time = i * 0.1f;
            points[i] = origin + speed * time + Physics.gravity * time * time/2f;
            lineRendererComp.positionCount = i;
            if (points[i].y < 0f)
            {
                break;
            }
        }
        lineRendererComp.SetPositions(points);
    }

    public void DestroyTrajectory()
    {
        lineRendererComp.positionCount = 0;
    }
}

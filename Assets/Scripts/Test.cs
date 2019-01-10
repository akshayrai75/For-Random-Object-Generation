using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{


//initializing game object to show in display

    public GameObject objectToInstantiate;

    public float radius = 1;
    public Vector2 regionSize = Vector2.one;
    public int rejectionSamples = 30;
    public float displayRadius = 1;

    List<Vector2> points;

    void OnValidate()
    {
        points = PoissonDiscSampling.GeneratePoints(radius, regionSize, rejectionSamples);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(regionSize / 2, regionSize);
    }

    void Start()
    {
        
        if (points != null)
        {
            foreach (Vector2 point in points)
            {
                //Gizmos.DrawSphere(point, displayRadius);
                //Intatiate trees here
                Instantiate(objectToInstantiate, point, Quaternion.identity);		//showing the points on screen 

            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicMaterials : MonoBehaviour
{
    public PhysicsMaterial2D physMat;

    // Update is called once per frame
    public float min;
    public float max;
    public float friction;
    void Update()
    {
        //physMat.bounciness = Random.Range(0.1f, 0.2f);
        physMat.friction = Random.Range(min, max);
        friction = physMat.friction;
    }
}

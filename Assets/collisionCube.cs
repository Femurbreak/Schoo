using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Ouch I hit the "+collision.gameObject.name);
    }
}

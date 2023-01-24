using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MonoBehaviour
{
    
    Rigidbody roadRb;   
    public float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        roadRb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        roadRb.velocity = new Vector3(0,0,1) * -speed;
    }
}

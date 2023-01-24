using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatBackground : MonoBehaviour
{
    // sýkýntýlar var!
    private Vector3 startPos;

    private float repeatRate;
    // Start is called before the first frame update
    void Start()
    {
        startPos= transform.position;
        repeatRate = GetComponent<BoxCollider>().size.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -2)
        {
            transform.position = startPos;
        }
    }
}

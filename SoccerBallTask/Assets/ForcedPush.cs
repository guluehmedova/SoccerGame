using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcedPush : MonoBehaviour
{
    Rigidbody r;
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if (Input.GetKeyDown("space"))
        //{
        //    r.AddForce(new Vector3(100, 0, 0));
        //}

        transform.position += new Vector3(5f * Time.deltaTime, 0, 0);
    }
}

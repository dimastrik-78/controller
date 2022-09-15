using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteRotater
{
    public void Rotate(Rigidbody rb, float rotateSpeed)
    {
        rb.AddTorque(Input.GetAxis("Horizontal") * rb.transform.forward * rotateSpeed);
    }
}

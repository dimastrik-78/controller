using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement
{
    public void Move(Rigidbody rb, float speed)
    {
        rb.velocity = Input.GetAxis("Vertical") * rb.transform.forward * speed;
    }
}

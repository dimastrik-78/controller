using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump
{
    public void Jump(Rigidbody rb, float jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}

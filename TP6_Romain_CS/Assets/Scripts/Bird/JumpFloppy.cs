using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFloppy : MonoBehaviour
{
    public Rigidbody2D rb2D;
    private int jumpheight = 1;

    void FixedUpdate()
    {
        bool jump = Input.GetKey(KeyCode.Space);
        if (jump == true)
        {
            rb2D.AddForce(Vector2.up * jumpheight, ForceMode2D.Impulse);
        }
    }
}

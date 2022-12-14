using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    public float speed = 10;

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;

        GetComponent<Animator>().SetBool("IsFlyingUp", (v > 0));
        GetComponent<Animator>().SetBool("IsFlyingLeft", (h < 0));
        GetComponent<Animator>().SetBool("IsFlyingRight", (h > 0));

    }


}

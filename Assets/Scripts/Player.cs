using UnityEngine;
using System.Collections.Generic;
using System;

public class Player : Human
{
    new void Start()
    {
        base.Start();
        AddAmmo("500mm", 128);
    }

    new void Update()
    {
        base.Update();

        if (Input.GetButtonDown("Jump"))
            Jump();
    }

    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal") * moveSpeed;
        movement *= Time.deltaTime;
        transform.Translate(movement, 0.0f, 0.0f);

        ///rigidbody.AddForce(new Vector3(movement*2, 0, 0), ForceMode.Impulse);
    }
}
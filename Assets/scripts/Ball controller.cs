using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcontroller : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private bool zCheck;
    private bool grounded;
    private Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        player = transform.GetComponent<Rigidbody>();
        zCheck = false;
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            zCheck = !zCheck;
        }
        if (!zCheck && grounded)
        {
            player.MovePosition(player.position+new Vector3(speed,0,0));
        }

        if (zCheck && grounded)
        {
            player.MovePosition(player.position+new Vector3(0,0,speed));
        }

        
    }

    private void OnCollisionExit(Collision other)
    {
        
        grounded = false;
        player.useGravity = true;

    }
}

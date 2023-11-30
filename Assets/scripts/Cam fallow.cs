using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camfallow : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Rigidbody plyerBody;

    private Vector3 lastpos;
    // Start is called before the first frame update
    void Start()
    {
        plyerBody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (plyerBody.useGravity==false)
        {
            transform.position +=  player.transform.position- lastpos ;
        }

        lastpos = player.transform.position;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingplatfrom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.transform.tag=="Player")
        {
            print("player");
            StartCoroutine(fallTime());
        }
    }

    IEnumerator fallTime()
    {
        yield return new WaitForSeconds(0.5f);
        Fall();
    }

    IEnumerator destroyit()
    {
        yield return new WaitForSeconds(2);
        destroyMan();
        
    }

    void Fall()
    {
        transform.GetComponent<Rigidbody>().useGravity = true;
        transform.GetComponent<Rigidbody>().isKinematic = false;
        transform.GetComponent<Rigidbody>().
        transform.GetComponent<Rigidbody>().AddForce(new Vector3(0,-5,0));
        StartCoroutine(destroyit());
    }

    void destroyMan()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject gem;
    private float oldtime;

    private float time;

    private Vector3 oldpos;
    // Start is called before the first frame update
    void Start()
    {
        oldpos = new Vector3(7.14f, -0.5f, 3.42f);

        for (int i = 0; i < 20; i++)
        {
            Vector3 newpos = new Vector3(Random.Range(0, 3), 0, Random.Range(0, 3));
            Instantiate(platform, oldpos + newpos,
                new Quaternion(0, 0, 0, 0));
            oldpos += newpos;
            int chance = Random.Range(0, 5);
            if (chance == 4)
            {
                Instantiate(gem, oldpos + Vector3.up, new Quaternion(0, 0, 0, 0));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time>=0.2f&& transform.GetComponent<Rigidbody>().useGravity==false)
        {
            Vector3 newpos = new Vector3(Random.Range(0, 3), 0, Random.Range(0, 3));
            Instantiate(platform, oldpos + newpos,
                new Quaternion(0, 0, 0, 0));
           

            oldpos += newpos;
            int chance = Random.Range(0, 5);
            if (chance == 4)
            {
                Instantiate(gem, oldpos + Vector3.up, new Quaternion(0, 0, 0, 0));
            }
            time = 0;
        }
    }
}

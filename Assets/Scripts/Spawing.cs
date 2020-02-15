using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawing : MonoBehaviour
{
    public GameObject[] DragablePrefabs;

    GameObject SpawnedObject;

    bool bIsDone = false;

    float waitTime = 3.0f;
    bool wait = true;

    int count = 0;

    void Start()
    {
        //SpawnItem();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime > 0 && wait == true)
        {
            waitTime -= Time.deltaTime;
        }
        if (waitTime < 0)
        {
            wait = false;

            waitTime = 1f;
        }

        if (wait == false)
        {
            if (bIsDone == false)
            {
                SpawnItem();
                count++;

                if (count < 5)
                {
                    waitTime = 3.0f;
                }
                if (count > 5)
                {
                    waitTime = 2.0f;
                }
                if (count > 10)
                {
                    waitTime = 1.5f;
                }


                wait = true;
            }
        }
    }

    void SpawnItem()
    {
        Vector3 Offset = new Vector3(Random.Range(-1.7f, 2.3f), 0.0f, 0.0f);

        if (DragablePrefabs.Length > 0)
        {
            var randomNum = Random.Range(0, DragablePrefabs.Length);
            Instantiate(DragablePrefabs[randomNum], transform.position + Offset, transform.rotation);
        }
    }
}

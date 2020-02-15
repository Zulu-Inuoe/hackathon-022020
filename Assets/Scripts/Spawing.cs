using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawing : MonoBehaviour
{
    public GameObject DragablePrefab;

    GameObject SpawnedObject;

    bool bIsDone = false;

    float waitTime = 3.0f;
    bool wait = true;

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
                waitTime = 3.0f;
                wait = true;
            }
        }
    }

    void SpawnItem()
    {
        Vector3 Offset = new Vector3(Random.Range(-1.7f, 2.3f), 0.0f, 0.0f);
        SpawnedObject = Instantiate(DragablePrefab, transform.position + Offset, transform.rotation);
    }
}

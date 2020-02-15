using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawing : MonoBehaviour
{
    public GameObject DragablePrefab;

    GameObject SpawnedObject;
    
    void Start()
    {
        SpawnItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnItem()
    {
        SpawnedObject = Instantiate(DragablePrefab, transform.position, transform.rotation);
    }
}

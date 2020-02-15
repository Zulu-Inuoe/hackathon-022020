using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecyclingBin : MonoBehaviour
{    
    public int BinType;
    public GameObject Life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name);
        
        Debug.Log(col.gameObject.GetComponent<RecyclingItem>().ItemType);

        if (BinType == col.gameObject.GetComponent<RecyclingItem>().ItemType)
        {
            Debug.Log("SCORE!");
        }
        else
            Life.GetComponent<LifeManager>().LoseHealth();
            


        Destroy(col.gameObject);
    }
    
}

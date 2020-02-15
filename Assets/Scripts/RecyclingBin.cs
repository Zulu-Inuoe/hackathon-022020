using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecyclingBin : MonoBehaviour
{    
    public int BinType;
    private GameObject Life;

    public BinManager binManager;
    // Start is called before the first frame update
    void Start()
    {
        Life = GameObject.Find("Lives Manager");
        binManager = GameObject.Find("Recycling Bin Manager").GetComponent<BinManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name);

        //Debug.Log(col.gameObject.GetComponent<RecyclingItem>().ItemType);

        if (col && col.gameObject && col.gameObject.GetComponent<RecyclingItem>())
        {
            if (BinType == col.gameObject.GetComponent<RecyclingItem>().ItemType)
            {
                Debug.Log("SCORE!");
                binManager.Collected(col.gameObject.GetComponent<DragAndDrop>().Timer);
                this.GetComponent<AudioSource>().Play();
            }
            else
            {
                Life.GetComponent<LifeManager>().LoseHealth();
                binManager.Trashed();
            }


            Destroy(col.gameObject);
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinManager : MonoBehaviour
{
    public GameObject paperBin;
    public GameObject plasticBin;
    public GameObject electronicBin;
    public GameObject nonrecyclableBin;

    private List<GameObject> bins = new List<GameObject>();
    private GameObject tmpObj;

    private int i = 0;
    private int randIndex;
    private int maxIndex = 4;

    
    

    // Start is called before the first frame update
    void Start()
    {
        bins.Add(paperBin);
        bins.Add(plasticBin);
        bins.Add(electronicBin);
        bins.Add(nonrecyclableBin);
        
        /*
        for (int i=0; i<4; i++)
        {            
            tmpObj = Instantiate(bins[i], this.GetComponent<Transform>());
            tmpObj.GetComponent<Transform>().position = new Vector3(((i * 1.5f) - 2.25f), -4.5f, 0);
        }     
       */

       while(bins.Count > 0)
        {
            randIndex = Random.Range(0, maxIndex);

            tmpObj = Instantiate(bins[randIndex], this.GetComponent<Transform>());
            tmpObj.GetComponent<Transform>().position = new Vector3(((i * 1.5f) - 2.25f), -4.5f, 0);

            bins.RemoveAt(randIndex);
            maxIndex -= 1;
            i++;
        }
    }


        
        


    // Update is called once per frame
    void Update()
    {
        
    }
}

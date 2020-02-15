using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinManager : MonoBehaviour
{
    public GameObject paperBin;
    public GameObject plasticBin;
    public GameObject electronicBin;
    public GameObject nonrecyclableBin;
    
    private int index;

    private ArrayList bins = new ArrayList();

    

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(paperBin.transform());
        //bins.Add(paperBin, plasticBin, electronicBin, nonrecyclableBin);

        //index = (int)Random.range(0, 4);
       
    }


        
        


    // Update is called once per frame
    void Update()
    {
        
    }
}

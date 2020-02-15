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

    public int Score;


    // Start is called before the first frame update
    void Start()
    {
        bins.Add(paperBin);
        bins.Add(plasticBin);
        bins.Add(electronicBin);
        bins.Add(nonrecyclableBin);        

       while(bins.Count > 0)
        {
            randIndex = Random.Range(0, maxIndex);

            tmpObj = Instantiate(bins[randIndex], this.GetComponent<Transform>());
            tmpObj.GetComponent<Transform>().position = new Vector3(((i * 1.42f) - 2.13f), -4f, 0);

            bins.RemoveAt(randIndex);
            maxIndex -= 1;
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Collected(float time)
    {
        if (time < 1.0f)
        {
            Score += 300;
        }
        else if (time < 2.0f)
        {
            Score += 200;
        }
        else if (time < 3.0f)
        {
            Score += 100;
        }

        Debug.Log(Score);
    }

    void Trashed()
    {

    }



}

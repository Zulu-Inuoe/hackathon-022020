using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BinManager : MonoBehaviour
{

    public int Score;

    public Text txt;
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
        txt.text = "Score : " + Score;
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

    public void Collected(float time)
    {
        if (time < 1.0f)
        {
            Score += 300;
            Debug.Log(300);
        }
        else if (time < 2.5f)
        {
            Score += 200;
            Debug.Log(200);
        }
        else if (time < 4.0f || time > 4.0f)
        {
            Score += 100;
            Debug.Log(100);
        }
        txt.text = "Score : " + Score;
        Debug.Log(time);
        
    }

    public void Trashed()
    {

    }



}

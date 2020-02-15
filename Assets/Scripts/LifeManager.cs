using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public GameObject Lives;
    private GameObject L1;
    private GameObject L2;
    private GameObject L3;
    private int health = 3;
    private AudioSource[] audioSources;

    // Start is called before the first frame update
    void Start()
    {
        L1 = Instantiate(Lives, this.GetComponent<Transform>());
        L1.GetComponent<Transform>().position = new Vector3(-0.8f + 1.5f, 4.5f, 0);

        L2 = Instantiate(Lives, this.GetComponent<Transform>());
        L2.GetComponent<Transform>().position = new Vector3(1.5f, 4.5f, 0);

        L3 = Instantiate(Lives, this.GetComponent<Transform>());
        L3.GetComponent<Transform>().position = new Vector3(0.8f + 1.5f, 4.5f, 0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseHealth()
    {
        if (health == 1)
        {
            SceneManager.LoadScene("MainMenu");

            audioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach (AudioSource audioS in audioSources)
            {
                audioS.Stop();
            }
        }

        else if (health == 2)
        {
            health -= 1;
            L2.GetComponent<SpriteRenderer>().color = Color.black;
        }
        else
        {
            health -= 1;
            L3.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

//Simple component to load scenes
public class SceneLoader : MonoBehaviour
{
    private AudioSource[] audioSources;
    public void LoadSceneByName(string name)
    {
        
        SceneManager.LoadScene(name);
    }

    public void LoadSceneByIndex(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}

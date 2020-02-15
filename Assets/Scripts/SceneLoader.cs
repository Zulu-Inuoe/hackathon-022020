using UnityEngine;
using UnityEngine.SceneManagement;

//Simple component to load scenes
public class SceneLoader : MonoBehaviour
{
    private AudioSource[] audioSources;
    public void LoadSceneByName(string name)
    {
        audioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in audioSources)
        {
            audioS.Stop();
        }
        SceneManager.LoadScene(name);
    }

    public void LoadSceneByIndex(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}

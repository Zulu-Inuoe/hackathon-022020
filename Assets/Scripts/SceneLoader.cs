using UnityEngine;
using UnityEngine.SceneManagement;

//Simple component to load scenes
public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadSceneByIndex(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}

using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public Spinner Spinner;
    public GameObject StartButton;
    public string NextScene;

    private AsyncOperation m_LoadSceneOp;
    private void Start()
    {
        StartButton.SetActive(false);
        Spinner.enabled = true;
        StartCoroutine(LoadSceneCoroutine());
    }

    private IEnumerator LoadSceneCoroutine()
    {
        m_LoadSceneOp = SceneManager.LoadSceneAsync(NextScene);
        m_LoadSceneOp.allowSceneActivation = false;
        while (m_LoadSceneOp.progress < 0.9f)
        {
            yield return null;
        }

        Spinner.enabled = false;
        Spinner.transform.rotation = Quaternion.identity;
        StartButton.SetActive(true);
    }

    public void ActivateLoadedScene()
    {
        m_LoadSceneOp.allowSceneActivation = true;
    }
}

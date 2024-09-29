using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLine : MonoBehaviour
{
    [SerializeField] private string _nameScene;

    public void loadScene()
    {
        StartCoroutine(Loader());

        IEnumerator Loader()
        {
            SceneManager.LoadSceneAsync(_nameScene);
            yield return null;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

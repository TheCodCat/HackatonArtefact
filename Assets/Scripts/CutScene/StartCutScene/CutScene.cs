using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    [SerializeField] private string _nameScene;
    [SerializeField] private PlayableDirector _director;
    [SerializeField] private GameObject[] _gameObjects;

    public void StartButton()
    {
        _director.Play();
        foreach (var item in _gameObjects)
        {
            item.SetActive(false);
        }
    }

    public void LoadScene()
    {
        StartCoroutine(Loader());
    }
    IEnumerator Loader()
    {
        SceneManager.LoadSceneAsync(_nameScene);
        yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    [SerializeField] private string _nameScene;
    [SerializeField] private Playable[] _directors;
    [SerializeField] private PlayableDirector _currentDirector;
    [SerializeField] private GameObject[] _gameObjects;
    private int _indexCutscene = 0;

    private void Start()
    {
        StartCoroutine(CutScensManager());
    }
    IEnumerator CutScensManager()
    {
        while(_indexCutscene < _directors.Length - 1)
        {
            Debug.Log(_currentDirector.duration);
            yield return new WaitForSeconds((float)_currentDirector.duration);
            Skip();
        }

    }
    public void Skip()
    {
        if (_indexCutscene < _directors.Length - 1)
        {
            for (int i = 0; i < _directors.Length - 1; i++)
            {
                _directors[_indexCutscene].Objects[i].gameObject.SetActive(false);
            }
            _currentDirector.Stop();
            _indexCutscene++;
            _currentDirector = _directors[_indexCutscene].PlayableDirector;
            _currentDirector.Play();
        }
    }
    public void Skip(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (_indexCutscene < _directors.Length - 1)
            {
                for (int i = 0; i < _directors.Length - 1; i++)
                {
                    _directors[_indexCutscene].Objects[i].gameObject.SetActive(false);
                }
                _currentDirector.Stop();
                _indexCutscene++;
                _currentDirector = _directors[_indexCutscene].PlayableDirector;
                _currentDirector.Play();
            }
            else
            {
                if(_currentDirector != null) _currentDirector.Stop();
                LoadScene();
            }
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
[System.Serializable]
public class Playable
{
    public PlayableDirector PlayableDirector;
    public List<GameObject> Objects;
}

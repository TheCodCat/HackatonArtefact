using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    [SerializeField] private GameObject _exitPanel;
    [SerializeField] private GameObject _button;
    public GameObject ExitButton => _button;
    public GameObject ExitPanel => _exitPanel;
    public void EnableExitPanel()
    {
        ExitPanel.SetActive(true);
    }

    public void Exit(string name)
    {
        StartCoroutine(Loader());

        IEnumerator Loader()
        {
            SceneManager.LoadSceneAsync(name);
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    [SerializeField] private GameObject _exitPanel;
    [SerializeField] private GameObject _button;
    [SerializeField] private Altar _altar;
    public GameObject ExitButton => _button;
    public GameObject ExitPanel => _exitPanel;
    public void EnableExitPanel()
    {
        ExitPanel.SetActive(true);
    }

    public void Exit()
    {
        string nameScene = _altar.GetVariableEnd();
        StartCoroutine(Loader());

        IEnumerator Loader()
        {
            SceneManager.LoadSceneAsync(nameScene);
            yield return null;
        }
    }
}

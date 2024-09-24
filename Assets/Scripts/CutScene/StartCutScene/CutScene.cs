using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    [SerializeField] private string _nameScene;


    public void LoadScene()
    {
        StartCoroutine(Loader());

        IEnumerator Loader() 
        {
            SceneManager.LoadSceneAsync(_nameScene);
            yield return null;
        }
    }
}

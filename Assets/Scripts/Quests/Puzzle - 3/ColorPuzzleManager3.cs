using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPuzzleManager3 : MonoBehaviour
{
    public ColorColumn[] columns; 
    public GameObject door; 

    private void Update()
    {
        CheckColumns();
    }

    private void CheckColumns()
    {
        foreach (ColorColumn column in columns)
        {
            if (!column.IsCorrectColor())
            {
                return; // Если хотя бы один столбик неправильно покрашен, выходим
            }
        }
        door.SetActive(false);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLever : MonoBehaviour
{
    void OnMouseDown()
    {
        Lever.leverCount = 0; // Сбросить количество активированных рычагов
        Lever[] levers = FindObjectsOfType<Lever>();

        foreach (Lever lever in levers)
        {
            lever.isActive = false; // Сбросить состояние каждого рычага
            lever.UpdateColor(); // Обновить цвет
            Debug.Log("Lever " + lever.leverID + " reset");
        }
    }
}




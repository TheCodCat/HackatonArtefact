using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public int[] correctOrder; // Правильный порядок рычагов
    private int currentStep = 0; // Текущий шаг
    public GameObject door; // Ссылка на объект двери

    public void CheckLever(int leverID)
    {
        if (leverID == correctOrder[currentStep])
        {
            currentStep++;
            Debug.Log("Correct lever! Step: " + currentStep);
            if (currentStep >= correctOrder.Length)
            {
                SolvePuzzle();
            }
        }
        else
        {
            Debug.Log("Wrong lever! Resetting.");
            currentStep = 0; // Сбросить шаги при ошибке
        }
    }

    void SolvePuzzle()
    {
        Debug.Log("Puzzle solved! The door disappears.");
        if (door != null)
        {
            door.GetComponent<Renderer>().enabled = false; // Скрыть дверь
        }
    }
}



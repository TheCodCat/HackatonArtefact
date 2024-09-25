using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public static int leverCount = 0; // Количество активированных рычагов
    public int leverID; // Уникальный ID рычага
    public bool isActive = false; // Состояние рычага
    private Renderer leverRenderer; // Компонент Renderer

    public Color activeColor = Color.green; // Цвет активированного рычага
    public Color inactiveColor = Color.red; // Цвет неактивированного рычага

    void Start()
    {
        leverRenderer = GetComponent<Renderer>();
        UpdateColor(); // Установить начальный цвет
    }

    void OnMouseDown()
    {
        ToggleLever();
    }

    void ToggleLever()
    {
        isActive = !isActive;
        leverCount += isActive ? 1 : -1;
        UpdateColor(); // Обновить цвет при переключении
        Debug.Log("Lever " + leverID + " is " + (isActive ? "activated" : "deactivated"));
        FindObjectOfType<PuzzleManager>().CheckLever(leverID); // Проверить рычаг в PuzzleManager
    }

   public void UpdateColor()
    {
        leverRenderer.material.color = isActive ? activeColor : inactiveColor;
    }
}




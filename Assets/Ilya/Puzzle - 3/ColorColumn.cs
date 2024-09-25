using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorColumn : MonoBehaviour
{
    public Color correctColor; 
    private Color currentColor; 
    private Renderer columnRenderer;

    private void Start()
    {
        columnRenderer = GetComponent<Renderer>();
        currentColor = columnRenderer.material.color; // Получаем начальный цвет
    }

    public void Paint(Color color)
    {
        currentColor = color;
        columnRenderer.material.color = currentColor; // Меняем цвет столбика
    }

    public bool IsCorrectColor()
    {
        return currentColor == correctColor; // Проверяем правильность цвета
    }
}


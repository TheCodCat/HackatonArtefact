using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    private Color selectedColor;
    private Renderer brushRenderer;

    private void Start()
    {
        brushRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FireR"))
        {
            selectedColor = other.GetComponent<FireR>().GetColor();
            PaintBrushColor(selectedColor); // Окрашиваем в выбранный цвет
        }
        else if (other.CompareTag("Column"))
        {
            other.GetComponent<ColorColumn>().Paint(selectedColor);
        }
    }

    private void PaintBrushColor(Color color)
    {
        brushRenderer.material.color = color; // Меняем цвет
    }
}



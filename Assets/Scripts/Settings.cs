using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private bool _isOpen;
    [SerializeField] private StateMachin _stateMachin;
    [SerializeField] private GameObject _settingsPanel;
    [Header("Общая громкость")]
    [SerializeField] private AudioMixer _audioMixer;
    public void PanelHandler(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _isOpen = !_isOpen;
            if (_isOpen)
            {
                _stateMachin.ChangeState(StatePlayer.UI);
                _settingsPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                _stateMachin.ChangeState(StatePlayer.Game);
                _settingsPanel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
    public void Slide(float value)
    {
        _audioMixer.SetFloat("_mainVolume",value);
    }
}

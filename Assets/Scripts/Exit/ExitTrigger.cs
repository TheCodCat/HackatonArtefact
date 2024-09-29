using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitTrigger : MonoBehaviour
{
    [SerializeField] private StateMachin _stateMachin;
    [SerializeField] private ExitController _exitController;
    [SerializeField] private EventSystem _eventSystem;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out StateMachin component))
        {
            _stateMachin = component;
            _stateMachin.ChangeState(StatePlayer.UI);
            Cursor.lockState = CursorLockMode.None;
            _eventSystem.SetSelectedGameObject(_exitController.ExitButton);
            _exitController.EnableExitPanel();
        }
    }
    public void ToStay()
    {
        _exitController.DisableExitPanel();
        _stateMachin.ChangeState(StatePlayer.Game);
        Cursor.lockState = CursorLockMode.Locked;
    }
}

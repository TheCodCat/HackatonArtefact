using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения игрока
    public float mouseSensitivity = 2f; // Чувствительность мыши

    private float rotationX = 0f; // Угол поворота по оси X (вверх/вниз)
    private Camera playerCamera; // Ссылка на камеру игрока
    [SerializeField] private float _rayDistance;

    [SerializeField] private Stack<Artefact> artefacts = new Stack<Artefact>();

    private void Start()
    {
        // Скрываем курсор и фиксируем его в центре экрана
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        playerCamera = Camera.main; // Получаем основную камеру
    }

    private void Update()
    {
        MovePlayer();
        RotatePlayer();
        PickupHandler();
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D или стрелки влево/вправо
        float moveVertical = Input.GetAxis("Vertical"); // W/S или стрелки вверх/вниз

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement = transform.TransformDirection(movement); // Преобразуем в мировые координаты
        transform.position += movement * moveSpeed * Time.deltaTime; // Двигаем игрока
    }

    private void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity; // Поворот по оси X (влево/вправо)
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity; // Поворот по оси Y (вверх/вниз)

        rotationX -= mouseY; // Обновляем угол поворота по оси X
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Ограничиваем угол поворота по оси X

        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f); // Поворачиваем камеру
        transform.Rotate(Vector3.up * mouseX); // Поворачиваем игрока по оси Y
    }

    private void PickupHandler()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(playerCamera.transform.position,playerCamera.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, _rayDistance))
            {
                Debug.Log(hit.collider);
                if (hit.collider.TryGetComponent(out Artefact pickUp))
                {
                    artefacts.Push(pickUp);
                    pickUp.Up();
                }

                if (hit.collider.TryGetComponent(out AltarPoint altar))
                {
                    altar.Interaction(artefacts.Pop());
                }
            }
        }
    }
}
// Queu => 123456 => 123456
// Stack => 123456 => 654321





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _player;
    [SerializeField] private float _moveSpeed, _gravity, _fallVelocity, _jumpForce;
    [SerializeField] private float _mouseSensitivity = 1.0f; // Ajusta la sensibilidad del ratón
    private Vector3 _axis, _movePlayer;

    private void Start()
    {
        _player = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar si el componente CharacterController está presente
    if (_player == null)
    {
        Debug.LogError("El componente CharacterController no está adjunto al objeto.");
        return;
    }
        // Verificar si el componente CharacterController está presente
    if (_player == null)
    {
        Debug.LogError("El componente CharacterController no está adjunto al objeto.");
        return;
    }
        // Movimiento del jugador
        transform.Rotate(0, Input.GetAxis("Mouse X") * _mouseSensitivity, 0); // Multiplica por la sensibilidad del ratón
        _axis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(_axis.magnitude > 1) _axis = transform.TransformDirection(_axis).normalized;
        else _axis = transform.TransformDirection(_axis);

        _movePlayer.x = _axis.x;
        _movePlayer.z = _axis.z;

        _player.Move(_movePlayer * _moveSpeed * Time.deltaTime);

        // Rotación vertical de la cámara
        float mouseY = -Input.GetAxis("Mouse Y") * _mouseSensitivity; // Multiplica por la sensibilidad del ratón
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _moveSpeed;
        float rotationY = transform.localEulerAngles.x + mouseY * _moveSpeed;
        transform.localEulerAngles = new Vector3(rotationY, rotationX, 0);
    }

}




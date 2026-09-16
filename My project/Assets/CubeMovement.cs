using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMovement : MonoBehaviour
{
    private InputAction _moveAction;
    
    private Vector2 _playerInputDirection;
    private Vector3 _movementVelocity;
    public float movementSpeed = 5;
    
    private void Start()
    {
         _moveAction = InputSystem.actions.FindAction("Move");
    }
    
    private void Update()
    {
        _playerInputDirection = _moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        _movementVelocity = new Vector3(_playerInputDirection.x, 0, _playerInputDirection.y) * movementSpeed;
        transform.position += _movementVelocity * Time.deltaTime;
    }
}

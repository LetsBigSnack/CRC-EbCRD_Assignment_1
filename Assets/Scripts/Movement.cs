using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

internal enum MovementType{
    
    TransformBased,
    PhysicsBased
}




public class Movement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField]
    private float _velocity = 1;
    [SerializeField] private MovementType _movementType;

    [SerializeField] private ForceMode _forceMode;
    
    private Vector3 _movementDirection3D;

    private Rigidbody _rb;
    
    
    
    // Start is called before the first frame update

    private void Awake()
    {
        _movementDirection3D = Vector3.zero;
        _rb = gameObject.GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
       PerformMovement();
    }

    void PerformMovement()
    {
        switch (_movementType)
        {
            case MovementType.TransformBased:
                gameObject.transform.position += _movementDirection3D * _velocity;
                break;
            case MovementType.PhysicsBased:
                _rb.AddForce(_movementDirection3D, _forceMode);
                break;
        }
    }
    
    void OnMovement(InputValue inputValue)
    {
        Vector2 movementDirection = inputValue.Get<Vector2>();
        _movementDirection3D = new Vector3(movementDirection.x, 0, movementDirection.y);
        Debug.Log(_movementDirection3D);
    }

    void OnJump(InputValue inputValue)
    {
        
    }

}

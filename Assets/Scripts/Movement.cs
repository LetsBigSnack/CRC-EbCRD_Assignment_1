using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _velocity = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += new Vector3(0, 0, -1f) * _velocity;*/
    }

    void OnMovement(InputValue inputValue)
    {
        Vector2 movementDirection = inputValue.Get<Vector2>();
        Debug.Log(movementDirection);
        Vector3 movementDirection3d = new Vector3(movementDirection.x, 0, movementDirection.y);
        gameObject.transform.position += movementDirection3d * _velocity;
    }

}

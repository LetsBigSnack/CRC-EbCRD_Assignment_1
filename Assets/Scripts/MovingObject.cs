using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    [SerializeField] private Vector3 distance;

    private Vector3 _startingPoint;
    private Vector3 _destinationPoint;

    [SerializeField] private float movingSpeed = 1.0f;
    
    private float _passedTime = 0f;
    private bool _isGoingUp = true;
    
    // Start is called before the first frame update
    void Start()
    {
        _startingPoint = gameObject.transform.position;
        _destinationPoint = _startingPoint + distance;
    }

    // Update is called once per frame
    void Update()
    {

        if (_isGoingUp)
        {
            _passedTime += Time.deltaTime * movingSpeed;
        }
        else
        {
            _passedTime -= Time.deltaTime * movingSpeed;
        }
        
        
        
        Vector3 result = Vector3.Lerp(_startingPoint, _destinationPoint, _passedTime);

        if (result == _destinationPoint)
        {
            _isGoingUp = false;
        }
        
        if (result == _startingPoint)
        {
            _isGoingUp = true;
        }
        
        gameObject.transform.position = result;
    }
}

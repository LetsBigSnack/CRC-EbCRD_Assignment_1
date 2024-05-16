using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    [Header("Follow - Options")]
    [SerializeField] private Transform objectToFollow;

    private Transform _ownTransform;
    
    private Vector3 _cameraOffset;

    private void Awake()
    {
        _ownTransform = gameObject.transform;
        _cameraOffset = _ownTransform.position - objectToFollow.position;
    }
    
    void LateUpdate()
    {
        Follow();
    }

    void Follow()
    {
        _ownTransform.position = objectToFollow.position + _cameraOffset;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Moving : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _rotateVelocity = 5f;

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal") * _rotateVelocity;
        var vertical = Input.GetAxis("Vertical") * _speed;
        transform.Translate(Vector3.forward * vertical * Time.deltaTime);
        transform.Rotate(0, horizontal, 0);
    }
}
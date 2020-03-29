using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwayBody : MonoBehaviour
{
    public float Degree = 10f;
    public float SwayFactor = 50f;

    private float _currentDegree = 0;
    private SwayDirection _swayDirection = SwayDirection.Left;
    private Transform _transform;

    int currentDirection
    {
        get
        {
            return _swayDirection == SwayDirection.Left ? 1 : -1;
        }
    }

    void changeDirection()
    {
        switch (_swayDirection)
        {
            case SwayDirection.Left:
                _swayDirection = SwayDirection.Right;
                break;

            default:
                _swayDirection = SwayDirection.Left;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        var delta = Time.deltaTime * SwayFactor * currentDirection;

        _currentDegree += delta;

        if (Math.Abs(_currentDegree) >= Degree)
        {
            _currentDegree = Degree * currentDirection;
            changeDirection();
        }

        _transform.localRotation = Quaternion.Euler(0, 0, _currentDegree);
    }
}

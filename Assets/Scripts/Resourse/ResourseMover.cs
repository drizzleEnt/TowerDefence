using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourseMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _elapsedTime = 0;

    private void FixedUpdate()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime <= 3)
            transform.Translate(new Vector3(0, -1, 0) * _speed * Time.deltaTime , Space.World);
    }
}

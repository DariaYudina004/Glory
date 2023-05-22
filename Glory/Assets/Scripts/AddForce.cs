using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    //����� ������ �������� �� �������� �� FPS
    private void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _rigidbody.AddForce(-5, 0f, 0f);
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            _rigidbody.AddForce(5, 0f, 0f);
        }
    }
    
}

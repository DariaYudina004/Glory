using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CraftControl : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float Speed = 5f;
    [SerializeField] private float RotationSpeed = 1f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * RotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * Speed;

        _rigidbody.AddRelativeForce(0f, 0f, forwardForce);
        _rigidbody.AddRelativeTorque(0f, sideForce, 0f);
    }
}

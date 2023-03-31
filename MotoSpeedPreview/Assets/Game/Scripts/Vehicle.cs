using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private WheelJoint2D wheelLeft;
    [SerializeField] private WheelJoint2D wheelRight;
    [SerializeField] private float speed;
    [SerializeField] private float torgue;

    private JointMotor2D _motorLeft;
    private JointMotor2D _motorRight;

    void Update()
    {
        _motorLeft.motorSpeed = speed * Input.GetAxis("Horizontal");
        _motorRight.motorSpeed = speed * Input.GetAxis("Horizontal");
        _motorLeft.maxMotorTorque = torgue;
        _motorRight.maxMotorTorque = torgue;

        wheelLeft.motor = _motorLeft;
        wheelRight.motor = _motorRight;        
    }
}

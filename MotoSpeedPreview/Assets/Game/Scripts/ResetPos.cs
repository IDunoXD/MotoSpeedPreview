using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    [SerializeField] private Transform _initialPosition;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.position = _initialPosition.position;
            transform.rotation = _initialPosition.rotation;
        }        
    }
}

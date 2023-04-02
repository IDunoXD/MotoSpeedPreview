using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform bodyToFollow;
    [SerializeField] float zoom;
    void Update()
    {
        transform.position = new Vector3(bodyToFollow.position.x, bodyToFollow.position.y, zoom);
    }
}

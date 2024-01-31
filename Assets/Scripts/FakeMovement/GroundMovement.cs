using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public Vector3 moveDirection;
    public float moveSpeed = 5.0f;

    void Update()
    {
        transform.Translate(moveDirection.normalized * moveSpeed * Time.deltaTime);
    }
}

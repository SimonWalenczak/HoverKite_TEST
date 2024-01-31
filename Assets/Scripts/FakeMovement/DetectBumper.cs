using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DetectBumper : MonoBehaviour
{
    private Rigidbody rb;
    public LayerMask BumperLayer;          
    public float jumpForce = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Contains(BumperLayer, other.gameObject.layer))
        {
            Jump();
        }
    }
    private static bool Contains(LayerMask mask, int layer)
    {
        return mask == (mask | (1 << layer));
    }
    
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("Scenes/FakeMovement");
    }
}

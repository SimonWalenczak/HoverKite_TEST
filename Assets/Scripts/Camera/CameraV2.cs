using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraV2 : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public Vector3 MiddlePoint;

    private Vector3 offset;

    public float minDist;
    public float maxDist;

    public float zoomMax;
    public float zoomMin;


    public GameObject CloudsBG;
    private Vector3 offsetBG;

    private void Start()
    {
        MiddlePoint = Vector3.Lerp(Player1.transform.position, Player2.transform.position, 0.5f);
        offset = Camera.main.transform.position - MiddlePoint;

        offsetBG = Camera.main.transform.position - CloudsBG.transform.position;
    }
    private void Update()
    {
        MiddlePoint = Vector3.Lerp(Player1.transform.position, Player2.transform.position, 0.5f);

        Camera.main.transform.position = MiddlePoint + offset;

        //Camera.main.fieldOfView = 120;

        if (Vector3.Distance(Player1.transform.position, Player2.transform.position) >= maxDist)
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoomMin, Time.deltaTime);
        }
        else if (Vector3.Distance(Player1.transform.position, Player2.transform.position) <= minDist)
        {
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoomMax, Time.deltaTime);
        }

        CloudsBG.transform.position = Camera.main.transform.position + offsetBG;
    }
}

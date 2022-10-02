using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;
    float RtD = 0;

    void Start()
    {
        //RtD = 57.324f;
        RtD = 25f;
        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            Debug.Log("gyro detected");
            return true;
        }
        else
        {
            Debug.Log("gyro not detected");
            return false;
        }

    }
    private void FixedUpdate()
    {
            gameObject.transform.Rotate(-gyro.rotationRate.x * Time.deltaTime * RtD, gyro.rotationRate.z * Time.deltaTime * RtD * 0f, -gyro.rotationRate.y * Time.deltaTime * RtD);
            gameObject.transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
    }
}

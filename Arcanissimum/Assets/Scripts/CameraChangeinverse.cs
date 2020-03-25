using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeinverse : MonoBehaviour
{
    public GameObject ThirdCam;
    public GameObject FirstCam;
    public int CamMode;

    // Start is called before the first frame update


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.ToString() == "Muro")
        {
            if (CamMode == 0)
            {
                CamMode = 1;
            }
            else
            {
                CamMode -= 1;
            }
        }
    }
}


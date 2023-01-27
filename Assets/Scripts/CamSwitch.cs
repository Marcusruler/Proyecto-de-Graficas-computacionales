using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    void Update (){
        if (Input.GetButtonDown("Cam1")){
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetButtonDown("Cam2")){
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}

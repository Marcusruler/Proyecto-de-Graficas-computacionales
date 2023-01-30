using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    void Update (){
        if (Input.GetButtonDown("Cam1")){
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        if (Input.GetButtonDown("Cam2")){
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        if (Input.GetButtonDown("Cam3")){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }
        if (Input.GetButtonDown("Cam4")){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);
        }
    }
}

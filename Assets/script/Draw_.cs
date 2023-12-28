using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_ : MonoBehaviour
{
    private float myTimer = 0;

    private void OnEnable()
    {
        GetComponent<DrawTextScript>().shortTimer = 0;
        myTimer = 0;
        Debug.Log("Draw");
    }

    private void Update()
    {
        myTimer += Time.deltaTime;

        if (myTimer > 3)
        {
            myTimer = -10;
        }

        if (myTimer < 0 && GetComponent<DrawTextScript>().shortTimer > 3.1 && GetComponent<DrawTextScript>().shortTimer < 3.5)
        {

            GetComponent<MasterScript>().enabled = true;
            GetComponent<Master_Script>().enabled = true;

            GetComponent<TimerScript>().enabled = true;

            GetComponent<CountDown>().setTime = 0;
            GetComponent<Draw_>().enabled = false;
        }
    }
}

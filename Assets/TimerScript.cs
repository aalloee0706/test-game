using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float timer = 0;
    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log (timer);
        if (timer > 5)
        {
            GetComponent<MasterScript>().enabled = false;
            GetComponent<Master_Script>().enabled = false;
            GetComponent<Selection>().enabled = true;
        }
    }
}

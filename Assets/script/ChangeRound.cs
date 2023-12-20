using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRound : MonoBehaviour
{
    public int RoundCount = 1;

    private void OnEnable()
    {
        RoundCount += 1;
        GetComponent<GetHit1>().enabled = false;
        GetComponent<GetHit2>().enabled = false;

        GetComponent<TimerScript>().enabled = true;
        GetComponent<TimerScript>().timer = 0;

        GetComponent<CountDown>().setTime = 0;

        GetComponent<MasterScript>().enabled = true;
        GetComponent<Master_Script>().enabled = true;
    }
}

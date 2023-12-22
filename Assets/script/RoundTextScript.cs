using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundTextScript : MonoBehaviour
{
    public Text RoundText;
    void Update()
    {
        RoundText.text = GetComponent<ChangeRound>().RoundCount.ToString() + " " + "¶ó¿îµå";
    }
}

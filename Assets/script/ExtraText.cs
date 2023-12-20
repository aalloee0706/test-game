using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraText : MonoBehaviour
{
    public Text Combo1Text;
    public Text Combo2Text;
    public Text Health1Text;
    public Text Health2Text;

    private void Update()
    {
        Combo1Text.text = "Combo" + " " + GetComponent<GetHit1>().ComboCount1.ToString();
        Combo2Text.text = "Combo" + " " + GetComponent<GetHit1>().ComboCount2.ToString();
        Health1Text.text = "HP:" + " " + GetComponent<GetHit1>().Health1.ToString();
        Health2Text.text = "HP:" + " " + GetComponent<GetHit2>().Health2.ToString();
    }
}

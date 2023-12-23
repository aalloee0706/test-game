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
    public Text Gold1Text;
    public Text Gold2Text;
    GoldScript goldScript;
    public GameObject gold;

    private void Awake()
    {
        goldScript = gold.GetComponent<GoldScript>();
    }

    private void Update()
    {
        Combo1Text.text = "Combo" + " " + GetComponent<GetHit1>().ComboCount1.ToString();
        Combo2Text.text = "Combo" + " " + GetComponent<GetHit1>().ComboCount2.ToString();
        Health1Text.text = GetComponent<GetHit1>().Health1.ToString() + "/ 100";
        Health2Text.text = GetComponent<GetHit2>().Health2.ToString() + "/ 100";

        Gold1Text.text = goldScript.Gold1.ToString();
        Gold2Text.text = goldScript.Gold2.ToString();
    }
}

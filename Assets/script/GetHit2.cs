using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHit2 : MonoBehaviour
{
    public float Health2 = 100;
    float timer = 0;
    public GameObject itemscript;
    itemUseScript itemuseScript;
    public Animator player1;
    public Animator anime2;

    private void Awake()
    {
        itemuseScript = itemscript.GetComponent<itemUseScript>();
    }
    private void OnEnable()
    {
        timer = 0;
        if (anime2.GetBool("ice") == false)
        {
            Health2 -= Mathf.Pow(GetComponent<GetHit1>().ComboCount1, 2) + GetComponent<GetHit1>().ComboCount1 + 5;
            GetComponent<GetHit1>().ComboCount2 += 1;
            anime2.SetBool("gethit", true);
        }

        GetComponent<GetHit1>().ComboCount1 = 0;
        GetComponent<Hit1>().enabled = false;
        GetComponent<Hit2>().enabled = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.7)
        {
            anime2.SetBool("gethit", false);
        }
        if (timer > 3)
        {
            GetComponent<ChangeRound>().enabled = true;
        }
        if (timer > 0.4)
        {
            player1.transform.position = new Vector3(-4.14f, -0.81f, 0);
        }
    }
}

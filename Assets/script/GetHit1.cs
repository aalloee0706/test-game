using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GetHit1 : MonoBehaviour
{
    public int ComboCount1 = 0;
    public int ComboCount2 = 0;
    public float Health1 = 100;
    float timer = 0;
    public GameObject itemscript;
    itemUseScript itemuseScript;
    public GameObject player2;
    public Animator anime1;

    private void Awake()
    {
        itemuseScript = itemscript.GetComponent<itemUseScript>();
        anime1.SetBool("gethit", false);
    }
    private void OnEnable()
    {
        timer = 0;
        if (anime1.GetBool("ice") == false)
        {
            Health1 -= Mathf.Pow(ComboCount2, 2) + ComboCount2 + 5;
            ComboCount1 += 1;
            anime1.SetBool("gethit", true);
        }

        ComboCount2 = 0;
        GetComponent<Hit1>().enabled = false;
        GetComponent<Hit2>().enabled = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.4)
        {
            player2.transform.position = new Vector3(4.14f, -0.81f, 0);
        }
        if (timer > 0.7)
        {
            anime1.SetBool("gethit", false);
        }
        if (timer > 3)
        {
            GetComponent<ChangeRound>().enabled = true;
        }
    }
}

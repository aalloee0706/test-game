using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHit1 : MonoBehaviour
{
    public int ComboCount1 = 0;
    public int ComboCount2 = 0;
    public float Health1 = 100;
    float timer = 0;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Health1 -= Mathf.Pow(ComboCount2 , 2) + ComboCount2 + 5;

        timer = 0;
        ComboCount1 += 1;
        ComboCount2 = 0;
        GetComponent<Hit1>().enabled = false;
        GetComponent<Hit2>().enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            GetComponent<ChangeRound>().enabled = true;
        }
    }
}

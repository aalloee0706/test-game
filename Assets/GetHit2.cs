using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHit2 : MonoBehaviour
{
    public float Health2 = 100;
    float timer = 0;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Health2 -= Mathf.Pow(GetComponent<GetHit1>().ComboCount1, 2) + GetComponent<GetHit1>().ComboCount1 + 5;

        timer = 0;
        GetComponent<GetHit1>().ComboCount2 += 1;
        GetComponent<GetHit1>().ComboCount1 = 0;
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

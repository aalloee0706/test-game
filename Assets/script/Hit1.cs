using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit1 : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    private void OnEnable()
    {
        timer = 0;
        GetComponent<Victory1>().enabled = false;
        GetComponent<Victory2>().enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            GetComponent<GetHit1>().enabled = true;
        }
    }
}

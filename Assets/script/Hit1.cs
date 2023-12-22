using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit1 : MonoBehaviour
{
    public Animator anime2;
    float timer = 0;

    private void OnEnable()
    {
        timer = 0;
        GetComponent<Victory1>().enabled = false;
        GetComponent<Victory2>().enabled = false;
        anime2.SetTrigger("hit");
        anime2.transform.position = new Vector3(1.78f, -0.81f, 0);
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

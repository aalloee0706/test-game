using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit2 : MonoBehaviour
{
    float timer = 0;
    public Animator anime1;

    private void OnEnable()
    {
        timer = 0;
        GetComponent<Victory1>().enabled = false;
        GetComponent<Victory2>().enabled = false;
        anime1.SetTrigger("hit");
        anime1.transform.position = new Vector3(-1.78f, -0.81f, 0);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            GetComponent<GetHit2>().enabled = true;
        }
    }
}

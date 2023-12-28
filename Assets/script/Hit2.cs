using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit2 : MonoBehaviour
{
    public float timer = 0;
    public Animator anime1;
    public AudioSource hitSound2;

    private void OnEnable()
    {
        timer = 0;
        GetComponent<Victory1>().enabled = false;
        GetComponent<Victory2>().enabled = false;
        anime1.SetTrigger("hit");
        anime1.transform.position = new Vector3(-0.8f, -0.81f, 0);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            GetComponent<GetHit2>().enabled = true;
        }
        if (timer > 0.2f)
        {
            hitSound2.Play();
        }
    }
}

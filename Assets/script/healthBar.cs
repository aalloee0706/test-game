using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider player1_hp;
    public Slider player2_hp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1_hp.value = GetComponent<GetHit1>().Health1;
        player2_hp.value = GetComponent<GetHit2>().Health2;
    }
}

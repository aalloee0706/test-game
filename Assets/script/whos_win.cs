using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whos_win : MonoBehaviour
{
    public float hp1, hp2;
    public GameObject player1_win;
    public GameObject player2_win;
    // Start is called before the first frame update
    void Start()
    {
        player1_win.SetActive(false);
        player2_win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<GetHit2>().Health2 <= 0f)
        {
            Time.timeScale = 0;
            player1_win.SetActive(true);
        }
        else if (GetComponent<GetHit1>().Health1 <= 0)
        {
            Time.timeScale = 0;
            player2_win.SetActive(true);
        }
    }
}

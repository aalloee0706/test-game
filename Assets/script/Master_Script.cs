using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master_Script : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Scissor;
    public GameObject Paper;

    private void OnEnable()
    {
        Rock.transform.localScale = new Vector3(1, 1, 1);
        Scissor.transform.localScale = new Vector3(1, 1, 1);
        Paper.transform.localScale = new Vector3(1, 1, 1);
    }
    private void start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Rock.transform.localScale.x == 1)
        {
            Rock.transform.localScale += new Vector3(1, 1, 1);
            if (Scissor.transform.localScale.x > 1 && Scissor.transform.localScale.y > 1)
            {
                Scissor.transform.localScale -= new Vector3(1, 1, 1);
            }
            if (Paper.transform.localScale.x > 1 && Paper.transform.localScale.y > 1)
            {
                Paper.transform.localScale -= new Vector3(1, 1, 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && Scissor.transform.localScale.x == 1)
        {
            Scissor.transform.localScale += new Vector3(1, 1, 1);
            if (Rock.transform.localScale.x > 1 && Rock.transform.localScale.y > 1)
            {
                Rock.transform.localScale -= new Vector3(1, 1, 1);
            }
            if (Paper.transform.localScale.x > 1 && Paper.transform.localScale.y > 1)
            {
                Paper.transform.localScale -= new Vector3(1, 1, 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && Paper.transform.localScale.x == 1)
        {
            Paper.transform.localScale += new Vector3(1, 1, 1);
            if (Scissor.transform.localScale.x > 1 && Scissor.transform.localScale.y > 1)
            {
                Scissor.transform.localScale -= new Vector3(1, 1, 1);
            }
            if (Rock.transform.localScale.x > 1 && Rock.transform.localScale.y > 1)
            {
                Rock.transform.localScale -= new Vector3(1, 1, 1);
            }
        }

    }
}

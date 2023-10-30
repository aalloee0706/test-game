using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class MasterScript : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Scissor;
    public GameObject Paper;

    private void OnEnable()
    {
        GetComponent<ChangeRound>().enabled = false;
    }
    private void Update()
    {
            if (Input.GetKeyDown("a") && Rock.transform.localScale.x == 1)
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

            if (Input.GetKeyDown("s") && Scissor.transform.localScale.x == 1)
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

            if (Input.GetKeyDown("d") && Paper.transform.localScale.x == 1)
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

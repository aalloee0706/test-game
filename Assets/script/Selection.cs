using UnityEngine;

public class Selection : MonoBehaviour
{
    [SerializeField]
    private GameObject Rock;
    [SerializeField]
    private GameObject Scissor;
    [SerializeField]
    private GameObject Paper;
    [SerializeField]
    private GameObject Rock2;
    [SerializeField]
    private GameObject Scissor2;
    [SerializeField]
    private GameObject Paper2;

    private void Start()
    {
        GetComponent<Selection>().enabled = false;
    }
    private void OnEnable()
    {
        GetComponent<Victory1>().GetHitClick = 0;
        GetComponent<Victory1>().HitClick = 0;
        GetComponent<Victory2>().GetHitClick = 0;
        GetComponent<Victory2>().HitClick = 0;

        GetComponent<TimerScript>().timer = 0;
        GetComponent<TimerScript>().enabled = false;

        if (Rock.transform.localScale.x > 1)
        {
            if (Rock2.transform.localScale.x > 1)
            {
                GetComponent<Draw_>().enabled = true;
            }
            else if (Scissor2.transform.localScale.x > 1)
            {
                GetComponent <Victory1>().enabled = true;
            }
            else if (Paper2.transform.localScale.x > 1)
            {
                GetComponent<Victory2>().enabled = true;
            }
            else
            {
                GetComponent<Victory1>().enabled = true;
            }
        }

        else if (Scissor.transform.localScale.x > 1)
        {
            if (Rock2.transform.localScale.x > 1)
            {
                GetComponent<Victory2>().enabled = true;
            }
            else if (Scissor2.transform.localScale.x > 1)
            {
                GetComponent<Draw_>().enabled = true;
            }
            else if (Paper2.transform.localScale.x > 1)
            {
                GetComponent<Victory1>().enabled = true;
            }
            else 
            {
                GetComponent<Victory1>().enabled = true;
            }
        }

        else if (Paper.transform.localScale.x > 1)
        {
            if (Rock2.transform.localScale.x > 1)
            {
                GetComponent<Victory1>().enabled = true;
            }
            else if (Scissor2.transform.localScale.x > 1)
            {
                GetComponent<Victory2>().enabled = true;
            }
            else if (Paper2.transform.localScale.x > 1)
            {
                GetComponent<Draw_>().enabled = true;
            }
            else
            {
                GetComponent<Victory1>().enabled = true;
            }
        }
        else
        {
            if (Rock2.transform.localScale.x > 1)
            {
                GetComponent<Victory2>().enabled = true;
            }
            else if (Scissor2.transform.localScale.x > 1)
            {
                GetComponent<Victory2>().enabled = true;
            }
            else if (Paper2.transform.localScale.x > 1)
            {
                GetComponent<Victory2>().enabled = true;
            }
            else
            {
                GetComponent<Draw_>().enabled = true;
            }
        }
        GetComponent<Selection>().enabled = false;

        GetComponent<Master_Script>().Rock.transform.localScale = new Vector3(1, 1, 1);
        GetComponent<Master_Script>().Scissor.transform.localScale = new Vector3(1, 1, 1);
        GetComponent<Master_Script>().Paper.transform.localScale = new Vector3(1, 1, 1);

        GetComponent<MasterScript>().Rock.transform.localScale = new Vector3(1, 1, 1);
        GetComponent<MasterScript>().Scissor.transform.localScale = new Vector3(1, 1, 1);
        GetComponent<MasterScript>().Paper.transform.localScale = new Vector3(1, 1, 1);
    }
}

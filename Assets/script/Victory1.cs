using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory1 : MonoBehaviour
{
    [SerializeField]
    private GameObject HitUI;
    [SerializeField]
    private GameObject GetHitUI;
    public int HitClick = 0;
    public int GetHitClick = 0;

    GoldScript goldScript;
    public GameObject GetGold1Win;

    private void Awake()
    {
        HitUI.SetActive(false);
        GetHitUI.SetActive(false);
        goldScript = GetGold1Win.GetComponent<GoldScript>();
    }
    private void OnEnable()
    {
        Debug.Log("Victory1");
        HitUI.SetActive(true);
        GetHitUI.SetActive(true);
        goldScript.Gold1 += 2;
        goldScript.Gold2 += 3;
    }

    private void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            HitClick += 1;

            if (HitUI.transform.localScale.x == 0.5)
            {
                HitUI.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

                if (GetHitUI.transform.localScale.x > 0.5)
                {
                    GetHitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    GetHitClick = 0;
                }
            }
        }
        if (Input.GetKeyDown("d"))
        {
            GetHitClick += 1;

            if (GetHitUI.transform.localScale.x == 0.5)
            { 
                GetHitUI.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

                if (HitUI.transform.localScale.x > 0.5f)
                {
                    HitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    HitClick = 0;
                }
            }
        }

        if (Input.GetKeyDown("a") && HitClick == 2)
        {
            GetComponent<Hit2>().enabled = true;
            HitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            GetHitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            HitUI.SetActive(false);
            GetHitUI.SetActive(false);
        }
        if (Input.GetKeyDown("d") && GetHitClick == 2)
        {
            GetComponent<Hit1>().enabled = true;
            HitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            GetHitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            HitUI.SetActive(false);
            GetHitUI.SetActive(false);
        }
    }
}

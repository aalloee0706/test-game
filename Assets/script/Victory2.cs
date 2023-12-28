using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Victory2 : MonoBehaviour
{
    [SerializeField]
    private GameObject HitUI;
    [SerializeField]
    private GameObject GetHitUI;
    public int HitClick = 0;
    public int GetHitClick = 0;

    public GameObject GetGold2Win;

    private void Awake()
    {
        HitUI.SetActive(false);
        GetHitUI.SetActive(false);
    }
    private void OnEnable()
    {
        Debug.Log("Victory2");
        HitUI.SetActive(true);
        GetHitUI.SetActive(true);
        GetGold2Win.GetComponent<GoldScript>().Gold2 += 2;
        GetGold2Win.GetComponent<GoldScript>().Gold1 += 3;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            HitClick += 1;

            if (HitUI.transform.localScale.x == 0.5)
            {
                HitUI.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

                if (GetHitUI.transform.localScale.x > 0.5)
                {
                    GetHitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    GetHitClick = 0;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetHitClick += 1;

            if (GetHitUI.transform.localScale.x == 0.5)
            {
                GetHitUI.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);

                if (HitUI.transform.localScale.x > 0.5f)
                {
                    HitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    HitClick = 0;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && HitClick == 2)
        {
            HitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            GetHitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            HitUI.SetActive(false);
            GetHitUI.SetActive(false);
            GetComponent<Hit1>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && GetHitClick == 2)
        {
            HitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            GetHitUI.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            HitUI.SetActive(false);
            GetHitUI.SetActive(false);
            GetComponent<Hit2>().enabled = true;
        }
    }
}

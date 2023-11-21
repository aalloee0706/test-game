using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUseScript : MonoBehaviour
{
    public GameObject Iceitem1;
    public GameObject Hpitem1;
    public GameObject VictoryRockitem1;
    public GameObject ComboDoubleitem1;

    public int IceClick = 0;
    public int HpClick = 0;
    public int VictoryRockClick = 0;
    public int ComboDoubleClick = 0;
    [SerializeField]
    public bool IceUsed1;

    [SerializeField]
    float timer = 0;

    GetHit1 gethit1;

    public GameObject Hp1;

    private void Awake()
    {
        gethit1 = Hp1.GetComponent<GetHit1>();

        IceUsed1 = false;
        timer = 0;
    }
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.5)
        {
            IceUsed1 = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            IceClick += 1;
            Iceitem1.transform.localScale += new Vector3(0.2f, 0.2f);
            if (HpClick == 1 || VictoryRockClick == 1 || ComboDoubleClick == 1)
            {
                Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);
                ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                HpClick = 0;
                VictoryRockClick = 0;
                ComboDoubleClick = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            HpClick += 1;
            Hpitem1.transform.localScale += new Vector3(0.2f, 0.2f);
            if (IceClick == 1 || VictoryRockClick == 1 || ComboDoubleClick == 1)
            {
                Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);
                ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                IceClick = 0;
                VictoryRockClick = 0;
                ComboDoubleClick = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            VictoryRockClick += 1;
            VictoryRockitem1.transform.localScale += new Vector3(0.5f, 0.5f);
            if (IceClick == 1 || HpClick == 1 || ComboDoubleClick == 1)
            {
                Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                HpClick = 0;
                IceClick = 0;
                ComboDoubleClick = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ComboDoubleClick += 1;
            ComboDoubleitem1.transform.localScale += new Vector3(0.2f, 0.2f);
            if (IceClick == 1 || VictoryRockClick == 1 || HpClick == 1)
            {
                Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);
                Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                HpClick = 0;
                VictoryRockClick = 0;
                IceClick = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && IceClick == 2)
        {
            if (GetComponent<GoldScript>().Gold1 >= 10)
            {
                Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                GetComponent<GoldScript>().Gold1 -= 10;
                timer = 0;
                IceUsed1 = true;
                IceClick = 0;
            }
            else
            {
                Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                IceClick = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && HpClick == 2)
        {
            if (GetComponent<GoldScript>().Gold1 >= 10)
            {
                Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                GetComponent<GoldScript>().Gold1 -= 10;
                gethit1.Health1 += 15;
                HpClick = 0;
            }
            else
            {
                Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                HpClick = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && VictoryRockClick == 2)
        {
            if (GetComponent<GoldScript>().Gold1 >= 10)
            {
                VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);
                GetComponent<GoldScript>().Gold1 -= 10;
                VictoryRockClick = 0;
            }
            else
            {
                VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);
                VictoryRockClick = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.R) && ComboDoubleClick == 2)
        {
            if (GetComponent<GoldScript>().Gold1 >= 15)
            {
                ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                GetComponent<GoldScript>().Gold1 -= 15;
                gethit1.ComboCount1 *= 2;
                ComboDoubleClick = 0;
            }
            else
            {
                ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);
                ComboDoubleClick = 0;
            }
        }
    }
}

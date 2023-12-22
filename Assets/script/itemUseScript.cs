using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemUseScript : MonoBehaviour
{
    public int IceClick1 = 0;
    public int IceClick2 = 0;
    public int HpClick1 = 0;
    public int HpClick2 = 0;
    public int VictoryRockClick1 = 0;
    public int VictoryRockClick2 = 0;
    public int ComboDoubleClick1 = 0;
    public int ComboDoubleClick2 = 0;

    public GameObject Iceitem1;
    public GameObject Iceitem2;
    public GameObject Hpitem1;
    public GameObject Hpitem2;
    public GameObject VictoryRockitem1;
    public GameObject VictoryRockitem2;
    public GameObject ComboDoubleitem1;
    public GameObject ComboDoubleitem2;


    [SerializeField]
    public bool IceUsed1;
    [SerializeField]
    public bool IceUsed2;
    [SerializeField]
    float timer = 0;
    [SerializeField]
    float timer2 = 0;

    GetHit1 gethit1;
    GetHit2 gethit2;
    MasterScript masterScript1;
    Master_Script masterScript2;

    public GameObject Hp1;
    public GameObject Hp2;
    public GameObject Masterscipt1;
    public GameObject Masterscipt2;
    public Animator anime1;
    public Animator anime2;

    private void Awake()
    {
        gethit1 = Hp1.GetComponent<GetHit1>();
        gethit2 = Hp2.GetComponent<GetHit2>();
        masterScript1 = Masterscipt1.GetComponent<MasterScript>();
        masterScript2 = Masterscipt2.GetComponent<Master_Script>();
        

        anime1.SetBool("ice", false);
        anime2.SetBool("ice", false);
        timer = 0;
        timer2 = 0;
    }
    public void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;

        if (timer > 1)
        {
            anime1.SetBool("ice", false);
        }

        if (timer2 > 1)
        {
            anime2.SetBool("ice", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            IceClick1 += 1;
            Iceitem1.transform.localScale += new Vector3(0.1f, 0.1f);
            Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
            VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);
            ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);

            HpClick1 = 0;
            VictoryRockClick1 = 0;
            ComboDoubleClick1 = 0;

            if (Input.GetKeyDown(KeyCode.Q) && IceClick1 >= 2)
            {
                Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);

                if (GetComponent<GoldScript>().Gold1 >= 10)
                {
                    GetComponent<GoldScript>().Gold1 -= 10;
                    timer = 0;
                    anime1.SetBool("ice", true);
                }
                IceClick1 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            HpClick1 += 1;
            Hpitem1.transform.localScale += new Vector3(0.2f, 0.2f);
            Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
            VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);
            ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);

            IceClick1 = 0;
            VictoryRockClick1 = 0;
            ComboDoubleClick1 = 0;

            if (Input.GetKeyDown(KeyCode.W) && HpClick1 >= 2)
            {
                Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);

                if (GetComponent<GoldScript>().Gold1 >= 10)
                {
                    GetComponent<GoldScript>().Gold1 -= 10;
                    gethit1.Health1 += 15;
                }
                HpClick1 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            VictoryRockClick1 += 1;
            VictoryRockitem1.transform.localScale += new Vector3(0.5f, 0.5f);
            Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
            Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
            ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);

            IceClick1 = 0;
            HpClick1 = 0;
            ComboDoubleClick1 = 0;

            if (Input.GetKeyDown(KeyCode.E) && VictoryRockClick1 >= 2)
            {
                VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);

                if (GetComponent<GoldScript>().Gold1 >= 10)
                {
                    GetComponent<GoldScript>().Gold1 -= 10;
                    masterScript2.enabled = false;
                    masterScript2.Scissor.transform.localScale = new Vector3(2, 2, 2);
                }
                VictoryRockClick1 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ComboDoubleClick1 += 1;
            ComboDoubleitem1.transform.localScale += new Vector3(0.2f, 0.2f);
            Iceitem1.transform.localScale = new Vector3(0.5f, 0.5f);
            Hpitem1.transform.localScale = new Vector3(0.5f, 0.5f);
            VictoryRockitem1.transform.localScale = new Vector3(1.7f, 1.7f);

            IceClick1 = 0;
            HpClick1 = 0;
            VictoryRockClick1 = 0;

            if (Input.GetKeyDown(KeyCode.R) && ComboDoubleClick1 >= 2)
            {
                ComboDoubleitem1.transform.localScale = new Vector3(0.5f, 0.5f);

                if (GetComponent<GoldScript>().Gold1 >= 15)
                {
                    GetComponent<GoldScript>().Gold1 -= 15;
                    gethit1.ComboCount1 *= 2;
                }
                ComboDoubleClick1 = 0;
            }
        }
        ////////////////////////////////////////////////////////////
        if (Input.GetKeyDown(KeyCode.U))
        {
            IceClick2 += 1;
            Iceitem2.transform.localScale += new Vector3(0.1f, 0.1f);
            Hpitem2.transform.localScale = new Vector3(0.5f, 0.5f);
            VictoryRockitem2.transform.localScale = new Vector3(1.7f, 1.7f);
            ComboDoubleitem2.transform.localScale = new Vector3(0.5f, 0.5f);

            HpClick2 = 0;
            VictoryRockClick2 = 0;
            ComboDoubleClick2 = 0;

            if (Input.GetKeyDown(KeyCode.U) && IceClick2 >= 2)
            {
                Iceitem2.transform.localScale = new Vector3(0.5f, 0.5f);

                if (GetComponent<GoldScript>().Gold2 >= 10)
                {
                    GetComponent<GoldScript>().Gold2 -= 10;
                    timer2 = 0;
                    anime2.SetBool("ice", true);
                }
                IceClick2 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            HpClick2 += 1;
            Hpitem2.transform.localScale += new Vector3(0.2f, 0.2f);
            Iceitem2.transform.localScale = new Vector3(0.5f, 0.5f);
            VictoryRockitem2.transform.localScale = new Vector3(1.7f, 1.7f);
            ComboDoubleitem2.transform.localScale = new Vector3(0.5f, 0.5f);

            IceClick2 = 0;
            VictoryRockClick2 = 0;
            ComboDoubleClick2 = 0;

            if (Input.GetKeyDown(KeyCode.I) && HpClick2 >= 2)
            {
                Hpitem2.transform.localScale = new Vector3(0.5f, 0.5f);

                if (GetComponent<GoldScript>().Gold2 >= 10)
                {
                    GetComponent<GoldScript>().Gold2 -= 10;
                    gethit2.Health2 += 15;
                }
                HpClick2 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            VictoryRockClick2 += 1;
            VictoryRockitem2.transform.localScale += new Vector3(0.5f, 0.5f);
            Iceitem2.transform.localScale = new Vector3(0.5f, 0.5f);
            Hpitem2.transform.localScale = new Vector3(0.5f, 0.5f);
            ComboDoubleitem2.transform.localScale = new Vector3(0.5f, 0.5f);

            IceClick2 = 0;
            HpClick2 = 0;
            ComboDoubleClick2 = 0;

            if (Input.GetKeyDown(KeyCode.O) && VictoryRockClick2 >= 2)
            {
                VictoryRockitem2.transform.localScale = new Vector3(1.7f, 1.7f);

                if (GetComponent<GoldScript>().Gold2 >= 10)
                {
                    GetComponent<GoldScript>().Gold2 -= 10;
                    masterScript1.enabled = false;
                    masterScript1.Scissor.transform.localScale = new Vector3(2, 2, 2);
                }
                VictoryRockClick2 = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ComboDoubleClick2 += 1;
            ComboDoubleitem2.transform.localScale += new Vector3(0.2f, 0.2f);
            Iceitem2.transform.localScale = new Vector3(0.5f, 0.5f);
            Hpitem2.transform.localScale = new Vector3(0.5f, 0.5f);
            VictoryRockitem2.transform.localScale = new Vector3(1.7f, 1.7f);

            IceClick2 = 0;
            HpClick2 = 0;
            VictoryRockClick2 = 0;

            if (Input.GetKeyDown(KeyCode.P) && ComboDoubleClick2 >= 2)
            {
                ComboDoubleitem2.transform.localScale = new Vector3(0.5f, 0.5f);

                if (GetComponent<GoldScript>().Gold2 >= 15)
                {
                    GetComponent<GoldScript>().Gold2 -= 15;
                    gethit1.ComboCount2 *= 2;
                }
                ComboDoubleClick2 = 0;
            }
        }
    }
}

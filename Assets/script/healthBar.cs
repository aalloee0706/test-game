
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider player1_hp;
    public Slider player2_hp;
    public GameObject player1_win;
    public GameObject player2_win;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        player1_win.SetActive(false);
        player2_win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        player1_hp.value = GetComponent<GetHit1>().Health1;
        player2_hp.value = GetComponent<GetHit2>().Health2;

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

        if (GetComponent<GetHit1>().Health1 > 100)
        {
            GetComponent<GetHit1>().Health1 = 100;
        }
        if (GetComponent<GetHit2>().Health2 > 100)
        {
            GetComponent<GetHit2>().Health2 = 100;
        }
    }
}

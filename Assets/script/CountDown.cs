using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float setTime = 0;
    public Text countdownText;

    void Start()
    {
        countdownText.text = setTime.ToString();
    }

    private void Update()
    {
        setTime += Time.deltaTime;
        countdownText.text = Mathf.Round(5 - setTime).ToString();

        if (setTime > 5)
        {
            countdownText.text = " ";
        }
    }
}

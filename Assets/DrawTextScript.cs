using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawTextScript : MonoBehaviour
{

    public Text DrawText;
    public float shortTimer = 3;

    private void Start()
    {
        DrawText.text = " ";
    }

    private void Update()
    {
        shortTimer += Time.deltaTime;

        if (shortTimer > 3)
        {
            DrawText.text = " ";
        }

        else if (shortTimer < 3)
        {
            DrawText.text = "DRAW";
        }
    }
}

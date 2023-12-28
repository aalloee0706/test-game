using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time_pause : MonoBehaviour
{
    public GameObject canvas_ingame;
    public GameObject canvas_pause;
    public bool ispause = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas_ingame.SetActive(true);
        canvas_pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && ispause == false)
        {
            ispause = true;
            Time.timeScale = 0;
            canvas_ingame.SetActive(false);
            canvas_pause.SetActive(true);
            return;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && ispause == true)
        {
            ispause = false;
            Time.timeScale = 1;
            canvas_ingame.SetActive(true);
            canvas_pause.SetActive(false);
            return; ;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Managemant : MonoBehaviour
{
        public void gotoingame()
        {
        SceneManager.LoadScene("Scene_InGame");
        Time.timeScale = 1;
        }
        public void gotorule()
        {
        SceneManager.LoadScene("Scene_Rule");
        Time.timeScale = 1;
        }
        public void gotoMain()
        {
        SceneManager.LoadScene("Scene_start");
        Time.timeScale = 1;
        }
}

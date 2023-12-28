using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Managemant : MonoBehaviour
{
        public void Maintoingame()
        {
            SceneManager.LoadScene("Scene_InGame");
        }
        public void Maintorule()
        {
            SceneManager.LoadScene("Scene_Rule");
        }
        public void ingametoMain()
        {
        Time.timeScale = 1;
        SceneManager.LoadScene("Scene_start");
        }
}

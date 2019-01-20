using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goto_title : MonoBehaviour
{


    /*public void ButtonClicked()
    {
        SceneManager.LoadScene("corotine_game_start");
    }*/

        public void Sample()
       {
        SceneManager.LoadScene("corotine_game_start");
         }

    public void ButtonClicked()
    {
        Invoke("Sample", 2);
    }
}

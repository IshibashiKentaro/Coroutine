using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goto_title2 : MonoBehaviour
{

    public void Gotostarts()
    {
        SceneManager.LoadScene("corotine_game_start");
    }
    public void ButtonClicked()
    {
        Invoke("Gotostarts",2);
    }
}

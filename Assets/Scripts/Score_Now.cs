using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Now : MonoBehaviour
{
    public GUIStyle guiStyle;
    public static int time;
    public static int highScore;
    public Text NowTime;
    public Text BestTime;

    void Start()
    {
        // guiStyle = new GUIStyle();

         guiStyle.fontSize = 20;
         int now_time = GameController.gettime();
        int best_time = GameController.gethighScore();
    }

    void Update()
    {
        NowTime.text = "Time : " + time;
        BestTime.text = "Best : " + highScore;
    }


    /*void OnGUI()
    {
        GUI.color = Color.white;

        Rect position1 = new Rect(0, 0, 800, 160);
        Rect position2 = new Rect(90, 70, 800, 160);

        GUI.Label(position1, "Score", guiStyle);
        GUI.Label(position2, time.ToString(), guiStyle);
    }*/
}
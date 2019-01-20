using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamScript : MonoBehaviour
{
    public GameObject enemy;
    public GUIStyle guiStyle;
    GameObject[] enemies;
    public float totalTime;//ここから２行
    int seconds;

    void Start()
    {
        guiStyle = new GUIStyle();
        guiStyle.fontSize = 20;
    }


    void Update()
    {
        totalTime -= Time.deltaTime;//ここから２行
        seconds = (int)totalTime;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

        void OnGUI()
    {
        Rect position1 = new Rect(90, 50, 800, 160);
        Rect position2 = new Rect(90, 70, 800, 160);
        Rect position3 = new Rect(90, 120, 800, 160);
        Rect position4 = new Rect(90, 160, 800, 160);

        GUI.Label(position1, "Enemies", guiStyle);
        GUI.Label(position2, enemies.Length.ToString(), guiStyle);
        GUI.Label(position3, "Timer", guiStyle);
        if (totalTime >= 0)
        {
            GUI.Label(position4, seconds.ToString(), guiStyle);
        }
        else
        {
            GUI.Label(position4, "0", guiStyle);
        }
    }
}
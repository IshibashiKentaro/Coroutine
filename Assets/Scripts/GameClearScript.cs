using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearScript : MonoBehaviour
{

    void OnGUI()
    {

        GUIStyle guiStyle = new GUIStyle();
        GUIStyleState styleState = new GUIStyleState();

        styleState.textColor = Color.black;

        guiStyle.normal = styleState;
        guiStyle.fontSize = 120;

        GUI.Label(new Rect(100, 100, 400, 130), "Game Clear !!", guiStyle);
    }

}
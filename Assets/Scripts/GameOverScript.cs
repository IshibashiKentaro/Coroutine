using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{

    void OnGUI()
    {

        GUIStyle guiStyle = new GUIStyle();
        GUIStyleState styleState = new GUIStyleState();

        styleState.textColor = Color.white;

        guiStyle.normal = styleState;
        guiStyle.fontSize = 120;

        GUI.Label(new Rect(100, 100, 400, 130), "Game Over ...", guiStyle);
    }

}
﻿using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneHelper.NextScene();
    }

    public void Quit()
    {
        Application.Quit();
    }
}

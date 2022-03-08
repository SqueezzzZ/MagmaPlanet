using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public string loadscene = "";
    public void onClickButtn(int ID)
    {
        switch (ID)
        {
            case 0: { SceneManager.LoadScene(loadscene, LoadSceneMode.Single); break; }
            case 1: { Application.Quit(); break; }
        }
    }
}

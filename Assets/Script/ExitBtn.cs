using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBtn : MonoBehaviour
{
    public void OnClickExitBtn()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}

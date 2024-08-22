using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    public void OnClickPlayBtn()
    {
        _panel.SetActive(false);
        
    }

}
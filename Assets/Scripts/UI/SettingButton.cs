using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButton : MonoBehaviour
{
    public  GameObject panelSetting;
    public GameObject panelPause;

    public void OpenPanel()
    {
        if(panelSetting)
        {
            panelSetting.SetActive(true);
        }
        else
        {
            panelPause.SetActive(false);
        }
    }

    
}

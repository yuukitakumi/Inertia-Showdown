using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreenTog : MonoBehaviour
{
    public void Change()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }


}

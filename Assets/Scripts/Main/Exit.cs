using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public void EndGame()
    {
       
            UnityEditor.EditorApplication.isPlaying = false;
    }     
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class LoadSceneButton : MonoBehaviour
{
 
   
    public void NewGame()
        {
            PixelCrushers.SaveSystem.LoadScene("SampleScene");

        }
    public void LoadGame()
        {
            PixelCrushers.SaveSystem.LoadFromSlot(1);
        }
}

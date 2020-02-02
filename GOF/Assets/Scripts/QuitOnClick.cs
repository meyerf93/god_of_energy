using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used for the main menu
public class QuitOnClick : MonoBehaviour {

	public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#else
        Application.Quit();
#endif
    } 
}

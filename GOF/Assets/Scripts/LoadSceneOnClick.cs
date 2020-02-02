using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Used for the main menu

public class LoadSceneOnClick : MonoBehaviour {

    public bool isImgClicked = false;

	// Use this for initialization
	public void LoadByIndex (int sceneIndex) {
        SceneManager.LoadScene (sceneIndex);
	}

    public void ImageClicked() {
        //If building is clicked in Gallery we load the appropriate scene
        isImgClicked = true;
        LoadByIndex(1);
    }
}

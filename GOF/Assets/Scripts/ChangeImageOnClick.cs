using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class ChangeImageOnClick : MonoBehaviour {

    public Sprite[] gallery; //store all your images in here at design time
    public Image displayImage; //The current image thats visible
    public Button nextImg; //Button to view next image
    public Button prevImg; //Button to view previous image
    public int i = 0; //Will control where in the array you are

    // Use this for initialization
    void Start () {	
        displayImage.sprite = Resources.Load<Sprite>("Level_1") as Sprite;
       /* displayImage.sprite = Resources.Load<Sprite>("Images/2") as Sprite;
        displayImage.sprite = Resources.Load<Sprite>("Images/3") as Sprite;
        displayImage.sprite = Resources.Load<Sprite>("Images/4") as Sprite;
        displayImage.sprite = Resources.Load<Sprite>("Images/5") as Sprite;
        displayImage.sprite = Resources.Load<Sprite>("Images/6") as Sprite;*/
    }
	
	

    public void BtnNext () {
        if (i + 1 < gallery.Length)
        {
            i++;
        }
    }

    public void BtnPrev () {
        if (i - 1 >= 0){
            i--;
        }
    }

    // Update is called once per frame
    void Update () {
        displayImage.sprite = gallery[i];
    }
}

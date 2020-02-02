using UnityEngine;
using UnityEngine.UI;

public class LevelChoiceButtons : MonoBehaviour {

    public Sprite[] listSprite;
    public Image mainImage;

	private LevelManagement levelManagement;
    private int countClick;

	void Start()
	{
        countClick = 0;
        if (listSprite[countClick] != null) mainImage.sprite = listSprite[countClick];
		levelManagement = FindObjectOfType<LevelManagement> ();
	}

	public void btnNextClicked()
	{
        if(countClick < (listSprite.Length-1))
        {
            countClick++;
            mainImage.sprite = listSprite[countClick];
        }
		levelManagement.next ();
	}

	public void btnPreviousClicked()
	{
        if (countClick > 0)
        {
            countClick--;
            mainImage.sprite = listSprite[countClick];
        }
        levelManagement.previous ();
	}
}

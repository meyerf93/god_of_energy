using UnityEngine;
using UnityEngine.UI;

public class ZoneGaugeManager : MonoBehaviour 
{
	public Text levelTimer;
	public Slider ecoSlider;
	public Slider comfortSlider;
	public Slider moneySlider;
	public Text ecoText;
	public Text comfortText;
	public Text moneyText;

	public void updateTimer(int value)
	{
		levelTimer.text = value.ToString();
	}

	public void updateDollar(int value)
	{
		moneySlider.value = value;
		moneyText.text = value.ToString();
	}

	public void updateEco(int value)
	{
		ecoSlider.value = value;
		ecoText.text = value.ToString ();
	}

	public void updateComfort(int value)
	{
		comfortSlider.value = value;
		comfortText.text = value.ToString();
	}


}

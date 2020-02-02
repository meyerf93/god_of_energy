using UnityEngine;
using UnityEngine.UI;

public class shopTest : MonoBehaviour {
	
    public ZoneGaugeManager sliderManager;

	public BarModifier barModifier;
	public MoneyController moneyController;
	public EcoController ecoController;
	public ConfortController confortController;
	private LevelTimer levelTimer;
	public Text ecoTextModifier;
    public Text comfortTextModifier;
    public Text moneyTextModifier;

	// Use this for initialization
	void Start () 
	{
		levelTimer = FindObjectOfType<LevelTimer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (levelTimer == null) {
			levelTimer = FindObjectOfType<LevelTimer> ();

            sliderManager.updateTimer(0);
            sliderManager.updateDollar((int)moneyController.getValue());
            sliderManager.updateEco((int)ecoController.getValue());
			sliderManager.updateComfort((int)confortController.getValue());

            moneyTextModifier.text = barModifier.getMoneyModifier().ToString();
            ecoTextModifier.text = barModifier.getEcoModifier().ToString();
            comfortTextModifier.text = barModifier.getComfortModifier().ToString();

            /*text.text = "money :  " + Mathf.RoundToInt(moneyController.getValue ()) +", modifier : " + barModifier.getMoneyModifier() + "\n" + 
				"eco :  " + (int)ecoController.getValue()  + ", modifier : " + barModifier.getEcoModifier() + "\n" 
				+ "comfort :  " + (int)confortController.getValue()  + ", modifier : " + barModifier.getComfortModifier() +  "\n" ;*/

        } else 
		{
            
            float timeElapsed = Time.deltaTime;
			moneyController.barUpdate (timeElapsed);
			ecoController.barUpdate (timeElapsed);
			confortController.barUpdate (timeElapsed);

            sliderManager.updateTimer((int)levelTimer.targetTime);
            sliderManager.updateDollar((int)moneyController.getValue());
            sliderManager.updateEco((int)ecoController.getValue());
            sliderManager.updateComfort((int)confortController.getValue());

            moneyTextModifier.text = barModifier.getMoneyModifier().ToString();
            ecoTextModifier.text = barModifier.getEcoModifier().ToString();
            comfortTextModifier.text = barModifier.getComfortModifier().ToString();


            /*text.text = "money :  " + (int)moneyController.getValue () +", modifier : " + barModifier.getMoneyModifier() + "\n" + 
				"eco :  " + (int)ecoController.getValue()  + ", modifier : " + barModifier.getEcoModifier() + "\n" 
				+ "comfort :  " + (int)confortController.getValue()  + ", modifier : " + barModifier.getComfortModifier() +  "\n" 
				+ "time Left : " + (int)levelTimer.targetTime;*/

        }

	}
}

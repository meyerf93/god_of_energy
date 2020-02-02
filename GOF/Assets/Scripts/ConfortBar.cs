using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used for the Health Bar

public class ConfortBar: MonoBehaviour {

    public float max_Health = 100f;
    public float cur_Health = 0f;
    public GameObject confortBar;

	// Use this for initialization
	void Start () {
        cur_Health = max_Health;
        InvokeRepeating("decreasehealth", 1f, 1f);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void decreasehealth() {
        if (cur_Health > 0f) {
            cur_Health -= 2f;
            float calc_Health = cur_Health / max_Health; // if cur_Health 80 / 100 = 0.8f
            setHealthBar(calc_Health);
        }
    }

    public void setHealthBar(float myHealth) {
        //myHealth value between 0 and 1

        confortBar.transform.localScale = new Vector3(myHealth, confortBar.transform.localScale.y, confortBar.transform.localScale.z);
    }
}

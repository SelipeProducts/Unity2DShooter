using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusIndicator : MonoBehaviour {
    [SerializeField]
    private RectTransform healthBarRect;
    //serializedfield
    private Text healthText;


	// Use this for initialization
	void Start () {
        if (healthBarRect == null) {
            Debug.LogError("Status Indicator: NO helath bar obje reference");
        }
        //if text obj null
	}
    public void setHealth(int _curHealth, int _maxHealth) {
        float _value =(float) _curHealth / _maxHealth;

        healthBarRect.localScale = new Vector3(_value, healthBarRect.localScale.y, healthBarRect.localScale.z);
        //changetext as well
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

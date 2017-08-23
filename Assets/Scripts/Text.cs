using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour {
    GameObject hpSilder;
    GameObject hpText;

   Text text;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ViewSilderValue()
    {
        hpSilder = GameObject.Find("HPSilder");
        hpText = GameObject.Find("HPText");
        float val;
        val = hpSilder.GetComponent<Slider>().value;
     //   this.GetComponent<Text>().text = "12134";
     //   hpText.GetComponent<Text>().text = hpSilder.GetComponent<Slider>().value.ToString();

    }
}

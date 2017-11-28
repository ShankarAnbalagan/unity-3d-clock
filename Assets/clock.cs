using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour {

    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;

    void Awake()
    {
        hoursTransform.localRotation = Quaternion.Euler(0f,DateTime.Now.Hour*30f,0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Minute*6f, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Second*6f, 0f);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hoursTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Hour*30f, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Minute*6f, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Second*6f, 0f);

    }
}

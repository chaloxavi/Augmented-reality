using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAR;


public class ExtenderTraker : MonoBehaviour {

	public GameObject Target;
	public GameObject ContainerTarget;
	public float timeActiveOnTargetlose = .5f;


	bool detected= false;
	float timer=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Target.activeSelf == true) {
			detected = true;
			timer = 0f;
		} else {
		
			detected = false;
		
		}

		if (Target.activeSelf == false && timer < timeActiveOnTargetlose) {
			ContainerTarget.transform.SetParent (this.transform);
			timer += Time.deltaTime;
		} else if(Target.activeSelf==false){
			ContainerTarget.transform.SetParent (Target.transform);
		}
		
	}
}

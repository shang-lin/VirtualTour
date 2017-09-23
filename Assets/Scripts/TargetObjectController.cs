using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class TargetObjectController : MonoBehaviour {

	VRInteractiveItem vrItem;

	// Use this for initialization
	void Awake () {
		//transform.localPosition.y = 0;
		vrItem = GetComponent<VRInteractiveItem>();
	}

	void OnEnable() {
		if (vrItem != null) {
			vrItem.OnClick += HandleClick;
		}
	}

	void OnDisable() {
		if (vrItem != null) {
			vrItem.OnClick -= HandleClick;
		}
	}

	void HandleClick() {
		Destroy (gameObject);
	}


	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.UI;

/**
 * This class controls a button that is a VRInteractiveItem.
 **/
public class VRButtonController : MonoBehaviour {

	VRInteractiveItem vrItem;
	Button button;

	void Awake () {
		// Get the VRInteractiveItem and the Button.
		vrItem = GetComponent<VRInteractiveItem> ();
		button = GetComponentInChildren<Button> ();
	}

	void OnEnable() {
		// Subscribe the button's onClick function to
		// vrItem's.
		vrItem.OnClick += button.onClick.Invoke;
	}

	void OnDisable() {
		vrItem.OnClick -= button.onClick.Invoke;
	}

}

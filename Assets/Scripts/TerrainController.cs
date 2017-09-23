using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour {

	public Transform sphere;

	// Use this for initialization
	void Start () {
		Instantiate(sphere, new Vector3(0f, transform.position.y, 0f), Quaternion.identity, transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		LogMgr.Log("111111");
		LogMgr.Warning("22222");
		LogMgr.Error("33333");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

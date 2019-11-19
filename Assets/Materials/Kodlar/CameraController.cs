using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CameraController : MonoBehaviour {
    public InputField yazi; 
    public GameObject player;
    private Vector3 offset;
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
		void LateUpdate () {

        transform.position = player.transform.position + offset;
		
	}
  }

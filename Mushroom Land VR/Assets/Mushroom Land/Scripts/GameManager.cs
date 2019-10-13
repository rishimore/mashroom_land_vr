using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Transform[] spwanPoints;

	public GameObject player;

	int spwanPointindex = 0;

	bool changePosition;

	// Use this for initialization
	void Start () {
		player.transform.position = spwanPoints [0].position;
	}

	public void OnPointerEnter(){
		changePosition = true;
		StartCoroutine ("TransferPlayer");
	}

	public void OnPointerExit(){
		changePosition = false;
		StopCoroutine ("TransferPlayer");
	}

	IEnumerator TransferPlayer(){

		yield return new WaitForSeconds (2);

		if (changePosition = true) {

			spwanPointindex = spwanPointindex + 1;

			if (spwanPointindex >= spwanPoints.Length) {
				spwanPointindex = 0;
			}
				
			player.transform.position = spwanPoints [spwanPointindex].position;
			Debug.Log ("change new spwanpoint" + spwanPointindex);
		}
	}
}

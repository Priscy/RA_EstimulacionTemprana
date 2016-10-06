using UnityEngine;
using System.Collections;

public class LoadCardManager : MonoBehaviour {
	public GameObject cardManager;
	// Use this for initialization
	void Start () {
		StartCoroutine(Example());
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(5);
		cardManager.SetActive (true);
		print(Time.time);
	}
}

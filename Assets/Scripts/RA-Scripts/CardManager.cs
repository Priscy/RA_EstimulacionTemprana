using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class CardManager : MonoBehaviour {

	public GameObject card;
	private MarkerTracker markerTracker;
	private List<Card> cards;
		// Use this for initialization
	void Start () {
		generateCards ();
	}

		// Update is called once per frame
	void Update () {

	}

		//generate 3d object
	public void generateCards(){
			//if(Constantes.isDebugging)Debug.Log("generateCards");
		cards = new List<Card> ();
			//TODO generate random cards
		Card c0 = new Card();
		Card c1 = new Card();
		Card c2 = new Card();
		Card c3 = new Card();
		Card c4 = new Card();
		Card c5 = new Card();
		Card c6 = new Card();
		Card c7 = new Card();
		Card c8 = new Card();
		Card c9 = new Card();

		cards.Add (c0);
		cards.Add (c1);
		cards.Add (c2);
		cards.Add (c3);
		cards.Add (c4);
		cards.Add (c5);
		cards.Add (c6);
		cards.Add (c7);
		cards.Add (c8);
		cards.Add (c9);
			//
		int count = 0;
		foreach(Card card in cards){
			generateCard(card,count);
			count++;
		}
	}

	public void generateCard(Card c,int id){
		//if(Constantes.isDebugging)Debug.Log("generateCard: "+c);
		if(markerTracker==null){
			markerTracker = TrackerManager.Instance.GetTracker<MarkerTracker> ();
		}
		//create marker 
		MarkerAbstractBehaviour mab = markerTracker.CreateMarker (id,"Frame_"+id,1);
		Debug.Log ("Marker_"+id+" created");
		//add listener for appeard/disappeard
		MarkerBehaviour ma=mab.GetComponent<MarkerBehaviour>();
		mab.gameObject.AddComponent<DefaultTrackableEventHandler> ();
		//add like childs to CardManager gameobject
		mab.gameObject.transform.parent=gameObject.transform;


			//add prefab like a child to Marker
		//card.gameObject.transform.localScale += new Vector3(0.1F,0.1F,0.1F);
		GameObject instance=NGUITools.AddChild(mab.gameObject,card);
		instance.name="Card-"+id;
			//set values from the card
		//CardControllerv2 cc=instance.GetComponent<CardControllerv2>();
		//cc.generateCard (c);
			//calculate guiStatus


		
	


	}

}

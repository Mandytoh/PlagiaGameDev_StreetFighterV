using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	public Player[] players;

	public void Start(){
		
		//Ici, le player 1 choisit Black mamba
		Player player1 = players [0];
		Debug.Log ("Le player1 va selectionner le perso Black mamba");
		GameObject character = GameObject.Find ("Black mamba");
		player1.selectCharacter (character);

		/*
		//Ici, le player 2 choisit BlackMamba
		Player player2 = players [1];
		Debug.Log ("Le player2 va selectionner le perso Black mamba");
		GameObject blackMamba = GameObject.Find ("Black mamba");
		player2.selectCharacter (blackMamba);
		
		//Enfin de compte, le player 2 choisit Guile
		Debug.Log ("Le player2 va selectionner le perso Guile");
		GameObject ryu = GameObject.Find ("Guile");
		player2.selectCharacter (ryu);
		*/
	}
}

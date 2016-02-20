using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public string displayName = "CharacterUnknown";
	public string[] specialHits; 

	public void SpecialHitsExists(string inputsStr){
		if (specialHits.Length > 0) {
			foreach (string specialHit in specialHits) {
				if(specialHit == inputsStr){
					Debug.Log ("COUP SPECIAL : " + specialHit);
					//Je tape à combien ?
					//Est-ce une chope ? L'autre joueur est à coté ?
					//Intération avec l'UI
					//Intération avec l'animation
				}
			}
		}
	}

}

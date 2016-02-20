using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public Character character;
	public List<string> inputs = new List<string>();
	public int nbFrameToDeleteInput = 40;
	public int countFrameToDeleteInput = 0;

	public void selectCharacter( GameObject newCharacterGO ){

		if (newCharacterGO == null) {

			Debug.Log ("Non mais qu'est ce que tu as ? Ce perso n'existe pas !");

		} else {

			GameObject oldCharacterGO = GameObject.Find (this.character.name);
			if (oldCharacterGO != null) {
				oldCharacterGO.GetComponent<SpriteRenderer>().enabled = false;
			}

			Character newCharacter = newCharacterGO.GetComponent<Character> ();

			Debug.Log (this.name + " a selectionné le perso : " + newCharacter.displayName);

			this.character = newCharacter;
			newCharacterGO.GetComponent<SpriteRenderer>().enabled = true;

		}

	}

	public void Update(){
		countFrameToDeleteInput++;

		if (countFrameToDeleteInput >= nbFrameToDeleteInput) {
			if(inputs.Count > 0){
				this.inputs.RemoveAt(inputs.Count-1);
				this.getInputsDebugLog();
			}
			countFrameToDeleteInput = 0;
		}

		if(Input.anyKeyDown == true){
			this.inputs.Add(Input.inputString);

			string inputsStr = "";
			foreach( string input in inputs )
			{
				inputsStr += input + "/";
			}
			this.character.SpecialHitsExists(inputsStr);

			countFrameToDeleteInput = 0;
			this.getInputsDebugLog();
     	}

	}

	private void getInputsDebugLog(){
		/*string inputsStr = "";
		foreach( string input in inputs )
		{
			inputsStr += input + "/";
		}
		
		Debug.Log (inputsStr);*/
	}

}

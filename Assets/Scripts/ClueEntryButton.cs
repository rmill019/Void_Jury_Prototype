using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueEntryButton : MonoBehaviour {

	public void GrabRelatedClue ()
	{
		Debug.LogWarning ("BUTTON WAS PRESSED");
		string name = this.transform.parent.GetChild (0).GetComponent<Image> ().sprite.name;
		if (name != null)
		{
			//TODO Comment this if statement
			print ("Name: " + name);
			// Grabbing the correct index of the matching ClueInfo based on the name of the Clue ImageName in the ClueEntry menu of Jury_Scene
			int clueIndex = ClueManager._dictClueNameToIndex [name];
			// We are adding the matching clue information based on which clue was selected in the Menus of clues built in Jury_Scene
			ClueManager._cluesToPresent.Add (ClueManager._clueInfoOfCollected [clueIndex]);
			print ("ClueIndex is: " + clueIndex);
		}
		else
		{
			Debug.LogWarning ("This Sprite is unassigned");
		}
	}

}

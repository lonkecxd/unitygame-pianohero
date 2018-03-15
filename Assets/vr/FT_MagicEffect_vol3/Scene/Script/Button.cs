using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public Transform effectToPlay; //Particle effect you want to play
	public Vector3 effectPos;

	
	void OnMouseDown() {
		StartCoroutine(PlayEffect());
	}
	
	 IEnumerator PlayEffect() {		
        yield return new WaitForSeconds(0.4f);

		// Instantate the particle effect in front of the object  
		Transform effect = Instantiate ( effectToPlay, effectPos, Quaternion.identity ) as Transform;	

    }

}

using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour {

    public float moveSpeed = 5f;
    Vector3 movementInput;

	void Update () {
        movementInput = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical")) * Time.deltaTime;
        transform.Translate(movementInput * moveSpeed);
	}
}

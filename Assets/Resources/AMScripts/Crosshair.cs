using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {
    Rect crosshairRect;
    Texture crosshairTexture;

	// Use this for initialization
	void Start () {
        float crosshairSize = Screen.width * 0.025f;
        crosshairTexture = (Texture)Resources.Load("Textures/crosshair1");
        crosshairRect = new Rect(Screen.width / 2 - crosshairSize, Screen.height / 2 - crosshairSize / 2, crosshairSize, crosshairSize);
    
	}
	
	// Update is called once per frame
	void OnGUI () {
        GUI.DrawTexture(crosshairRect, crosshairTexture);
	}
}

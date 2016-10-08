using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	bool looking= false;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

		if (looking) {
			OnLook ();
		} else {
			this.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
      	
		}
    }

    public void OnLook()
    {
      
        this.GetComponent<Renderer>().material.shader = Shader.Find("Custom/ImageEffectShader"); 
        this.GetComponent<Renderer>().material.SetColor("_OutlineColor", Color.cyan);

    }
}


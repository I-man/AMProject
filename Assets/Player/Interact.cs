using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

   
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

      
      //  this.GetComponent<Renderer>().material.shader = Shader.Find("Standard");;
        
    }

    public void OnLook()
    {
      
        this.GetComponent<Renderer>().material.shader = Shader.Find("Custom/ImageEffectShader"); 
        this.GetComponent<Renderer>().material.SetColor("_OutlineColor", Color.cyan);
    }
}


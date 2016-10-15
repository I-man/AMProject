using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {
    public GameObject InfoPrefab;
    public GameObject secPrefab;
    public bool active = false;
    public bool active2 = false;
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

    public void activatePrefab() {

        if (active == false && InfoPrefab != null) {
            InfoPrefab.SetActive(true);
            active = true;

        }



    }
    public void deactivatePrefab()
    {

        if (active)
        {
            InfoPrefab.SetActive(false);
            active = false;
            secPrefab.SetActive(false);
            active2 = false;
        }
    }

         public void activatesecPrefab() { 
    

        if (active == true && InfoPrefab != null)
        {
            secPrefab.SetActive(true);
          
            active2 = true;
        }



    }
}


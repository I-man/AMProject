using UnityEngine;
using System.Collections;

public class PlayerRaycast : MonoBehaviour {

    public float distanceToObject = 5;
    //Vector3 me = new Vector3(Screen.width / 2, Screen.height, 0);
    RaycastHit whatIHit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       //Ray ray = Camera.main.ScreenPointToRay(me);

		Debug.DrawRay(this.transform.position, this.transform.forward * distanceToObject, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToObject))
        {

			Debug.Log("I touched " + whatIHit.collider.gameObject.name);
			//if (Input.GetKeyDown(KeyCode.E)) 
			//{
				
				if (whatIHit.collider.gameObject.GetComponent<Interact>() != null)
				{
					whatIHit.collider.gameObject.GetComponent<Interact>().OnLook();



                if (Input.GetMouseButtonDown(0))
                {
                    if (!whatIHit.collider.gameObject.GetComponent<Interact>().active)
                {
                    
                        whatIHit.collider.gameObject.GetComponent<Interact>().activatePrefab();
                    } else if (whatIHit.collider.gameObject.GetComponent<Interact>().active == true)
                    {
                      
                            whatIHit.collider.gameObject.GetComponent<Interact>().deactivatePrefab();
                        
                    }
                }

				}else if (whatIHit.collider.gameObject.GetComponentInChildren<Interact>() != null)
            {
                whatIHit.collider.gameObject.GetComponentInChildren<Interact>().OnLook();



                if (Input.GetMouseButtonDown(0))
                {
                    if (!whatIHit.collider.gameObject.GetComponentInChildren<Interact>().active)
                    {

                        whatIHit.collider.gameObject.GetComponentInChildren<Interact>().activatePrefab();
                    }
                    else if (whatIHit.collider.gameObject.GetComponentInChildren<Interact>().active == true)
                    {

                        whatIHit.collider.gameObject.GetComponentInChildren<Interact>().deactivatePrefab();

                    }
                }
            }
			//}

           
        }

	}
}

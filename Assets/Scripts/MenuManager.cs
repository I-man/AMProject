
using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

     public int menuID=0;
     public GameObject[] menuPanels;
	 private GameObject welcomePanel;
     private GameObject mainMenuPanel;
     private GameObject tutorialPanel;
     private GameObject schedulePanel;
     private GameObject mapPanel;
     private GameObject cameraPanel;
	 private GameObject sharePanel;

     // Use this for initialization
     void Start () {
         menuPanels = GameObject.FindGameObjectsWithTag("MenuPanel");
		 welcomePanel=GameObject.Find("welcomePanel");
         mainMenuPanel = GameObject.Find("MainMenuPanel");
		 tutorialPanel = GameObject.Find("tutorialPanel");
		 schedulePanel = GameObject.Find("schedulePanel");
		 mapPanel = GameObject.Find("mapPanel");
		 cameraPanel = GameObject.Find("cameraPanel");
		 sharePanel = GameObject.Find("sharePanel");


 //        int playerNum = PlayerInfo.playerID;
 //        Debug.Log (playerNum);
         switchToMenu (menuID);
     }

     // Update is called once per frame
     void Update () {

     }

     public void switchToMenu(int menuID) {

         foreach(GameObject panel in menuPanels)
         {
 //            panel.gameObject.renderer.enabled=false;
             panel.gameObject.SetActive(false);
             Debug.Log (panel.name);
         }

         switch (menuID) {
             case 0:
			welcomePanel.gameObject.SetActive(true);
                 break;
             case 1:
			mainMenuPanel.gameObject.SetActive(true);
                 break;
             case 2:
			tutorialPanel.gameObject.SetActive(true);
                 break;
             case 3:
			schedulePanel.gameObject.SetActive(true);
                 break;
             case 4:
			mapPanel.gameObject.SetActive(true);
                 break;
             case 5:
			cameraPanel.gameObject.SetActive(true);
                 break;
			 case 6:
			sharePanel.gameObject.SetActive(true);
				break;
         }
     }
 }

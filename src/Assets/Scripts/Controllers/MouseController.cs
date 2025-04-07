using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		// Right = 0, Left = 1, Middle = 2
		if(Input.GetMouseButtonDown(0)) 
			mouseRightClicked();

		if(Input.GetMouseButtonDown(1)) 
			mouseLeftClicked();
	}

	private void mouseRightClicked() {
		// Player interaction function here
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit)) {

            string objectName = hit.collider.gameObject.name;

            if (PlayerController.instance == null)
                return;
            if (GameObject.Find(objectName) == null)
                return;

            Vector3 playerPosition = PlayerController.instance.playerPosition;
            Vector3 objectPosition = GameObject.Find(objectName).transform.position;
            if (objectPosition == null)
                return;

            float distance = Vector3.Distance(playerPosition, objectPosition);

            switch (objectName)
            {
                case "Timo": { 
                    if(Timo.instance.DistanceToActivate < distance) 
                        Timo.instance.Interaction(); 
                    break; 
                }
                case "Hiukkaskiihdytin": { 
                    if(UniversityObject.instance.DistanceToActivate < distance) 
                        UniversityObject.instance.Interaction(); 
                    break; 
                }
                case "UniversityDoor": {
                    if(UniversityDoor.instance.DistanceToActivate < distance) 
                        UniversityDoor.instance.Interaction(); 
                    break; 
                }
                case "WallPlaneInteract":
                    {
                        if (GameJamSide.instance.DistanceToActivate < distance)
                            GameJamSide.instance.Interaction();
                        break;
                    }  
                
                case "GameJamObject": { 
                    if(GameJamObject.instance.DistanceToActivate < distance) 
                        GameJamObject.instance.Interaction(); 
                    break;
                }               
			}
		}
	}

	private void mouseLeftClicked() {
		// Player movement function here
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit)) {
			if(hit.collider.gameObject.tag == "Ground")
                if (PlayerController.instance != null)
				    PlayerController.instance.setMovePosition (hit.point);
		}
	}
}

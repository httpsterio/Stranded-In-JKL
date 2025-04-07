using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager instance { get; private set; }

	public string doUser { get; private set; }
    public bool forceAIConversation = false;
    public bool nowPressed { get; private set; }

    private bool pokeDexActivated = false;
    private bool introShow = true;

    private ConversationManager conversationManager;

	// Use this for initialization
	void Awake () {
		instance = this;
        doUser = "";
        nowPressed = false;
        conversationManager = new ConversationManager(forceAIConversation);
	}

    void Update()
    {
        if (Dialoguer.GetGlobalString(0) != "")
            if (Dialoguer.GetGlobalString(0) != Application.loadedLevelName)
                LevelChanger(Dialoguer.GetGlobalString(0));

        if (introShow)
        {
            introShow = false;

            switch (Application.loadedLevelName)
            {
                case "CompassLevel": { Conversation(2); break; }
                case "UniversityOutsideLevel": { Conversation(5); break; }
                case "UniversityInsideLevel": { Conversation(10); break; }
                case "GameJamLevel": { Conversation(13); break; }
            }
        }
    }

	// GUI elements
	void OnGUI() {	
		changePickupColors ();
	}

	private void changePickupColors() {
		GameObject UI = GameObject.Find("UI");
        if (UI != null)
        {
            GameObject Scan = GameObject.Find("Scanner");

            Image pickup0 = getChildGameObject(Scan, "Pickup0").GetComponent<Image>();
            Image pickup1 = getChildGameObject(Scan, "Pickup1").GetComponent<Image>();
            Image pickup2 = getChildGameObject(Scan, "Pickup2").GetComponent<Image>();

            if (Dialoguer.GetGlobalBoolean(0))
                pickup0.color = Color.green;
            else
                pickup0.color = Color.gray;

            if (Dialoguer.GetGlobalBoolean(1))
                pickup1.color = Color.green;
            else
                pickup1.color = Color.gray;

            if (Dialoguer.GetGlobalBoolean(2))
                pickup2.color = Color.green;
            else
                pickup2.color = Color.gray;
        }
		
	}

	public void guiEventWhatClicked() {
		string levelName = Application.loadedLevelName;

		switch (levelName) {
			case "CompassLevel": {
				// compass level dialogue here
				break;
			}
			case "GameJamLevel": {
				// Game jam level dialogue here
				break;
			}
			case "UniversityOutsideLevel": {
				// University outseide level dialogue here
				break;
			}
			case "UniversityInsideLevel": {
				// University outside level dialogue here
				break;
			}
		}
	}

	public void guiEventDoAIClicked() {
		doUser = "AI";
	}

	public void guiEventWeClicked() {
		GameObject UI = GameObject.Find ("UI");
		GameObject Scanner = getChildGameObject (UI, "Scanner");
		
		if (pokeDexActivated) {				
			Scanner.SetActive (false);
			pokeDexActivated = false;
		} else {
			Scanner.SetActive (true);
			pokeDexActivated = true;
		}
	}

	public void guiEventDoAlienClicked() {
		doUser = "ALIEN";
	}

	public void guiEventNowClicked() {
        if (!Dialoguer.GetGlobalBoolean(3))
            Conversation(21);
        else
            nowPressed = true;
	}

	static public GameObject getChildGameObject(GameObject fromGameObject, string withName) {
		Transform[] ts = fromGameObject.transform.GetComponentsInChildren<Transform>(true);

        foreach (Transform t in ts)
        {
            if (t.gameObject.name == withName) return t.gameObject;
        }      

		return null;
	}

    public void LevelChanger(string levelName)
    {
        Application.LoadLevel(levelName);
        Dialoguer.SetGlobalString(0, "");

        introShow = true;
    }

    public void Conversation(int index)
    {
        conversationManager.startConversation(index);
    }
}

using UnityEngine;
using System.Collections;

public class UniversityObject : MonoBehaviour {
    public static UniversityObject instance { get; private set; }

    public float DistanceToActivate = 1f;
    private bool destroyed = false;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (!destroyed)
        {
            if (Dialoguer.GetGlobalBoolean(1))
            {
                destroyed = true;
                //Destroy(GameObject.Find("Hiukkaskiihdytin"));
            }
        }
    }

    public void Interaction()
    {
        string user = GameManager.instance.doUser;
        if (user.Equals("ALIEN"))
        {
            GameManager.instance.Conversation(12); 
        }
                  
        else if (user.Equals("AI"))
        {
            GameManager.instance.Conversation(11);
        }
        else 
            GameManager.instance.Conversation(22);
    }
	
}

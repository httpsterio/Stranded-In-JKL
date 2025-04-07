using UnityEngine;
using System.Collections;

public class GameJamObject : MonoBehaviour {
    public static GameJamObject instance { get; private set; }

    public float DistanceToActivate = 1f;
    private bool destroyed = false;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if(!destroyed)
        {
            if (Dialoguer.GetGlobalBoolean(2))
            {
                destroyed = true;
                // destroy game jam object
            }
        }      
    }

    public void Interaction()
    {
        string user = GameManager.instance.doUser;
        if (user.Equals("ALIEN"))
            GameManager.instance.Conversation(18);
        else if (user.Equals("AI"))
            GameManager.instance.Conversation(17);
        else
            GameManager.instance.Conversation(22);
    }
}

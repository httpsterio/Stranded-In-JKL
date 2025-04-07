using UnityEngine;
using System.Collections;

public class Timo : MonoBehaviour {
    public static Timo instance { get; private set; }

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
            if (Dialoguer.GetGlobalBoolean(0))
            {
                destroyed = true;
                //Destroy(GameObject.Find("Timo"));
            }
        }       
    }

    public void Interaction()
    {
        string user = GameManager.instance.doUser;
        if (user.Equals("ALIEN"))
            GameManager.instance.Conversation(4);
        else if (user.Equals("AI"))
            GameManager.instance.Conversation(3);
        else
            GameManager.instance.Conversation(22);
    }
}

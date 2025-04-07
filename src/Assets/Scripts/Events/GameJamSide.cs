using UnityEngine;
using System.Collections;

public class GameJamSide : MonoBehaviour {
    public static GameJamSide instance { get; private set; }

    public float DistanceToActivate = 1f;
    private bool destroyed = false;

    void Start()
    {
        instance = this;
    }

    public void Interaction()
    {
        string user = GameManager.instance.doUser;
        if (user.Equals("ALIEN"))
            GameManager.instance.Conversation(15);
        else if (user.Equals("AI"))
            GameManager.instance.Conversation(14);
        else
            GameManager.instance.Conversation(22);
    }
}

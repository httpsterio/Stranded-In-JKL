using UnityEngine;
using System.Collections;

public class UniversityDoor : MonoBehaviour {
    public static UniversityDoor instance { get; private set; }

    public float DistanceToActivate = 1f;

    private bool destroyObject;

    void Start()
    {
        instance = this;
    }

    public void Interaction()
    {
        string user = GameManager.instance.doUser;
        if (user.Equals("ALIEN"))
        {
            GameManager.instance.Conversation(9);
            Application.LoadLevel("UniversityInsideLevel");
        }            
        else if (user.Equals("AI"))
        {
            GameManager.instance.Conversation(8);
        }
            
        else
            GameManager.instance.Conversation(22);
    }


}

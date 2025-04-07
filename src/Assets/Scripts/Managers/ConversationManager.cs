using System.Collections;

public class ConversationManager {

    private bool forceAIConversation = false;
    private bool compassTimoAI = false;
    private bool universityOutSignAI = false;
    private bool universityOutDoorAI = false;
    private bool universityInObjectAI = false;
    private bool gameJamSideAI = false;
    private bool gameJamCornerObjectAI = false;


    public ConversationManager(bool forceAIConversation) 
    {
        this.forceAIConversation = forceAIConversation;
    }

    public void startConversation(int index) 
    {    
        switch (index)
        {
            /*  Intro  */
            case 0:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.Start_Intro);
                    break;
                }

            /*  After Crash  */
            case 1:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.Start_AfterCrash);
                    break;
                }

            /*  Compass Intro  */
            case 2:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.Compass_Intro);
                    break;
                }

            /*  Compass Timo AI */
            case 3:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.Compass_Timo_AI_Before);
                    compassTimoAI = true;
                    break;
                }

            /*  Compass Timo Alien */
            case 4:
                {
                    if (forceAIConversation)
                        if(!compassTimoAI) 
                            Dialoguer.StartDialogue(DialoguerDialogues.Compass_Timo_AI_Before);
                            
                    Dialoguer.StartDialogue(DialoguerDialogues.Compass_Timo_Alien_Before);

                    break;
                }

            /*  University Outside Intro  */
            case 5:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityOut_Intro);
                    break;
                }

            /*  University Outside Sign AI  */
            case 6:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityOut_Sign_AI);
                    universityOutSignAI = true;
                    break;
                }

            /*  University Outside Sign Alien  */
            case 7:
                {
                    if (forceAIConversation)
                        if (!universityOutSignAI)
                            Dialoguer.StartDialogue(DialoguerDialogues.UniversityOut_Sign_AI);

                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityOut_Sign_Alien);
                    break;
                }

            /*  University Outside Door AI  */
            case 8:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityOut_Door_AI);
                    universityOutDoorAI = true;
                    break;
                }

            /*  University Outside Door Alien  */
            case 9:
                {
                    if (forceAIConversation)
                        if (!universityOutDoorAI)
                            Dialoguer.StartDialogue(DialoguerDialogues.UniversityOut_Door_AI);

                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityOut_Door_Alien);
                    break;
                }

            /*  University Inside Intro  */
            case 10:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityIn_Intro);
                    break;
                }

            /*  University Inside Object AI  */
            case 11:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityIn_Object_AI);
                    universityInObjectAI = true;
                    break;
                }

            /*  University Inside Object Alien  */
            case 12:
                {
                    if (forceAIConversation)
                        if (!universityInObjectAI)
                            Dialoguer.StartDialogue(DialoguerDialogues.UniversityIn_Object_AI);

                    Dialoguer.StartDialogue(DialoguerDialogues.UniversityIn_Object_Alien);
                    break;
                }

            /*  Game Jam Intro  */
            case 13:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.GameJam_Intro);
                    break;
                }

            /*  Game Jam Side AI  */
            case 14:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.GameJam_Side_AI);
                    gameJamSideAI = true;
                    break;
                }

            /*  Game Jam Side Alien  */
            case 15:
                {
                    if (forceAIConversation)
                        if (!gameJamSideAI)
                            Dialoguer.StartDialogue(DialoguerDialogues.GameJam_Side_AI);

                    Dialoguer.StartDialogue(DialoguerDialogues.GameJam_Side_Alien);
                    break;
                }

            /*  Game Jam Corner Intro  */
            case 16:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.GameJamCorner_Intro);
                    break;
                }

            /*  Game Jam Corner Object AI  */
            case 17:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.GameJamCorner_Object_AI);
                    gameJamCornerObjectAI = true;
                    break;
                }

            /*  Game Jam Corner Object Alien  */
            case 18:
                {
                    if (forceAIConversation)
                        if (!gameJamCornerObjectAI)
                            Dialoguer.StartDialogue(DialoguerDialogues.GameJamCorner_Object_AI);

                    Dialoguer.StartDialogue(DialoguerDialogues.GameJamCorner_Object_Alien);
                    break;
                }

            /*  Ship Intro  */
            case 19:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.Ship_Intro);
                    break;
                }

            /*  Ship Leave  */
            case 20:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.Ship_Leave);
                    break;
                }

            case 21:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.General_NotNow);
                    break;
                }

            case 22:
                {
                    Dialoguer.StartDialogue(DialoguerDialogues.General_UserNotSelected);
                    break;
                }
        }
    }
}

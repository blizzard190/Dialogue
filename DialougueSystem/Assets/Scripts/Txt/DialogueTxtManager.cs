using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTxtManager : MonoBehaviour {

    public TxtNPC target;

    public void TriggerDialogue()
    {
        target.StartDialog();
    }
}

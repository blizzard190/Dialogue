using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TxtNPC : MonoBehaviour {

    public Animator animator;
    public TextAsset textFile;
    public Text nameText;
    public Text dialogueText;
    public bool storeNPC;

    private bool _namer = false;
    private bool _writing = false;
    private string _sentences;
    private string[] _dialogLines;
    private Queue<string> _senten;


    void Start()
    {
        if (textFile)
        {
            _dialogLines = (textFile.text.Split("\n"[0]));
        }

        _senten = new Queue<string>();
    }

    public void StartDialog()
    {

        animator.SetBool("IsOpen", true);
        Debug.Log(animator.GetBool("IsOpen"));
        _senten.Clear();

        foreach(string sentences in _dialogLines)
        {
            _senten.Enqueue(sentences);
        }

        _sentences = _senten.Dequeue();

       // DisplaySentence();
        CheckName();
    }

    public void DisplaySentence()
    {
        if (_senten.Count == 0)
        {
            EndDialogue();
            return;
        }

        if (!_writing)
        {
            _sentences = _senten.Dequeue();
            if (_sentences.Contains("<"))
            {
                CheckName();
                return;
            }
            else
            {
                StopAllCoroutines();
                StartCoroutine(TypeSentence(_sentences));
            }
        }
        else if (_writing)
        {
            StopAllCoroutines();
            dialogueText.text = _sentences;
            _writing = false;
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        int max = 0;
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            max++;
            dialogueText.text += letter;
            yield return null;
            if(max == sentence.ToCharArray().Length)
            {
                _writing = false;
            }
            else
            {
                _writing = true;
            }
        }
    }

    public void CheckName()
    {
        if (_sentences.Contains("<"))
        {
            string name;
            name = _sentences.Substring(_sentences.IndexOf("<") + 1, _sentences.IndexOf(">") - 1);
            Debug.Log(name);
            nameText.text = name;
            _namer = true;
        }
        Debug.Log(_senten.Count);
        DisplaySentence();
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        if (storeNPC)
        {
            //Start Store script();
        }
    }
}

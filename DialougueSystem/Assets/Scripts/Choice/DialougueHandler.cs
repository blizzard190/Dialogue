using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougueHandler : MonoBehaviour {

    /*public Animator animator;
    public TextAsset textFile;
    public Text nameText;
    public Text dialougueText;

    [SerializeField]
    private bool _StoreNPC;
    private bool _Writing = false;
    private string _Sentence;
    private string[] _DialougueLines;
    private int _Current;

    private void Start()
    {
        if (textFile)
        {
            _DialougueLines = (textFile.text.Split("\n"[0]));
            /*for(int i = 0; i < _DialougueLines.Length; i++)
            {
                Debug.Log(_DialougueLines[i]);
            }
        }
    }

    public void StartDialog()
    {
        animator.SetBool("Isopen", true);
        _Current = 0;
        _Sentence = _DialougueLines[_Current];
        Checker();
    }

    public void GetSentence()
    {
        if(_Current == _DialougueLines.Length + 1)
        {
            EndDialogue();
        }
        if (_Writing)
        {
            StopAllCoroutines();
            dialougueText.text = _Sentence;
            _Writing = false;
        }else if (!_Writing){
            if (!Checker())
            {
                StopAllCoroutines();
                _Current++;
                StartCoroutine(typeSentence(_Sentence));
            }
            else if (Checker())
            {
                GetSentence();
            }
        }
    }

    /*private void CheckContent()
    {
        if (_Sentence.Contains("<"))
        {
            namer();
        }
        else if (_Sentence.Contains("/"))
        {
            Pointer();
        }
        else
        {
            GetSentence();
        }
    }

    private void Pointer()
    {
        int point;
        int.TryParse(_Sentence.Substring(_Sentence.IndexOf("/") + 1, _Sentence.IndexOf("*") - 2), out point);
        _Current = point--;
        _Sentence = _DialougueLines[_Current];
        //CheckContent();
    }

    private void namer()
    {
        string name;
        name = _Sentence.Substring(_Sentence.IndexOf("<") + 1, _Sentence.IndexOf(">") - 2);
        nameText.text = name;
        _Current++;
        _Sentence = _DialougueLines[_Current];
        //CheckContent();
    }

    private bool Checker()
    {
        if (_Sentence.Contains("<"))
        {
            namer();
            return true;
        }
        else if (_Sentence.Contains("/"))
        {
            Pointer();
            return true;
        }
        else
        {
            return false;
        }
    }
*/
}

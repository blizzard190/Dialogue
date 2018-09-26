using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue{

    public string name;

    /// <summary>
    /// In stead of the public string array get a .txt and read the text in it.
    /// </summary>

    [TextArea(3, 10)]
    public string[] sentences;

}

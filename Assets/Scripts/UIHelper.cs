using UnityEngine;
using System.Collections;

public class UIHelper : MonoBehaviour {
    public static TextMesh mText;
	// Use this for initialization
	void Start () {
        mText = GetComponent<TextMesh>();
	}
	
    public static void ChangeText(string newText)
    {
        mText.text = newText;
    }

}

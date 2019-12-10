using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ReadScores : MonoBehaviour
{
    public Text fileContents;

    private void Awake() //NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {
        string path = "Assets/scores.txt";

        // In case we want to use appending of text.
        //string appendText = "This is extra text" + "\n";
        //File.AppendAllText(path, appendText);

        fileContents.text = ""; // clear the text on screen

        // Open the file to read from.
        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Debug.Log(s);
            fileContents.text += s + "\n"; // append and go to new line
        }
    }

}

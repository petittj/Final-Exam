using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class WriteScript : MonoBehaviour
{
    public void WriteString()//NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {
        string path = "Assets/scores.txt";

        // get text from the inputfield
        string Name = KeepData.PlayerName;
        string score = KeepData.PlayerScore.ToString();


        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(Name + ", "+score );
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("Scores"); // NEED TO CAST AS A TEXT ASSET SO IT CAN BE USED. TRY WITHOUT.
    }
}

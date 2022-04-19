using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;

public class GetEmailText : MonoBehaviour
{
    //where the location of the text lines are 
    public Transform contentWindow;

    public GameObject recallTextObject;
    void Start()
    {
        //Path for file
        string readFromFilePath = Application.streamingAssetsPath + "/Recall_Email/" + "Email" + ".txt";

        //List of type string to hold lines from text file to a list
        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        //iterate through list
        foreach (string line in fileLines)
        {
            Instantiate(recallTextObject, contentWindow);

            recallTextObject.GetComponent<TMP_Text>().text = line;

        }
       
    }
}

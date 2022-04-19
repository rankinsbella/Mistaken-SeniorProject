using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;
using System;

public class GetPostText : MonoBehaviour
{


    public Transform contentWindow;

    public GameObject recallTextObject;
    public TMP_Text post0;
    public TMP_Text post1;
    public TMP_Text post2;
    public TMP_Text post3;
    public TMP_Text post4;


    void Start()
     {
    //Path for file
     string readFromFilePath = Application.streamingAssetsPath + "/Recall_Post/" + "Post" + ".txt";

    //List of type string to hold lines from text file to a list
      List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

    //iterate through list
        foreach (string line in fileLines)
         {
          Instantiate(recallTextObject, contentWindow);

            this.post0.text = recallTextObject.GetComponent<TMP_Text>().text = line;
            this.post1.text = recallTextObject.GetComponent<TMP_Text>().text = line;
            this.post2.text = recallTextObject.GetComponent<TMP_Text>().text = line;
            this.post3.text = recallTextObject.GetComponent<TMP_Text>().text = line;
            this.post4.text = recallTextObject.GetComponent<TMP_Text>().text = line;
            recallTextObject.GetComponent<TMP_Text>().text = line;


        }

      }
}

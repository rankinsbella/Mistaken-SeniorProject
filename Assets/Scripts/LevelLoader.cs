using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;

    public Button Button;



   


    // Update is called once per frame
    void Update()
    {
        Button Button = gameObject.GetComponent<Button>();
        Button.onClick.AddListener(LoadNextLevel);

    }
    
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

        
}

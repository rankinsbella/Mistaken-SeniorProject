using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameStatus: MonoBehaviour
    // initializing resource variables and UI elements to be displayed
{
    public int popularity;
    public int credibility;
    public int funding;
    int maxPopularity = 100;
    int maxCredibility = 100;
    int maxFunding = 200;
    int minPopularity = 35;
    int minFunding = 35;
    int minCredibility = 35;

    //UI elements displayed
    public  TMP_Text popularityGauge;
    public TMP_Text credibilityGauge;
    public TMP_Text fundingGauge;

    // Start is called before the first frame update
    // declaring resource variables and printing variables 
    // in the UI element
    void Start()
    {
        if(GameStatus.Instance != null)
        {
            popularity = minPopularity;
            credibility = minCredibility;
            funding = minFunding;
            updateText();
        }
        
    }

    // creating method to add to funding resource at cost of other resources
    public void postHighFunding()
    {
        funding = funding + 5;
        popularity = popularity - 3;
        credibility = credibility - 3;
        updateText();
    }
    public void postLowFunding()
    {
        funding = funding - 5;
        popularity = popularity - 3;
        credibility = credibility - 3;
        updateText();
    }

    public void postHighPopularity()
    {
        popularity = popularity + 5;
        funding = funding - 2;
        credibility = credibility - 2;
        updateText();
    }
    public void postLowPopularity()
    {
        popularity = popularity - 5;
        funding = funding - 3;
        credibility = credibility - 1;
        updateText();
    }
    public void postHighCredibility()
    {
        credibility = credibility + 5;
        popularity = popularity - 2;
        funding = funding - 2;
        updateText();
    }

    public void postLowCredibility()
    {
        credibility = credibility - 5;
        popularity = popularity - 2;
        funding = funding - 2;
        updateText();
    }
    public void updateText()
        //the text of the UI is updated
    {
        if(popularity > maxPopularity)
        {
            popularity = maxPopularity;
        }
        if(funding > maxFunding)
        {
            funding = maxFunding;
        }
        if(credibility > maxCredibility)
        {
            credibility = maxCredibility;
        }
        fundingGauge.text = "Funding: " + funding;
        popularityGauge.text = "Popularity: " + popularity;
        credibilityGauge.text = "Credibility: " + credibility;
    }

    public static GameStatus Instance;

    private void Awake()
    {
        if (Instance != null)
        {
           //Destroy(transform.root.gameObject);
           return;
        }
        Instance = this;
        transform.parent = null;
        DontDestroyOnLoad(transform.root.gameObject);
    }
    public void Save(int funding,int popularity, int credibility)
    {
        GameStatus.Instance.funding = funding;
        GameStatus.Instance.funding = popularity;
        GameStatus.Instance.funding = credibility;
    }
    public void Update()
    {
    
    }
}

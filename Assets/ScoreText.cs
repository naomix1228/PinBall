using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    private int score = 0;
    public GameObject scoretext;



    // Use this for initialization
    void Start() {

       

    }     
	
	

// Update is called once per frame
void Update()
    {
        this.scoretext.GetComponent<Text>().text = "score" + this.score.ToString("0000");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "SmallStarTag")
        {
            this.score += 10;
        }  
        else if (other.transform.tag == "LargeStarTag")
        {
            this.score += 20;
        }
    }
}



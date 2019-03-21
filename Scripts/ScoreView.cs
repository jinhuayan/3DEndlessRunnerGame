using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreView : MonoBehaviour
{
    private Text displayTxt;

    // Start is called before the first frame update
    void Start()
    {
        displayTxt = GetComponentInChildren<Text>(true);
    }
    private void ScoreViewUpdate()
    {
        if (displayTxt)
        {
            displayTxt.text = "Score: " + ScoreMgr.instance.score + " points";
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreViewUpdate();
    }
}

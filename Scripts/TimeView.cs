using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeView : MonoBehaviour
{
    private Text _displayTxt;
    float totalTime = 0f;
    public GameObject ResultPanel;

    public static TimeView instance;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        _displayTxt = GetComponentInChildren<Text>(true);
        _displayTxt.text = "Time : " + TimeMgr.instance.time;
        totalTime = (float)TimeMgr.instance.time;
    }

    private void TimeViewUpdate()
    {

        if (ResultPanel.activeSelf == false)
        {
            totalTime += 1 * Time.deltaTime;
            TimeMgr.instance.time = totalTime;
        }
        _displayTxt.text = "Time : " + totalTime.ToString("0.0");
    }

    // Update is called once per frame
    void Update()
    {
        TimeViewUpdate();
    }
}

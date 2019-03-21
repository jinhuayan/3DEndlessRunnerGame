using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultView : MonoBehaviour
{
    private Text _displayTime;
    // Start is called before the first frame update
    void Start()
    {
        _displayTime = GetComponentInChildren<Text>(true);
    }

    private void ResultViewUpdate()
    {
        if (_displayTime)
        {
            _displayTime.text = "Survival: " + TimeMgr.instance.time.ToString("0.0") + " seconds";
        }
    }

    // Update is called once per frame
    void Update()
    {
        ResultViewUpdate();
    }
}

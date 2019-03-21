using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    private bool _left;
    private float _moveSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        _left = true;
    }
    public void IsLeft()
    {
        if (_left)
        {
            Invoke("goLeft", 2f);
        }
        else if (!_left)
        {
            Invoke("goRight", 2f);
        }
    }

    public void goLeft()
    {
        this.transform.Translate(0.5f * _moveSpeed * Time.deltaTime * -Vector3.forward, Space.Self);
        _left = false;
    }

    public void goRight()
    {
        this.transform.Translate(0.5f * _moveSpeed * Time.deltaTime * Vector3.forward, Space.Self);
        _left = true;
    }

    // Update is called once per frame
    void Update()
    {
        IsLeft();
    }
}

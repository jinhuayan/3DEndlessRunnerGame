using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrilLogic : MonoBehaviour
{
    private Animator _animator;
    public KeyCode keyToJump;
    public KeyCode keyToSlide;
    public KeyCode keyToPunch;
    public KeyCode keyToKick;
    private float _speed;


    // Use this for initialization
    void Start()
    {
        _speed = 1.0f;
        _animator = this.gameObject.GetComponent<Animator>();
        InvokeRepeating("UpdateSpeed", 20.2f, 22.2f);
    }

    public void UpdateHeroControl()
    {
        if (_animator != null)
        {
            if (Input.GetKeyDown(keyToJump))
            {
                _animator.SetTrigger("jump");
                SoundMgr.instance.PlayJumpSfx();
            }
            else if (Input.GetKeyDown(keyToSlide))
            {
                _animator.SetTrigger("roll");
                SoundMgr.instance.PlayRollSfx();
            }
            else if (Input.GetKeyDown(keyToPunch))
            {
                _animator.SetTrigger("punch");
            }
            else if (Input.GetKeyDown(keyToKick))
            {
                _animator.SetTrigger("kick");
                SoundMgr.instance.PlayKickSfx();
                MonsterMgr.instance.kickAction = true;
                Invoke("KickAction", 1f);
            }

        }
    }

    public void KickAction()
    {
        MonsterMgr.instance.kickAction = false;
    }

    public void UpdateSpeed()
    {
        _speed += 0.2f;
        _animator.SetFloat("speed", _speed);
    }
    // Update is called once per frame
    void Update()
    {
        UpdateHeroControl();

    }
}

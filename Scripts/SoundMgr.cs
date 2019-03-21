using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : MonoBehaviour
{
    public static SoundMgr instance;
    public AudioClip jumpSfx;
    public AudioClip rollSfx;
    public AudioClip coinSfx;
    public AudioClip loseSfx;
    public AudioClip kickSfx;
    private AudioSource asource;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

        // create the audiosource if we need it
        if (asource == null)
        {
            asource = this.gameObject.AddComponent<AudioSource>();
            if (asource)
            {
                asource.playOnAwake = false;
            }
        }
    }

    public void PlayJumpSfx()
    {
        if (asource != null)
        {
            if (jumpSfx != null)
            {
                asource.PlayOneShot(jumpSfx);
            }
        }
    }

    public void PlayCoinSfx()
    {
        if (asource != null)
        {
            if (coinSfx != null)
            {
                asource.PlayOneShot(coinSfx);
            }
        }
    }

    public void PlayRollSfx()
    {
        if (asource != null)
        {
            if (rollSfx != null)
            {
                asource.PlayOneShot(rollSfx);
            }
        }
    }

    public void PlayLoseSfx()
    {
        if (asource != null)
        {
            if (loseSfx != null)
            {
                asource.PlayOneShot(loseSfx);
            }
        }
    }

    public void PlayKickSfx()
    {
        if (asource != null)
        {
            if (kickSfx != null)
            {
                asource.PlayOneShot(kickSfx);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

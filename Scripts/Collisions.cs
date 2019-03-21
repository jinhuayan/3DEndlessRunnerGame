using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour {

    public GameObject ResultPanel;
    public GameObject InGamePanel;
    public GameObject GameLevel;
    public GameObject globalObject;
    private Animator _animator;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IsABlock>() != null)
        {
            //Debug.Log("Hit!!!");
            ResultPanel.gameObject.SetActive(true);
            InGamePanel.gameObject.SetActive(false);
            GameLevel.gameObject.SetActive(false);
            SoundMgr.instance.PlayLoseSfx();
            _animator.SetBool("Idel", true);
            Destroy(globalObject);
        }

        if (collision.gameObject.GetComponent<IsaBCoin>() != null)
        {
            //Debug.Log("we hit a" + collision.gameObject.name);

            ScoreMgr.instance.score += 3;
            SoundMgr.instance.PlayCoinSfx();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.GetComponent<IsaRCoin>() != null)
        {
            //Debug.Log("we hit a" + collision.gameObject.name);

            ScoreMgr.instance.score += 5;
            SoundMgr.instance.PlayCoinSfx();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.GetComponent<IsAMonster>() != null)
        {
            Debug.Log("we hit a" + collision.gameObject.name);

            ScoreMgr.instance.score += 5;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.GetComponent<IsAMonster>() != null)
        {
            if (MonsterMgr.instance.kickAction)
            {
                Destroy(collision.gameObject);
            }
        }

    }

    // Use this for initialization
    void Start () {
        _animator = this.gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource oof;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other){
        this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Knocked Down");
        levelControl.GetComponent<LevelDistance>().enabled=false;
        oof.Play();
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}

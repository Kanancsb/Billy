using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    
    public AudioSource MonsterJumpMusic;
    public AudioSource DoorJumpMusic;
    public AudioSource DoorImpactMusic;

    void OnTriggerEnter(){

        GetComponent<BoxCollider> ().enabled = false;
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic(){

        yield return new WaitForSeconds(0.2f);
        DoorJumpMusic.Play();
        yield return new WaitForSeconds(2);
        MonsterJumpMusic.Play();
        yield return new WaitForSeconds(3);
        DoorImpactMusic.Play();
    }
}

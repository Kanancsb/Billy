using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTrigger : MonoBehaviour
{
    
    public AudioSource Runmusic;
    public GameObject Run;


    void OnTriggerEnter(){

        GetComponent<BoxCollider> ().enabled = false;
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic(){

        yield return new WaitForSeconds(0.2f);
        Run.SetActive(true);
        Runmusic.Play();
        yield return new WaitForSeconds(10);
        Run.SetActive(false);

    }
}

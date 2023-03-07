using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    
    public GameObject noteOB;
    
    public AudioSource pickup;

    void Start(){
        noteOB.SetActive(false);
    }

    public void Exit(){
        noteOB.SetActive(false);
        Cursor.visible = false;
    }

    public void Update(){
        if(noteOB.activeInHierarchy){
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}

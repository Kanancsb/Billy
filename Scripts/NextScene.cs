using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public GameObject leaveText;
    
    public bool inReach;

    void Start(){
        inReach = false;
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Reach"){
            inReach = true;
            leaveText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Reach"){
            inReach = false;
            leaveText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update(){
        if(inReach && Input.GetButtonDown("Action")){
            SceneManager.LoadScene("MainMenu");
        }
    }
}

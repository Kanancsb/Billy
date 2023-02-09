using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupF : MonoBehaviour
{

    public float TheDistance;
    public GameObject turnOn;
    public GameObject ActionDisplay;
    public GameObject FakeF;
    public GameObject RealF;

    // Update is called once per frame
    void Update(){

        TheDistance = PlayerCasting.DistanceFromTarget;

    }

    void OnMouseOver(){

        if (TheDistance <= 3){
            ActionDisplay.SetActive(true);
            ActionDisplay.SetActive (true);
        }

        if (Input.GetButtonDown("Action")){
            if (TheDistance <= 3){
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                FakeF.SetActive(false);
                RealF.SetActive(true);
                StartCoroutine (flashlightOn());

            }
        } 
    }

    void OnMouseExit(){
        ActionDisplay.SetActive(false);
        
    }

    IEnumerator flashlightOn (){
        turnOn.SetActive(true);
        yield return new WaitForSeconds (5);
        turnOn.SetActive(false);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject TheDoor;
    public AudioSource CreakSound;

    // Update is called once per frame
    void Update(){

        TheDistance = PlayerCasting.DistanceFromTarget;

    }

    void OnMouseOver(){

        if (TheDistance <= 3){
            ActionDisplay.SetActive(true);
        }

        if (Input.GetButtonDown("Action")){
            if (TheDistance <= 3){
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("DoorAnim");
                CreakSound.Play();
            }
        } 
    }

    void OnMouseExit(){

        ActionDisplay.SetActive(false);
    }
}

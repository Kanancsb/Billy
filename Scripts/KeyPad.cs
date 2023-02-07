using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{

    public string password = "1234";
    private string userInput = "";

    public AudioClip clickSound;
    public AudioClip openSound;
    public AudioClip noSound;
    AudioSource audioSource;

    private void Start(){
        
        userInput = "";
        audioSource = GetComponent<AudioSource> ();
    }
    
    public void ButtonClicked (string number){

        audioSource.PlayOneShot(clickSound);
        userInput += number;

        if(userInput.Length >= 4){
            // check password

            if(userInput == password){
                // Invoke the event to play a sound
                
                audioSource.PlayOneShot(openSound);

            }else{

                // Play a sound
                userInput = "";
                audioSource.PlayOneShot(noSound);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Keypad : MonoBehaviour
{
    

    public GameObject keypadOB;
    public Animator ANI;

    public Text textOB;
    public string answer = "12345";

    public AudioSource button;
    public AudioSource correct;
    public AudioSource wrong;
    public AudioSource WMS;

    public bool animate;

    void Start(){
        keypadOB.SetActive(false);
    }

    public void Number(int number){
        textOB.text += number.ToString();
        button.Play();
    }

    public void Execute(){
        if(textOB.text == answer){
            correct.Play();
            textOB.text = "Right";
            WMS.Play();
        }else{
            wrong.Play();
            textOB.text = "Wrong";
        }
    }

    public void Clear(){
        textOB.text = "";
        button.Play();
    }

    public void Exit(){
        keypadOB.SetActive(false);
        Cursor.visible = false;
    }

    public void Update(){
        if(textOB.text == "Right" && animate){
            ANI.SetBool("open", true);
        }

        if(keypadOB.activeInHierarchy){
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}

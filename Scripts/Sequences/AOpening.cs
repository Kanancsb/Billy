using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AOpening : MonoBehaviour
{

    public GameObject FadeScreenIn;
    public GameObject TextBox;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine (ScenePlayer());
        
    }

    IEnumerator ScenePlayer(){

        yield return new WaitForSeconds (1.5f);
        FadeScreenIn.SetActive (false);
        TextBox.GetComponent<Text> ().text = "What was this noise? Were is Daddy?";
        yield return new WaitForSeconds (2);
        TextBox.GetComponent<Text> ().text = "";
    }


}

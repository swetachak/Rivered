using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject distDisplay;
    public GameObject distEndDisplay;
    public int disRun;
    static public bool addingDis = true;
    public float disDelay = 0.35f;
    
    void Update()
    {
        if (addingDis == false){
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis(){
        disRun += 1;
        distDisplay.GetComponent<Text>().text = "" + disRun;
        distEndDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}

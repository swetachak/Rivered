using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
   public GameObject countDown3;
   public GameObject countDown2;
   public GameObject countDown1;
   public GameObject countDownGo;
   public GameObject fadeIn;
   public AudioSource GoFX;
   public AudioSource ReadyFX;
   public AudioSource BGM;
   public void Start()
   {
        StartCoroutine(CountSequence());
   }

   IEnumerator CountSequence(){
          BGM.Play();
          yield return new WaitForSeconds(1.5f);
          countDown3.SetActive(true);
          ReadyFX.Play();
          yield return new WaitForSeconds(1);
          countDown2.SetActive(true);
          ReadyFX.Play();
          yield return new WaitForSeconds(1);
          countDown1.SetActive(true);
          ReadyFX.Play();
          yield return new WaitForSeconds(1);
          countDownGo.SetActive(true);
          GoFX.Play();
          PlayerMove.canMove = true;
          LevelDistance.addingDis = false;
   }
}

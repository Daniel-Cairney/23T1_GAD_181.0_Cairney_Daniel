using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CairneyDaniel
{

   
    public class SceneLoader : MonoBehaviour
    {

        //need a feature that loads X scene when trigger is collided with
        [SerializeField] private int sceneToLoad;


        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(sceneToLoad);

                   
            }   
   
                    
        }           

    }









}
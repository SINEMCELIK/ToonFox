using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class bitis : MonoBehaviour
{

   
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Thread.Sleep(500);
            SceneManager.LoadScene(3);
           

        }

    }


}

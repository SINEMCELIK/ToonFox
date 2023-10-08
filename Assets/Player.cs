using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    int coin = 0;
    public Text coinShow;
    

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter called");
        if (collision.gameObject.CompareTag("coin"))
        {
            coin++;
            Destroy(collision.gameObject); // Düþmaný yok et
            coinShow.text = "score= " + coin;



        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("ÇArptý");
           
            Debug.Log("Level completed");
        }
    }

   
}

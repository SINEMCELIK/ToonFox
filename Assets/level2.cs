using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using TMPro;


public class level2 : MonoBehaviour
{
    private Animator animator;
    private float initialYPosition;

    public Text  durum;
    public TextMeshProUGUI zaman;

    float zamanSayaci = 120;
    bool oyunDevam = true;
    bool oyunTamam = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        initialYPosition = transform.position.y;
    }

    void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = ((int)zamanSayaci).ToString();
        }
        else if (!oyunTamam)
        {
            OyunBitir("Game Over");
        }
        if (zamanSayaci < 0)
        {
            OyunBitir("Time's up");
            SceneManager.LoadScene(6);
        }
    }


    private void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.y = initialYPosition;
        transform.position = newPosition;

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isRunning", true);
                transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                animator.SetBool("isLeftWalk", true);
                transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                animator.SetBool("isRightWalk", true);
                transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);
            }
            else
            {
                animator.SetBool("isRightWalk", false);
                animator.SetBool("isLeftWalk", false);
            }
        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalkBack", true);
            transform.Translate(new Vector3(0, 0, -2f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalkBack", false);
        }
    }
  
    void OyunBitir(string durumMetni)
    {
        oyunDevam = false;
        oyunTamam = true;
        durum.text = durumMetni;
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(6);
    }

}

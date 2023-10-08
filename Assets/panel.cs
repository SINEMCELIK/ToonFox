using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public GameObject PPanel; // Inspector �zerinden panel nesnesini s�r�kleyip b�rakaca��z.

    void Start()
    {
        PPanel.SetActive(false); // Oyun ba�lad���nda paneli kapal� yap
        Invoke("PaneliAcKapat", 1f); // 5 saniye sonra PaneliAcKapat fonksiyonunu �a��r
    }

    void PaneliAcKapat()
    {
        PPanel.SetActive(true); // Paneli a�
        Invoke("Kapat", 5f); // 5 saniye sonra Kapat fonksiyonunu �a��r
    }

    void Kapat()
    {
        PPanel.SetActive(false); // Paneli kapat
    }
}

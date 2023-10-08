using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public GameObject PPanel; // Inspector üzerinden panel nesnesini sürükleyip býrakacaðýz.

    void Start()
    {
        PPanel.SetActive(false); // Oyun baþladýðýnda paneli kapalý yap
        Invoke("PaneliAcKapat", 1f); // 5 saniye sonra PaneliAcKapat fonksiyonunu çaðýr
    }

    void PaneliAcKapat()
    {
        PPanel.SetActive(true); // Paneli aç
        Invoke("Kapat", 5f); // 5 saniye sonra Kapat fonksiyonunu çaðýr
    }

    void Kapat()
    {
        PPanel.SetActive(false); // Paneli kapat
    }
}

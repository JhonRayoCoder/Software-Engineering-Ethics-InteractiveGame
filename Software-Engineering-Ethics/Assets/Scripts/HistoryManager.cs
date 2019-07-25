using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HistoryManager : MonoBehaviour
{


    [SerializeField]
    private GameObject canvasHolder;

    [SerializeField]
    private float narratorSpeed;

    private TextMeshProUGUI text;

    private string storyChapter1 = "Tres amigos decidieron emprender y abrieron su propia empresa para desarrollar software a sus clientes. No paso mucho tiempo cuando les llego el primero.\n " +
        "El cliente queria una aplicacion para vender bienes de procedencia sospechosa.";

    private int index = 0;

    private IEnumerator coroutine;

    private bool started = false;
    
    void Start()
    {
        text = canvasHolder.GetComponent<TextMeshProUGUI>();
        text.text = string.Empty;
    }

    void Update()
    {
        if (!started)
        {
            coroutine = startTellingStory(narratorSpeed);
            StartCoroutine(coroutine);
        }
    }

    private IEnumerator startTellingStory(float wait)
    {
        started = true;
        while (index < storyChapter1.Length)
        {
            text.text += storyChapter1[index];
            yield return new WaitForSeconds(wait);
            ++index;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HistoryManager : MonoBehaviour
{


    [SerializeField]
    private GameObject canvasHolder;

    [SerializeField]
    private float narratorSpeed;

    [SerializeField]
    private GameObject leftPanel;

    [SerializeField]
    private GameObject rightPanel;

    private TextMeshProUGUI text;

    private Image left;

    private Image right;

    private string storyChapter1 = "Tres amigos decidieron emprender y abrieron su propia empresa para desarrollar software.Estaban teniendo problemas para conseguir clientes, por lo que la " +
        "empresa estaba cerca de la quiebra.\nSin embargo, un dia aparecio alguien que queria una aplicacion para vender bienes de procedencia sospechosa.";

    private int index = 0;

    private IEnumerator coroutine;

    private bool started = false;

    private bool make_decision = false;

    private bool calledBefore = false;

    private bool onLeft;
    
    void Start()
    {
        text = canvasHolder.GetComponent<TextMeshProUGUI>();
        text.text = string.Empty;
        left = leftPanel.GetComponent<Image>();
        right = rightPanel.GetComponent<Image>();
        leftPanel.SetActive(false);
        rightPanel.SetActive(false);
    }

    void Update()
    {
        if (!started)
        {
            coroutine = startTellingStory(narratorSpeed);
            StartCoroutine(coroutine);
        }

        if (make_decision)
        {
            if (!calledBefore)
            {
                showDecisions();
                calledBefore = true;
            }
            if (Input.mousePosition.x < Screen.width / 2)
            {
                changeOpacity(.5f, 0f);
                onLeft = true;
            } else
            {
                changeOpacity(0f, .5f);
                onLeft = false;
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (onLeft)
                {
                    Debug.Log("Left");
                }
                else
                {
                    Debug.Log("right");
                }
            }



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
        make_decision = true;
    }

    private void showDecisions()
    {
        leftPanel.SetActive(true);
        rightPanel.SetActive(true);
    }

    private void changeOpacity(float a, float b)
    {
        Color c = left.color;
        c.a = a;
        left.color = c;

        c = right.color;
        c.a = b;
        right.color = c;
    }
}

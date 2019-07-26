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

    [SerializeField]
    private bool leftDecisionIsCorrect;

    private GameObject obj;

    private Manager manager;

    private TextMeshProUGUI text;

    private Image left;

    private Image right;

    private int index = 0;

    private string story;

    private IEnumerator coroutine;

    private bool started = false;

    private bool make_decision = false;

    private bool calledBefore = false;

    private bool onLeft;
    
    void Start()
    {
        obj = GameObject.Find("Manager");
        text = canvasHolder.GetComponent<TextMeshProUGUI>();
        text.text = string.Empty;
        left = leftPanel.GetComponent<Image>();
        right = rightPanel.GetComponent<Image>();
        manager = obj.GetComponent<Manager>();
        leftPanel.SetActive(false);
        rightPanel.SetActive(false);
        story = manager.getStory();
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
                    manager.makeDecision(leftDecisionIsCorrect);
                }
                else
                {
                    manager.makeDecision(!leftDecisionIsCorrect);
                }
            }



        }
    }

    private IEnumerator startTellingStory(float wait)
    {
        started = true;
        while (index < story.Length)
        {
            text.text += story[index];
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

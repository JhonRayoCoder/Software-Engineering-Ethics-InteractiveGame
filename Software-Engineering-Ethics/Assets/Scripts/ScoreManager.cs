using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private Manager manager;

    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        scoreText.text = manager.getScore().ToString() + "/" + manager.getCounter().ToString();
    }
}

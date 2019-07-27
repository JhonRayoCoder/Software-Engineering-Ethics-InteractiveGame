using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    private int chapter = 1;
    private int score = 0;

    private string[] story = {
        "Tu y dos socios deciden emprender y abren una consultora de software. Conseguir clientes esta complicado, pero un dia por fin aparece alguien quien necesita una " +
            "aplicacion para vender items de procedencia sospechosa.",
        "En el afan de conseguir capital, un socio te propone copiar el software de la competencia, y te pide que lo ayudes con eso.",
        "FIN",
        "El software alterno que decidiste escribir excedia las capacidades de tu equipo, por lo que tomo bastante tiempo terminar y entregar el proyecto. El cliente no estaba " +
            "muy feliz pero el programa parecia funcionar. Sin embargo, pasadas unas semanas, presento un fallo.",
        "",
        "",
        "",
        "El cliente queda satisfecho y se expande el exito de la empresa. Un dia, otro cliente busca un programa para optimizar operaciones en su empresa. Sin embargo, cuando lees los " +
            "requerimientos te das cuenta que el proposito es evadir impuestos.",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "Dadas las buenas decisiones que has tomado a pesar de las adversidades, tu empresa es todo un exito. Los clientes no dejan de llegar. No obstante, un escandalo impacta al pais." +
            "Se expande el rumor de discriminacion en ciertas contrataciones. Tu empresa esta en el hojo del huracan dada la falta de mujeres en la empresa"};

    public void Start()
    {
        DontDestroyOnLoad(this);
    }
    public void makeDecision(bool correct)
    {
        if (correct)
        {
            ++score;
            chapter = chapter * 2;
        } else
        {
            chapter = (chapter * 2) + 1;
        }

        SceneManager.LoadScene(chapter.ToString());
    }

    public int getScore()
    {
        return score;
    }

    public string getStory()
    {
        return story[chapter - 1];
    }
}

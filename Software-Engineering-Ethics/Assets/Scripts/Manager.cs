using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    private int chapter = 1;
    private int counter = 1;
    private int score = 0;

    private string[] story = {
        "Tu y un socio deciden emprender y abren una consultora de software. Conseguir clientes esta complicado, pero un dia por fin aparece alguien quien necesita una " +
            "aplicacion para vender bienes de procedencia sospechosa.",
        "En el afan de conseguir capital, tu socio te propone copiar el software de la competencia, y te pide que lo ayudes con eso.",
        "Después de algunos meses de incertidumbre llega otro cliente el cual pide desarrollar un aplicativo utilizando herramientas en las que ninguno de los empleados de la compañía tiene conocimiento.",
        "El software alterno que decidiste escribir excedia las capacidades de tu equipo, por lo que tomo bastante tiempo terminar y entregar el proyecto. El cliente no estaba " +
            "muy feliz, pero el programa parecia funcionar. Sin embargo, pasadas unas semanas, presento un fallo.",
        "Las autoridades han notado tu intento de plagio al robar el aplicativo, al empezar el proceso judicial se piden los archivos de desarrollo del proyecto, sin embargo un compañero de trabajo se anticipó a la situación y decidió eliminar tales archivos, tú sabes quién lo hizo.",
        "El cliente ha decidido contratarlos a pesar de no tener el conocimiento, les pide obtenerlo y les da tiempo extra con el fin de tener su aplicativo; sin embargo al terminar el proyecto se dan cuenta que uno de los requerimientos del aplicativo no se cumple.",
        "Ha llegado un nuevo cliente, el quiere un aplicativo simple que sin embargo de manera indirecta promueve la contaminación del medio ambiente.",
        "El cliente queda satisfecho y se expande el exito de la empresa. Un dia, otro cliente busca un progrviama para optimizar operaciones en su empresa. Sin embargo, cuando lees los " +
            "requerimientos te das cuenta que el proposito es evadir impuestos.",
        "Esta decision ha hecho que tu empresa se encuentre en un grave aprieto legal y son acusados de evasion de impuestos por lo cual proceden a pagar la demanda y la empresa cae en quiebra ",
        "",
        "",
        "",
        "",
        "",
        "",
        "Dadas las buenas decisiones que has tomado a pesar de las adversidades, tu empresa es todo un exito. Los clientes no dejan de llegar. No obstante, un escandalo impacta al pais." +
            "Se expande el rumor de discriminacion en ciertas contrataciones. Tu empresa esta en el ojo del huracan dada la falta de mujeres en la empresa",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "La empresa ha logrado superar todas las dificultades con las que se ha enfrentado. Has sido un muy buen lider. Un dia, te das cuenta que uno de tus mejores empleados ha estado saboteando" +
            " el trabajo de un recien ingresado.",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "Han pasado los años y ya estas cerca de retirarte. Un dia tu esposa te reclama sobre una trabajadora de la empresa, pues parece ser que te esta cayendo, sin embargo, tu sabes que eso no es asi.",
        };

    private int[] finalChapterArray = { 128, 129, 9, 10, 11, 12, 13, 14, 15, 17, 33, 65 };

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

        if (final(chapter))
        {
            SceneManager.LoadScene("GameOver");
            return;
        }
        ++counter;
        SceneManager.LoadScene(chapter.ToString());
    }

    private bool final(int c)
    {
        foreach (int i in finalChapterArray)
        {
            if (i == c)
                return true;
        }
        return false;
    }

    public int getScore()
    {
        return score;
    }

    public int getCounter()
    {
        return counter;
    }

    public string getStory()
    {
        return story[chapter - 1];
    }
}

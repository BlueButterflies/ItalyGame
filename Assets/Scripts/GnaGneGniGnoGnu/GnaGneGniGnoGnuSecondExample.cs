using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GnaGneGniGnoGnuSecondExample : MonoBehaviour
{
    #region Variables
    public AudioClip[] audioClips;
    private AudioSource audioSource;

    public Text text;
    public InputField inputTxt;

    private string input;

    private bool isCorrect;

    private string[] texts = {"Ogni melo ha la sua mela,\r\nogni ragno la sua tela.\r\nOgni pino ha la sua pigna,\r\nogni colle ha la sua vigna." +
                              "\r\nOgni cigno ha uno stagno,\r\nogni pugno il suo compagno.\r\nOgni riccio ha tre castagne e le \r\nscuole le lavagne.",
                              "Gnu Gnu era una piccolo ragno.\r\n" +
                              "Viveva sopra una ragnatela \r\n" +
                              "disegnata su una vecchia lavagna.\r\n" +
                              "A Gnu Gnu piaceva sognare...\r\n" +
                              "Sognava di vivere in campagna,\r\n" +
                              "di tessere una vera ragnatela \r\n" +
                              "su un albero di prugne, \r\n" +
                              "di avere come compagni \r\n" +
                              "un cigno e uno gnomo.",
                              "Vedo un ragno nel suo regno\r\n" +
                              "che lavora con impegno,\r\n" +
                              "un agnello sulla montagna\r\n" +
                              "e uno gnomo che fa il bagno\r\n" +
                              "con un cigno nello stagno.",
                              "Ignazio il cuoco sbadato \r\n" +
                              "ha messo una lasagna dentro il gelato. \r\n" +
                              "Al posto del bignè alla crema \r\nha preparato un dolce alls'amarena.\r\n" +
                              "Invece degli gnocchi ha servito i finocchi.\r\n " +
                              "E ha preso a pugni l'impasto \r\nquando si è accorto del disastro.",
                              "La scuola dei ragni è in \r\n" +
                              "un vecchio castagno.\r\nLo gnomo bidello fa spesso l'appello:\r\n-Agnese?Presente!" +
                              " \r\nIgnazio?Non c'è!\r\nSu, ragni e ragnette in fila per tre.\r\nArriva il maestro, un gnomo d'ingegno \r\n" +
                              "che a insegnar ragnatele \r\nsi mette d'impegno.\r\nCosi gnomi e gnome,\r\n ragni e ragnette \r\nfan ragnatele davvero perfette."};
    #endregion

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomText();
    }

    #region Random Text
    private void RandomText()
    {
        int num = Random.Range(0, texts.Length);
        text.text = texts[num];
        inputTxt.text = "";
    }
    #endregion

    #region Check correct input
    public void CheckInput()
    {
        if (isCorrect)
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomText();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
            inputTxt.text = "";
        }
    }
    #endregion

    #region Read Input Field
    public void ReadInput(string s)
    {
        input = s;

        if (input.Contains("MUGNAIO") || input.Contains("mugnaio") && input.Contains("gnomo") || input.Contains("GNOMO") && input.Contains("MONTAGNA")  || input.Contains("montagna")
            && input.Contains("MAGNIFICO") || input.Contains("magnifico") && input.Contains("FALEGNAME") || input.Contains("falegname") && input.Contains("LASAGNE") || input.Contains("lasagne")
            && input.Contains("BAGNINO") || input.Contains("bagnino") && input.Contains("BAGNO") || input.Contains("bagno") && input.Contains("PIAGNUCOLA") || input.Contains("piagnucola"))
        {
            isCorrect = true;
        }
        else if (input.Contains("OGNI") || input.Contains("ogni") && input.Contains("RAGNO") || input.Contains("ragno") && input.Contains("PIGNA") || input.Contains("pigna")
            && input.Contains("VIGNA") || input.Contains("vigna") && input.Contains("CIGNO") || input.Contains("cigno") && input.Contains("STAGNO") || input.Contains("stagno")
            && input.Contains("PUGNO") || input.Contains("pugno") && input.Contains("COMPAGNO") || input.Contains("compagno") && input.Contains("CASTAGNE") || input.Contains("castagne")
            && input.Contains("LAVAGNE") || input.Contains("lavagne"))
        {
            isCorrect = true;
        }
        else if (input.Contains("GNU") || input.Contains("gnu") && input.Contains("RAGNO") || input.Contains("ragno") && input.Contains("RAGNATELA") || input.Contains("ragnatela") && input.Contains("DISEGNATA") || input.Contains("disegnata")
            && input.Contains("LAVAGNA") || input.Contains("lavagna") && input.Contains("SOGNARE") || input.Contains("sognare") && input.Contains("SOGNAVA") || input.Contains("sognava") && input.Contains("CAMPAGNA") || input.Contains("campagna")
            && input.Contains("PRUGNE") || input.Contains("prugne") && input.Contains("COMPAGNI") || input.Contains("compagni") && input.Contains("CIGNO") || input.Contains("cigno") && input.Contains("GNOMO") || input.Contains("gnomo"))
        {
            isCorrect = true;
        }
        else if (input.Contains("RAGNO") || input.Contains("ragno") && input.Contains("BAGNO") || input.Contains("bagno")
                 && input.Contains("CIGNO") || input.Contains("cigno") && input.Contains("STAGNO") || input.Contains("stagno")
                 && input.Contains("gnomo") || input.Contains("GNOMO") && input.Contains("MONTAGNA") || input.Contains("montagna")
                 && input.Contains("regno") || input.Contains("REGNO") && input.Contains("IMPEGNO") || input.Contains("impegno")
                 && input.Contains("agnello") || input.Contains("AGNELLO"))
        {
            isCorrect = true;
        }
        else if (input.Contains("IGNAZIO") || input.Contains("ignazio") || input.Contains("Ignazio") 
                && input.Contains("LASAGNA") || input.Contains("lasagna") && input.Contains("bignè".ToUpper()) || input.Contains("bignè")
                && input.Contains("GNOCCI") || input.Contains("gnocchi") && input.Contains("PUGNI") || input.Contains("pugni"))
        {
            isCorrect = true;
        }
        else if (input.Contains("IGNAZIO") || input.Contains("ignazio") || input.Contains("Ignazio") && input.Contains("AGNESE") || input.Contains("agnese") || input.Contains("Agnese")
                && input.Contains("RAGNI") || input.Contains("ragni") && input.Contains("CASTAGNO") || input.Contains("castagno")
                && input.Contains("GNOMO") || input.Contains("gnomo") && input.Contains("RAGNETTE") || input.Contains("ragnette")
                && input.Contains("INGEGNO") || input.Contains("igegno") && input.Contains("INSEGNAR") || input.Contains("insegnar")
                && input.Contains("RAGNATELE") || input.Contains("ragnatele") && input.Contains("GNOMI") || input.Contains("gnomi")
                && input.Contains("GNOME") || input.Contains("gnome"))
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }


    }
    #endregion

    #region Buttons Return, Exit and Next
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(13);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoppieOSingoleThirdExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text phraseTxt;
    public Text firstWord;
    public Text secondWord;

    public InputField inputCorrectPhrase;
    private string input;

    private string[] phrases = { "Nella casa al mare ho una cassa piena di palette e secchielli.",
                                 "Bob è il mio cane; gli piace correre tra le canne vicino al laghetto.",
                                 "Laura ha i capelli lunghi e biondi; in estate indossa cappelli di paglia.",
                                 "Mentre Marco giocava a palla è caduto in una buca fatta con una pala.",
                                 "Oggi ho segnato sette goal. Alla fine della partita avevo tanta sete.",
                                 "Ho regalato alla mamma una rosa; l'ho scelta rossa perchè è il suo colore preferito.",
                                 "Ho visitato un paese antico e ho visto tante torri. Si dice che i tori deventono furiosi quando vedono il colore rosso.",
                                 "Di notte brillano le stelle. Il musicista scrive le note sul pentagramma.",
                                 "Sono andata a vedere i carri di Carnevale insieme ai più cari amici.",
                                 "Leggo attentamente le istruzioni quando devo costruire qualcosa con il lego."};
    private string phrase;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomNumbsAndAssingTxtWordsPhrase();
    }

    #region Random numbs and assing text words and phrase
    public void RandomNumbsAndAssingTxtWordsPhrase()
    {
        phrase = phrases[Random.Range(0, phrases.Length)];

        if (phrase == phrases[0])
        {
            phraseTxt.text = "Nella ___ al mare ho una ___ piena di palette e secchielli.";
            firstWord.text = "CASA";
            secondWord.text = "CASSA";
        }
        else if (phrase == phrases[1])
        {
            phraseTxt.text = "Bob è il mio ___; \t\ngli piace correre tra le ___ vicino al laghetto.";
            firstWord.text = "CANNE";
            secondWord.text = "CANE";
        }
        else if (phrase == phrases[2])
        {
            phraseTxt.text = "Laura ha i ___ lunghi e biondi; \t\nin estate indossa ___ di paglia.";
            firstWord.text = "CAPELLI";
            secondWord.text = "CAPPELLI";
        }
        else if (phrase == phrases[3])
        {
            phraseTxt.text = "Mentre Marco giocava a ___ è caduto in una buca fatta con una ___.";
            firstWord.text = "PALLA";
            secondWord.text = "PALA";
        }
        else if (phrase == phrases[4])
        {
            phraseTxt.text = "Oggi ho segnato ___ goal. \t\nAlla fine della partita avevo tanta ___.";
            firstWord.text = "SETE";
            secondWord.text = "SETTE";
        }
        else if (phrase == phrases[5])
        {
            phraseTxt.text = "Ho regalato alla mamma una ___; \t\nl'ho scelta ___ perchè è il suo colore preferito.";
            firstWord.text = "ROSSA";
            secondWord.text = "ROSA";
        }
        else if (phrase == phrases[6])
        {
            phraseTxt.text = "Ho visitato un paese antico e ho visto tante ___. \t\nSi dice che i ___ deventono furiosi quando vedono il colore rosso.";
            firstWord.text = "TORI";
            secondWord.text = "TORRI";
        }
        else if (phrase == phrases[7])
        {
            phraseTxt.text = "Di ___ brillano le stelle. \t\nIl musicista scrive le ___ sul pentagramma.";
            firstWord.text = "NOTTE";
            secondWord.text = "NOTE";
        }
        else if (phrase == phrases[8])
        {
            phraseTxt.text = "Sono andata a vedere i ___ di Carnevale insieme ai più ___ amici.";
            firstWord.text = "CARI";
            secondWord.text = "CARRI";
        }
        else if (phrase == phrases[9])
        {
            phraseTxt.text = "___ attentamente le istruzioni quando devo costruire qualcosa con il ___.";
            firstWord.text = "LEGGO";
            secondWord.text = "LEGO";
        }
    }
    #endregion

    #region Read and check correct phrase
    public void ReadInput(string s)
    {
        input = s;
    }

    public void CheckPhraseCorrect()
    {
        if (input.Contains(phrase) || input.Contains(phrase.ToLower()) || input.Contains(phrase.ToUpper()))
        {
            audioSource.PlayOneShot(audioClips[0]);

            inputCorrectPhrase.text = "";

            RandomNumbsAndAssingTxtWordsPhrase();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);

            inputCorrectPhrase.text = "";
        }
    }
    #endregion
    #region Buttons Return, Next and Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}

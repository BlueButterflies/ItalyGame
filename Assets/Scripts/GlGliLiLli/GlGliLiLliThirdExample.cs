using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlGliLiLliThirdExample : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text phrase;
    public InputField inputField;

    private string input;

    private string word;
    private string[] words = { "italiano", "pagliaccio", "conchiglia", "foglie", "sveglia", "maglione", 
                               "inglese", "coniglietto", "ventaglio", "biliardo", "allievo", "maniglia", 
                               "glassa", "gladiatore", " ciliegie","gioielliere" };
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingPhrase();
    }

    #region Random words from array string and assing phrase 
    private void RandomWordsAndAssingPhrase()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            phrase.text = "La maestra Gaia insiegna ita__no.";
        }
        else if(word == words[1])
        {
            phrase.text = "Il pa___accio nella festa di compleanno era divertente.";
        }
        else if (word == words[2])
        {
            phrase.text = "Maria e Giovanni hanno trovato una conchi___a in spiaggia.";
        }
        else if (word == words[3])
        {
            phrase.text = "In autuno le fo___e si colorono in diversi colori.";
        }
        else if (word == words[4])
        {
            phrase.text = "Ogni mattina la sveglia suona.";
        }
        else if (word == words[5])
        {
            phrase.text = "Quando ho fredo mi metto il ma___one.";
        }
        else if (word == words[6])
        {
            phrase.text = "In Inglitera parlano in__ese.";
        }
        else if (word == words[7])
        {
            phrase.text = "Ieri con i miei amici nel parco abbiamo visto un coni___etto.";
        }
        else if (word == words[8])
        {
            phrase.text = "Nel estate mia nonna usa il venta___o.";
        }
        else if (word == words[9])
        {
            phrase.text = "Tommaso è andato giocare bi__ardo con Antonio.";
        }
        else if (word == words[10])
        {
            phrase.text = "La maestra Assunta riformulò la domanda di Storia all'a___evo.";
        }
        else if (word == words[11])
        {
            phrase.text = "La mani___a della porta è rotta.";
        }
        else if (word == words[12])
        {
            phrase.text = "La __assa della torta è gialla.";
        }
        else if (word == words[13])
        {
            phrase.text = "Era il piu famoso __adiatore di Roma.";
        }
        else if (word == words[14])
        {
            phrase.text = "Le ci__egie che ha raccolto Emma erano deliziose.";
        }
        else if (word == words[15])
        {
            phrase.text = "Il gioie___ere mise in vetrina un bellissimo anello.";
        }
    }
    #endregion

    #region ReadInput and Check answer input
    public void ReadInput(string s)
    {
        input = s;
    }

    public void CheckAnswer()
    {
        if (input.Contains(word))
        {
            audioSource.PlayOneShot(audioClips[0]);
            
            RandomWordsAndAssingPhrase();

            inputField.text = "";
        }
        else 
        {
            audioSource.PlayOneShot(audioClips[1]);

            inputField.text = "";
        }
    }
    #endregion

    #region Buttons Retur and Exit
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

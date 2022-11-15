using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GnaGneGniGnoGnuFirstExample : MonoBehaviour
{
    #region Variables
    public AudioClip[] audioClips;
    private AudioSource audioSource;

    public Text text;
    public Text firstTxt;
    public Text secondTxt;
    public Text thirdTxt;
    public Text fourthTxt;
    public Text fifthTxt;

    private string[] words = { "GNOMO", "SPUGNA", "CIGNO", "GNIOCCHI", "BIGNE", "PUGNO", "RAGNO", "AGNELLO", "BAGNO", "VIGNA",//0-9
                               "PRUGNA","MONTAGNA","LEGNO","LASAGNA","PUGNALE","MUGNAIO","PIGNA","PAGNOTTA","PIAGNUCOLONE","OGNUNO"};//10-19
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingText();
    }

    #region Random words and assing text
    private void RandomWordsAndAssingText()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            text.text = "___MO";
        }
        else if (word == words[1])
        {
            text.text = "SPU___";
        }
        else if (word == words[2])
        {
            text.text = "CI___";
        }
        else if (word == words[3])
        {
            text.text = "___OCCHI";
        }
        else if (word == words[4])
        {
            text.text = "BI___";
        }
        else if (word == words[5])
        {
            text.text = "PU___";
        }
        else if (word == words[6])
        {
            text.text = "RA___";
        }
        else if (word == words[7])
        {
            text.text = "A___LLO";
        }
        else if (word == words[8])
        {
            text.text = "BA___";
        }
        else if (word == words[9])
        {
            text.text = "VI___";
        }
        else if (word == words[10])
        {
            text.text = "PRU___";
        }
        else if (word == words[11])
        {
            text.text = "MONTA___";
        }
        else if (word == words[12])
        {
            text.text = "LE___";
        }
        else if (word == words[13])
        {
            text.text = "LASA___";
        }
        else if (word == words[14])
        {
            text.text = "PU___LE";
        }
        else if (word == words[15])
        {
            text.text = "MU___IO";
        }
        else if (word == words[16])
        {
            text.text = "PI___";
        }
        else if (word == words[17])
        {
            text.text = "PA___TTA";
        }
        else if (word == words[18])
        {
            text.text = "PIA___COLONE";
        }
        else if (word == words[19])
        {
            text.text = "O___NO";
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == words[1] || word == words[9] || word == words[10] || word == words[11]
             || word == words[13] || word == words[14] || word == words[15] || word == words[16])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingText();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == words[4] || word == words[7])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingText();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (word == words[3])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingText();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FourthBtn()
    {
        if (word == words[0] || word == words[2] || word == words[5] || word == words[6] || word == words[8]
                       || word == words[12] || word == words[17])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingText();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FifthBtn()
    {
        if (word == words[18] || word == words[19])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingText();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }
    #endregion

    #region Buttons Return,Exit,Next
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(12);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}

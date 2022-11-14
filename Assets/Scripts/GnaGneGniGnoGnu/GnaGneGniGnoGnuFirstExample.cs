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

    private string[] words = { "GNOMO", "SPUGNA", "CIGNO", "GNIOCCHI", "BIGNE", "PUGNO", "RAGNO", "AGNELLO", "BAGNO", "VIGNA",
                               "PRUGNA","MONTAGNA","LEGNO","LASAGNA","PUGNALE","MUGNAIO","PIGNA","PAGNOTTA","PIAGNUCOLONE","OGNUNO"};
    private string word;

    private bool firstBool;
    private bool secondBool;
    private bool thirdBool;
    private bool fourthBool;
    private bool fifthBool;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        #region Check words
        if (word == "GNOMO")
        {
            text.text = "___MO";
        }
        else if (word == "SPUGNA")
        {
            text.text = "SPU___";
        }
        else if (word == "CIGNO")
        {
            text.text = "CI___";
        }
        else if (word == "GNIOCCHI")
        {
            text.text = "___OCCHI";
        }
        else if (word == "BIGNE")
        {
            text.text = "BI___";
        }
        else if (word == "PUGNO")
        {
            text.text = "PU___";
        }
        else if (word == "RAGNO")
        {
            text.text = "RA___";
        }
        else if (word == "AGNELLO")
        {
            text.text = "A___LLO";
        }
        else if (word == "BAGNO")
        {
            text.text = "BA___";
        }
        else if (word == "VIGNA")
        {
            text.text = "VI___";
        }
        else if (word == "PRUGNA")
        {
            text.text = "PRU___";
        }
        else if (word == "MONTAGNA")
        {
            text.text = "MONTA___";
        }
        else if (word == "LEGNO")
        {
            text.text = "LE___";
        }
        else if (word == "LASAGNA")
        {
            text.text = "LASA___";
        }
        else if (word == "PUGNALE")
        {
            text.text = "PU___LE";
        }
        else if (word == "MUGNAIO")
        {
            text.text = "MU___IO";
        }
        else if (word == "PIGNA")
        {
            text.text = "PI___";
        }
        else if (word == "PAGNOTTA")
        {
            text.text = "PA___TTA";
        }
        else if (word == "PIAGNUCOLONE")
        {
            text.text = "PIA___COLONE";
        }
        else if (word == "OGNUNO")
        {
            text.text = "O___NO";
        }
        #endregion

        #region Check bool
        if (word == "SPUGNA" || word == "VIGNA" || word == "PRUGNA" || word == "MONTAGNA"
             || word == "LASAGNA" || word == "PUGNALE" || word == "MUGNAIO" || word == "PIGNA")
        {
            firstBool = true;
            secondBool = false;
            thirdBool = false;
            fourthBool = false;
            fifthBool = false;
        }
        else if (word == "BIGNE" || word == "AGNELLO")
        {
            firstBool = false;
            secondBool = true;
            thirdBool = false;
            fourthBool = false;
            fifthBool = false;
        }
        else if (word == "GNIOCCHI")
        {
            firstBool = false;
            secondBool = false;
            thirdBool = true;
            fourthBool = false;
            fifthBool = false;
        }
        else if (word == "GNOMO" || word == "CIGNO" || word == "PUGNO" || word == "RAGNO" || word == "BAGNO"
                       || word == "LEGNO" || word == "PAGNOTTA")
        {
            firstBool = false;
            secondBool = false;
            thirdBool = false;
            fourthBool = true;
            fifthBool = false;
        }
        else if (word == "OGNUNO" || word == "PIAGNUCOLONE")
        {
            firstBool = false;
            secondBool = false;
            thirdBool = false;
            fourthBool = false;
            fifthBool = true;
        }
        #endregion
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (firstBool)
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (secondBool)
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (thirdBool)
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FourthBtn()
    {
        if (fourthBool)
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FifthBtn()
    {
        if (fifthBool)
        {
            audioSource.PlayOneShot(audioClips[0]);
            Controller();
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
        SceneManager.LoadScene(11);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}

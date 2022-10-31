using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissingVowelsThirdExample : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite goose;
    public Sprite island;
    public Sprite umbrella;
    public Sprite boll;
    public Sprite flowers;
    public Sprite cat;
    public Sprite wing;
    public Sprite funnel;
    public Sprite bee;
    public Sprite candles;
    public Sprite bird;
    public Sprite strawberry;
    public Sprite fungus;
    public Sprite donkey;
    public Sprite igloo;
    public Sprite elf;
    public Sprite hippopotamus;
    public Sprite rainbow;
    public Sprite duck;
    public Sprite clock;
    public Sprite grape;
    public Sprite one;


    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "ALA","OMBRELLO", "FIORI", "GATTO", "UVA", "UNO", "PALLA", "CANDELE", "FUNGHI", "IMBUTO", "ISOLA",
                               "FRAGOLE","APE", "ELFO", "ASINO", "ANATRA", "IPPOPOTAMO", "ARCOBALENO", "OROLOGIO","iglù".ToUpper() };
    private string word;

    private bool firstBtn;
    private bool secondBtn;
    private bool thirdBtn;
    private bool fourthBtn;
    private bool fifthBtn;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        Debug.Log(word);

        #region Check words
        if (word == "ALA")
        {
            text.text = "_LA";
            images.sprite = wing;
        }
        else if (word == "OMBRELLO")
        {
            text.text = "_MBRELLO";
            images.sprite = umbrella;
        }
        else if (word == "FIORI")
        {
            text.text = "FIOR_";
            images.sprite = flowers;
        }
        else if (word == "GATTO")
        {
            text.text = "GATT_";
            images.sprite = cat;
        }
        else if (word == "PALLA")
        {
            text.text = "PALL_";
            images.sprite = boll;
        }
        else if (word == "CANDELE")
        {
            text.text = "CANNDEL_";
            images.sprite = candles;
        }
        else if (word == "FUNGHI")
        {
            text.text = "FUNGH_";
            images.sprite = fungus;
        }
        else if (word == "IMBUTO")
        {
            text.text = "_MBUTO";
            images.sprite = funnel;
        }
        else if (word == "ISOLA")
        {
            text.text = "_SOLA";
            images.sprite = island;
        }
        else if (word == "FRAGOLE")
        {
            text.text = "FRAGOL_";
            images.sprite = strawberry;
        }
        else if (word == "APE")
        {
            text.text = "_PE";
            images.sprite = bee;
        }
        else if (word == "ELFO")
        {
            text.text = "_LFO";
            images.sprite = elf;
        }
        else if (word == "ASINO")
        {
            text.text = "_SINO";
            images.sprite = donkey;
        }
        else if (word == "ANATRA")
        {
            text.text = "_NATRA";
            images.sprite = duck;
        }
        else if (word == "IPPOPOTAMO")
        {
            text.text = "_PPOPOTAMO";
            images.sprite = hippopotamus;
        }
        else if (word == "ARCOBALENO")
        {
            text.text = "_RCOBALENO";
            images.sprite = rainbow;
        }
        else if (word == "OROLOGGIO")
        {
            text.text = "_ROLOGGIO";
            images.sprite = clock;
        }
        else if (word == "iglù".ToUpper())
        {
            text.text = "_glù".ToUpper();
            images.sprite = igloo;
        }
        else if (word == "UNO")
        {
            text.text = "_NO";
            images.sprite = one;
        }
        else if (word == "UVA")
        {
            text.text = "_VA";
            images.sprite = grape;
        }
        #endregion

        #region Check bool
        if (word == "ALA" || word == "PALLA" || word == "APE" || word == "ANATRA" ||
            word == "ARCOBALENO" || word == "ASINO")
        {
            firstBtn = true;

            secondBtn =  false;
            thirdBtn = false;
            fourthBtn = false;
            fifthBtn = false;
        }
        else if (word == "ELFO" || word == "FRAGOLE" || word == "CANDELE")
        {
            secondBtn = true;

            firstBtn = false;
            thirdBtn = false;
            fourthBtn = false;
            fifthBtn = false;
        }
        else if (word == "ISOLA" || word == "IMBUTO" || word == "IPPOPOTAMO" || word == "FUNGHI" || word == "FIORI" || word == "iglù".ToUpper())
        {
            thirdBtn = true;

            secondBtn = false;
            firstBtn = false;
            fourthBtn = false;
            fifthBtn = false;
        }
        else if (word == "GATTO" || word == "OMBRELLO" || word == "OROLOGGIO")
        {
            fourthBtn = true;

            secondBtn = false;
            firstBtn = false;
            thirdBtn = false;
            fifthBtn = false;
        }
        else if (word == "UNO" || word == "UVA")
        {
            fifthBtn = true;

            secondBtn = false;
            firstBtn = false;
            fourthBtn = false;
            thirdBtn = false;
        }
        #endregion
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (firstBtn)
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
        if (secondBtn)
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
        if (thirdBtn)
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
        if (fourthBtn)
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
        if (fifthBtn)
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

    #region Buttons Return, Exit
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

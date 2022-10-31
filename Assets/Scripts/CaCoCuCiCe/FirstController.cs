using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstController : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite house;
    public Sprite horse;
    public Sprite candles;
    public Sprite goose;
    public Sprite seaCalf;
    public Sprite hat;
    public Sprite chameleon;
    public Sprite bend;
    public Sprite socks;
    public Sprite tableSpoon;
    public Sprite rope;
    public Sprite column;
    public Sprite necklace;
    public Sprite cube;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CASA", "CAVALLO", "CANDELE", "OCA", "FOCA", "CAPPELLO", "CAMALEONTE", "CALZE",
                               "CORDA", "COLLANA", "COLONNA", "CURVA", "CUCCHIAIO", "CUBO"};
    private string word;

    private bool CA;
    private bool CO;
    private bool CU;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        #region Check word
        if (word == "CASA")
        {
            text.text = "__SA";
            images.sprite = house;
        }
        else if (word == "CAVALLO")
        {
            text.text = "__VALLO";
            images.sprite = horse;
        }
        else if (word == "CANDELE")
        {
            text.text = "__NDELE";
            images.sprite = candles;
        }
        else if (word == "OCA")
        {
            text.text = "O__";
            images.sprite = goose;
        }
        else if (word == "FOCA")
        {
            text.text = "FO__";
            images.sprite = seaCalf;
        }
        else if (word == "CAPPELLO")
        {
            text.text = "__PPELLO";
            images.sprite = hat;
        }
        else if (word == "CAMALEONTE")
        {
            text.text = "__MALEONTE";
            images.sprite = chameleon;
        }
        else if (word == "CALZE")
        {
            text.text = "__LZE";
            images.sprite = socks;
        }
        else if (word == "CORDA")
        {
            text.text = "__RDA";
            images.sprite = rope;
        }
        else if (word == "COLLANA")
        {
            text.text = "__LLANA";
            images.sprite = necklace;
        }
        else if (word == "COLONNA")
        {
            text.text = "__LONNA";
            images.sprite = column;
        }
        else if (word == "CURVA")
        {
            text.text = "__RVA";
            images.sprite = bend;
        }
        else if (word == "CUCCHIAIO")
        {
            text.text = "__CCHIAIO";
            images.sprite = tableSpoon;
        }
        else if (word == "CUBO")
        {
            text.text = "__BO";
            images.sprite = cube;
        }
        #endregion

        #region Check bool
        if (word == "CAVALLO" || word == "CASA" || word == "CANDELE" || word == "CAPPELLO" 
            || word == "CALZE" || word == "CAMALEONTE" || word == "OCA" || word == "FOCA")
        {
            CA = true;

            CO = false;
            CU = false;
        }
        else if (word == "CORDA" || word == "COLLANA" || word == "COLONNA")
        {
            CO = true;

            CA = false;
            CU = false;
        }
        else if (word == "CURVA" || word == "CUCCHIAIO" || word == "CUBO")
        {
            CU = true;

            CO = false;
            CA = false;
        }
        #endregion
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (CA)
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
        if (CO)
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
        if (CU)
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

    #region Buttons Return, Exit, Next
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Next()
    {
        SceneManager.LoadScene(5);
    }
    #endregion
}

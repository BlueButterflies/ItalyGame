using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS.Extensions.Common;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerSecondExample : MonoBehaviour
{
    #region Variables
    public Text text;
    public Text btnFirst;
    public Text btnSecond;
    public Text btnThird;
    public Text btnFourth;
    public Text btnFive;

    public Image images;
    public Sprite dog;
    public Sprite apple;
    public Sprite grape;
    public Sprite moon;
    public Sprite sun;
    public Sprite pipe;
    public Sprite nest;
    public Sprite branch;
    public Sprite cube;
    public Sprite book;
    public Sprite hand;
    public Sprite motorcycle;
    public Sprite fly;
    public Sprite house;
    public Sprite seaCalf;
    public Sprite goose;
    public Sprite city;


    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "MELE","CANE", "UVA", "LUNA", "SOLE", "PIPA", "NIDO", "RAMO", "CUBO", "LIBRO",
                               "MANI", "MOTO", "MOSCA", "CASA", "FOCA", "OCA","città".ToUpper()};
    private string word;
    #endregion

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Controller();
    }

    private void Controller()
    {
        word = words[Random.Range(0, words.Length)];

        //Debug.Log(word);

        if (word == "CANE")
        {
            text.text = "C_N_";
            images.sprite = dog;

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "A e A";
        }
        else if (word == "MELE")
        {
            text.text = "M_L_";
            images.sprite = apple;

            btnFirst.text = "O e E";
            btnSecond.text = "A e O";
            btnThird.text = "I e A";
            btnFourth.text = "E e E";
            btnFive.text = "U e A";
        }
        else if (word == "UVA")
        {
            text.text = "_V_";
            images.sprite = grape;

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "O e O";
            btnFourth.text = "O e E";
            btnFive.text = "E e A";
        }
        else if (word == "LUNA")
        {
            text.text = "L_N_";
            images.sprite = moon;

            btnFirst.text = "I e E";
            btnSecond.text = "E e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "U e A";
        }
        else if (word == "SOLE")
        {
            text.text = "S_L_";
            images.sprite = sun;

            btnFirst.text = "O e O";
            btnSecond.text = "E e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "I e E";
        }
        else if (word == "PIPA")
        {
            text.text = "P_P_";
            images.sprite = pipe;

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "A e A";
            btnFourth.text = "O e E";
            btnFive.text = "I e A";
        }
        else if (word == "NIDO")
        {
            text.text = "N_D_";
            images.sprite = nest;

            btnFirst.text = "I e O";
            btnSecond.text = "U e A";
            btnThird.text = "O e I";
            btnFourth.text = "U e E";
            btnFive.text = "A e A";
        }
        else if (word == "RAMO")
        {
            text.text = "R_M_";
            images.sprite = branch;

            btnFirst.text = "A e E";
            btnSecond.text = "A e O";
            btnThird.text = "I e O";
            btnFourth.text = "E e E";
            btnFive.text = "U e A";
        }
        else if (word == "CUBO")
        {
            text.text = "C_B_";
            images.sprite = cube;

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "I e I";
            btnFourth.text = "O e E";
            btnFive.text = "U e O";
        }
        else if (word == "LIBRO")
        {
            text.text = "L_BR_";
            images.sprite = book; 

            btnFirst.text = "E e A";
            btnSecond.text = "U e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "E e E";
        }
        else if (word == "MANI")
        {
            text.text = "M_N_";
            images.sprite = hand;

            btnFirst.text = "A e I";
            btnSecond.text = "U e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "A e U";
        }
        else if (word == "MOTO")
        {
            text.text = "M_T_";
            images.sprite = motorcycle;

            btnFirst.text = "I e E";
            btnSecond.text = "A e I";
            btnThird.text = "I e O";
            btnFourth.text = "O e O";
            btnFive.text = "A e E";
        }
        else if (word == "CASA")
        {
            text.text = "C_S_";
            images.sprite = house;

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "A e A";
            btnFourth.text = "O e E";
            btnFive.text = "O e A";
        }
        else if (word == "FOCA")
        {
            text.text = "F_C_";
            images.sprite = seaCalf
;

            btnFirst.text = "A e E";
            btnSecond.text = "O e A";
            btnThird.text = "I e O";
            btnFourth.text = "E e U";
            btnFive.text = "I e A";
        }
        else if (word == "OCA")
        {
            text.text = "_C_";
            images.sprite = goose;

            btnFirst.text = "O e A";
            btnSecond.text = "U e A";
            btnThird.text = "O e U";
            btnFourth.text = "O e E";
            btnFive.text = "A e I";
        }
        else if (word == "MOSCA")
        {
            text.text = "M_SC_";
            images.sprite = fly;

            btnFirst.text = "O e A";
            btnSecond.text = "U e A";
            btnThird.text = "I e I";
            btnFourth.text = "O e E";
            btnFive.text = "A e A";
        }
        else if (word == "città".ToUpper())
        {
            text.text = "C_TT_";
            images.sprite = city;

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "A e " + "à".ToUpper();
            btnFourth.text = "O e E";
            btnFive.text = "I e O";
        }
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == "CANE" && btnFirst.text == "A e E" || word == "NIDO" && btnFirst.text == "I e O" || word == "MANI" && btnFirst.text == "A e I"
             || word == "OCA" && btnFirst.text == "O e A" || word == "MOSCA" && btnFirst.text == "O e A")
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
        if (word == "UVA" && btnSecond.text == "U e A" || word == "RAMO" && btnSecond.text == "A e O" || word == "FOCA" && btnSecond.text == "O e A")
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
        if (word == "LIBRO" && btnThird.text == "I e O" || word == "CASA" && btnThird.text == "A e A"
            || word == "città".ToUpper() && btnThird.text == "A e " + "à".ToUpper())
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
        if (word == "MELE" && btnFourth.text == "E e E" || word == "SOLE" && btnFourth.text == "O e E" || word == "MOTO" && btnFourth.text == "O e O")
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
        if (word == "LUNA" && btnFive.text == "U e A" || word == "PIPA" && btnFive.text == "I e A" || word == "CUBO" && btnFive.text == "U e O")
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
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Next()
    {
        SceneManager.LoadScene(3);
    }
    #endregion
}

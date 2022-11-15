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
    public Sprite[] sprites;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CANE", "MELE", "UVA", "LUNA", "SOLE", "PIPA", "NIDO", "RAMO", "CUBO", "LIBRO",
                               "MANI", "MOTO", "CASA", "FOCA", "OCA", "MOSCA","città".ToUpper()};
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxtImges();
    }

    #region Random images and assing txt, image and txt buttons
    private void RandomWordsAndAssingTxtImges()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            text.text = "C_N_";
            images.sprite = sprites[0];

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "A e A";
        }
        else if (word == words[1])
        {
            text.text = "M_L_";
            images.sprite = sprites[1];

            btnFirst.text = "O e E";
            btnSecond.text = "A e O";
            btnThird.text = "I e A";
            btnFourth.text = "E e E";
            btnFive.text = "U e A";
        }
        else if (word == words[2])
        {
            text.text = "_V_";
            images.sprite = sprites[2];

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "O e O";
            btnFourth.text = "O e E";
            btnFive.text = "E e A";
        }
        else if (word == words[3])
        {
            text.text = "L_N_";
            images.sprite = sprites[3];

            btnFirst.text = "I e E";
            btnSecond.text = "E e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "U e A";
        }
        else if (word == words[4])
        {
            text.text = "S_L_";
            images.sprite = sprites[4];

            btnFirst.text = "O e O";
            btnSecond.text = "E e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "I e E";
        }
        else if (word == words[5])
        {
            text.text = "P_P_";
            images.sprite = sprites[5];

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "A e A";
            btnFourth.text = "O e E";
            btnFive.text = "I e A";
        }
        else if (word == words[6])
        {
            text.text = "N_D_";
            images.sprite = sprites[6];

            btnFirst.text = "I e O";
            btnSecond.text = "U e A";
            btnThird.text = "O e I";
            btnFourth.text = "U e E";
            btnFive.text = "A e A";
        }
        else if (word == words[7])
        {
            text.text = "R_M_";
            images.sprite = sprites[7];

            btnFirst.text = "A e E";
            btnSecond.text = "A e O";
            btnThird.text = "I e O";
            btnFourth.text = "E e E";
            btnFive.text = "U e A";
        }
        else if (word == words[8])
        {
            text.text = "C_B_";
            images.sprite =sprites[8];

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "I e I";
            btnFourth.text = "O e E";
            btnFive.text = "U e O";
        }
        else if (word == words[9])
        {
            text.text = "L_BR_";
            images.sprite = sprites[9]; 

            btnFirst.text = "E e A";
            btnSecond.text = "U e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "E e E";
        }
        else if (word == words[10])
        {
            text.text = "M_N_";
            images.sprite = sprites[10];

            btnFirst.text = "A e I";
            btnSecond.text = "U e A";
            btnThird.text = "I e O";
            btnFourth.text = "O e E";
            btnFive.text = "A e U";
        }
        else if (word == words[11])
        {
            text.text = "M_T_";
            images.sprite = sprites[11];

            btnFirst.text = "I e E";
            btnSecond.text = "A e I";
            btnThird.text = "I e O";
            btnFourth.text = "O e O";
            btnFive.text = "A e E";
        }
        else if (word == words[12])
        {
            text.text = "C_S_";
            images.sprite = sprites[12];

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "A e A";
            btnFourth.text = "O e E";
            btnFive.text = "O e A";
        }
        else if (word == words[13])
        {
            text.text = "F_C_";
            images.sprite = sprites[13];
;

            btnFirst.text = "A e E";
            btnSecond.text = "O e A";
            btnThird.text = "I e O";
            btnFourth.text = "E e U";
            btnFive.text = "I e A";
        }
        else if (word == words[14])
        {
            text.text = "_C_";
            images.sprite = sprites[14];

            btnFirst.text = "O e A";
            btnSecond.text = "U e A";
            btnThird.text = "O e U";
            btnFourth.text = "O e E";
            btnFive.text = "A e I";
        }
        else if (word == words[15])
        {
            text.text = "M_SC_";
            images.sprite = sprites[15];

            btnFirst.text = "O e A";
            btnSecond.text = "U e A";
            btnThird.text = "I e I";
            btnFourth.text = "O e E";
            btnFive.text = "A e A";
        }
        else if (word == words[16])
        {
            text.text = "C_TT_";
            images.sprite = sprites[16];

            btnFirst.text = "A e E";
            btnSecond.text = "U e A";
            btnThird.text = "I e " + "à".ToUpper();
            btnFourth.text = "O e E";
            btnFive.text = "I e O";
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == words[0] && btnFirst.text == "A e E" || word == words[6] && btnFirst.text == "I e O" || word == words[10] && btnFirst.text == "A e I"
             || word == words[14] && btnFirst.text == "O e A" || word == words[15] && btnFirst.text == "O e A")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImges();

        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == words[2] && btnSecond.text == "U e A" || word == words[7] && btnSecond.text == "A e O" || word == words[13] && btnSecond.text == "O e A")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImges();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (word == words[9] && btnThird.text == "I e O" || word == words[12] && btnThird.text == "A e A"
           || word == words[16] && btnThird.text == "I e " + "à".ToUpper())
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImges();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FourthBtn()
    {
        if (word == words[1] && btnFourth.text == "E e E" || word == words[4] && btnFourth.text == "O e E" || word == words[11] && btnFourth.text == "O e O")
            {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImges();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FifthBtn()
    {
        if (word == words[3] && btnFive.text == "U e A" || word == words[5] && btnFive.text == "I e A" || word == words[8] && btnFive.text == "U e O")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImges();
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
        SceneManager.LoadScene(3);
    }
    #endregion
}

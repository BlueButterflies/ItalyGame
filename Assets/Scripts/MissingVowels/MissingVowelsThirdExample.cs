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
    public Sprite[] sprites;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "ALA","OMBRELLO", "FIORI", "GATTO", "PALLA", "CANDELE", "FUNGHI", "IMBUTO", "ISOLA", "FRAGOLE", "APE",
                               "ELFO", "ASINO", "ANATRA", "IPPOPOTAMO", "ARCOBALENO", "OROLOGIO", "iglù".ToUpper(),  "UNO", "UVA"};
    private string word;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomWordsAndAssingTxtImage();
    }

    #region Random words and assing txt and image
    private void RandomWordsAndAssingTxtImage()
    {
        word = words[Random.Range(0, words.Length)];

        if (word == words[0])
        {
            text.text = "_LA";
            images.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            text.text = "_MBRELLO";
            images.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            text.text = "FIOR_";
            images.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            text.text = "GATT_";
            images.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            text.text = "PALL_";
            images.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            text.text = "CANNDEL_";
            images.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            text.text = "FUNGH_";
            images.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            text.text = "_MBUTO";
            images.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            text.text = "_SOLA";
            images.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            text.text = "FRAGOL_";
            images.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            text.text = "_PE";
            images.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            text.text = "_LFO";
            images.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            text.text = "_SINO";
            images.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            text.text = "_NATRA";
            images.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            text.text = "_PPOPOTAMO";
            images.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            text.text = "_RCOBALENO";
            images.sprite = sprites[15];
        }
        else if (word == words[16])
        {
            text.text = "_ROLOGGIO";
            images.sprite = sprites[16];
        }
        else if (word == words[17])
        {
            text.text = "_glù".ToUpper();
            images.sprite = sprites[17];
        }
        else if (word == words[18])
        {
            text.text = "_NO";
            images.sprite = sprites[18];
        }
        else if (word == words[19])
        {
            text.text = "_VA";
            images.sprite = sprites[19];
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == words[0] || word == words[4] || word == words[10] || word == words[13] ||
            word == words[15] || word == words[012])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void SecondBtn()
    {
        if (word == words[11] || word == words[9] || word == words[5])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ThirdBtn()
    {
        if (word == words[8] || word == words[7] || word == words[14] || word == words[6] || word == words[2] || word == words[17])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void FourthBtn()
    {
        if (word == words[3] || word == words[1] || word == words[16])
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomWordsAndAssingTxtImage();
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
            RandomWordsAndAssingTxtImage();
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

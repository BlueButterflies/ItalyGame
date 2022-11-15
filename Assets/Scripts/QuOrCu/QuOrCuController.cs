using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuOrCuController : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite[] sprites;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CUORE", "SCUOLA", "CUBO", "CUSCINO", "CUOCO", "CULLA", "CUCCIOLO","CUSTODE",
                               "QUATTRO", "QUADRO","AQUILONE", "SQUALO", "QUADERNO", "CINQUE", "SQUADRA","AQUILA"};                           
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
            text.text = "__ORE";
            images.sprite = sprites[0];
        }
        else if (word == words[1])
        {
            text.text = "S__OLA";
            images.sprite = sprites[1];
        }
        else if (word == words[2])
        {
            text.text = "__BO";
            images.sprite = sprites[2];
        }
        else if (word == words[3])
        {
            text.text = "__SCINO";
            images.sprite = sprites[3];
        }
        else if (word == words[4])
        {
            text.text = "__OCO";
            images.sprite = sprites[4];
        }
        else if (word == words[5])
        {
            text.text = "__LLA";
            images.sprite = sprites[5];
        }
        else if (word == words[6])
        {
            text.text = "__CCIOLO";
            images.sprite = sprites[6];
        }
        else if (word == words[7])
        {
            text.text = "__STODE";
            images.sprite = sprites[7];
        }
        else if (word == words[8])
        {
            text.text = "__ATTRO";
            images.sprite = sprites[8];
        }
        else if (word == words[9])
        {
            text.text = "__ADRO";
            images.sprite = sprites[9];
        }
        else if (word == words[10])
        {
            text.text = "A__ILONE";
            images.sprite = sprites[10];
        }
        else if (word == words[11])
        {
            text.text = "S__ALO";
            images.sprite = sprites[11];
        }
        else if (word == words[12])
        {
            text.text = "__ADERNO";
            images.sprite = sprites[12];
        }
        else if (word == words[13])
        {
            text.text = "CIN__E";
            images.sprite = sprites[13];
        }
        else if (word == words[14])
        {
            text.text = "S__ADRA";
            images.sprite = sprites[14];
        }
        else if (word == words[15])
        {
            text.text = "A__ILA";
            images.sprite = sprites[15];
        }
    }
    #endregion

    #region Buttons Answer
    public void FirstBtn()
    {
        if (word == words[8] || word == words[9] || word == words[10] || word == words[11] || word == words[12]
                 || word == words[13] || word == words[14] || word == words[15])
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
        if (word == words[0] || word == words[1] || word == words[2] || word == words[3]
            || word == words[4] || word == words[5] || word == words[6] || word == words[7])
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

    #region Buttons Return, Exit,Next
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
        SceneManager.LoadScene(9);
    }
    #endregion
}

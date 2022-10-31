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
    public Sprite heard;
    public Sprite school;
    public Sprite cube;
    public Sprite pillow;
    public Sprite crib;
    public Sprite cook;
    public Sprite four;
    public Sprite five;
    public Sprite kite;
    public Sprite eagle;
    public Sprite shark;
    public Sprite team;
    public Sprite guardian;
    public Sprite notebook;
    public Sprite square;
    public Sprite puppy;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CUORE", "SCUOLA", "CUBO", "CUSCINO", "CUOCO", "CULLA", "QUATTRO", "QUADRO",
                               "AQUILONE", "SQUALO", "QUADERNO", "CINQUE", "SQUADRA","AQUILA","CUCCIOLO","CUSTODE"};
    private string word;

    private bool QU;
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
        if (word == "CUORE")
        {
            text.text = "__ORE";
            images.sprite = heard;
        }
        else if (word == "SCUOLA")
        {
            text.text = "S__OLA";
            images.sprite = school;
        }
        else if (word == "CUBO")
        {
            text.text = "__BO";
            images.sprite = cube;
        }
        else if (word == "CUSCINO")
        {
            text.text = "__SCINO";
            images.sprite = pillow;
        }
        else if (word == "CUOCO")
        {
            text.text = "__OCO";
            images.sprite = cook;
        }
        else if (word == "CULLA")
        {
            text.text = "__LLA";
            images.sprite = crib;
        }
        else if (word == "QUATTRO")
        {
            text.text = "__ATTRO";
            images.sprite = four;
        }
        else if (word == "QUADRO")
        {
            text.text = "__ADRO";
            images.sprite = square;
        }
        else if (word == "AQUILONE")
        {
            text.text = "A__ILONE";
            images.sprite = kite;
        }
        else if (word == "SQUALO")
        {
            text.text = "S__ALO";
            images.sprite = shark;
        }
        else if (word == "QUADERNO")
        {
            text.text = "__ADERNO";
            images.sprite = notebook;
        }
        else if (word == "CINQUE")
        {
            text.text = "CIN__E";
            images.sprite = five;
        }
        else if (word == "SQUADRA")
        {
            text.text = "S__ADRA";
            images.sprite = team;
        }
        else if (word == "AQUILA")
        {
            text.text = "A__ILA";
            images.sprite = eagle;
        }
        else if (word == "CUCCIOLO")
        {
            text.text = "__CCIOLO";
            images.sprite = puppy;
        }
        else if (word == "CUSTODE")
        {
            text.text = "__STODE";
            images.sprite = guardian;
        }
        
        #endregion

        #region Check bool
        if (word == "CUORE" || word == "SCUOLA" || word == "CUBO" || word == "CUSCINO"
            || word == "CUOCO" || word == "CULLA" || word == "CUCCIOLO" || word == "CUSTODE")
        {
            QU = false;

            CU = true;
        }
        else if (word == "QUATTRO" || word == "QUADRO" || word == "CINQUE" || word == "QUADERNO" || word == "SQUALO"
                 || word == "AQUILONE" || word == "AQUILA")
        {
            CU = false;

            QU = true;
        }
        #endregion
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (QU)
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
        SceneManager.LoadScene(8);
    }
    #endregion
}

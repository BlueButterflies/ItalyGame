using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GnaGneGniGnoGnuThirdExample : MonoBehaviour
{
    #region Variables
    public AudioClip[] audioClips;
    private AudioSource audioSource;

    public Sprite[] sprite;
    public Image image;
    public InputField input;

    private string inputTxt;
    #endregion

    public void Start()
    {
        audioSource =  GetComponent<AudioSource>();

        RandomImeges();
    }

    #region Random Images
    private void RandomImeges()
    {
        int num = Random.Range(0, sprite.Length);
        image.sprite = sprite[num];

        input.text = "";
    }
    #endregion

    #region Read and Check Inputs
    public void CheckInput()
    {
        if (inputTxt == "pigne" || inputTxt == "Pigne" || inputTxt == "Pigne")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "MONTAGNA" || inputTxt == "montagna" || inputTxt == "Montagna")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "CASTAGNE" || inputTxt == "Castagne" || inputTxt == "castagne")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "CIGNO" || inputTxt == "Cigno" || inputTxt == "cigno")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "RAGNATELA" || inputTxt == "Ragnatela" || inputTxt == "ragnatela")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "LAVAGNA" || inputTxt == "Lavagna" || inputTxt == "lavagna")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "RAGNO" || inputTxt == "Ragno" || inputTxt == "ragno")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "Lasagna" || inputTxt == "lasagna" || inputTxt == "LASAGNA")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "CICOGNA" || inputTxt == "Cicogna" || inputTxt == "cicogna")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "stagno" || inputTxt == "Stagno" || inputTxt == "STAGNO")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "SPUGNA" || inputTxt == "Spugna" || inputTxt == "spugna")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "Bagnino" || inputTxt == "bagnino" || inputTxt == "BAGNINO")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "BAGNO" || inputTxt == "Bagno" || inputTxt == "bagno")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "PRUGNE" || inputTxt == "Prugne" || inputTxt == "prugne")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "AGNELLO" || inputTxt == "Agnello" || inputTxt == "agnello")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "GNU" || inputTxt == "Gnu" || inputTxt == "gnu")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "LEGNO" || inputTxt == "Legno" || inputTxt == "legno")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "INSEGNANTE" || inputTxt == "Insegnante" || inputTxt == "insegnante")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "GNOCCHI" || inputTxt == "Gnocchi" || inputTxt == "gnocchi")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else if (inputTxt == "gnomo" || inputTxt == "GNOMO" || inputTxt == "Gnomo")
        {
            audioSource.PlayOneShot(audioClips[0]);
            RandomImeges();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
            input.text = "";
        }
    }

    public void ReadInput(string s)
    {
        inputTxt = s;
    }
    #endregion

    #region Buttons Return and Exit
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

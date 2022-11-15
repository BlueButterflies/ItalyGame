using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceSciScheSchiFirstController : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Sprite[] sprites;
    public Image image;

    public Text txtSceSche;
    public Text txtSciSchi;

    private int num;

    private bool sce;
    private bool sci;
    private bool schi;
    private bool sche;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RandomImagesh();
        CheckImages();
    }

    #region Random and Check images
    private void RandomImagesh()
    {
        num =  Random.Range(0, sprites.Length);

        image.sprite = sprites[num];
    }

    private void CheckImages()
    {
        if (num == 0 || num == 1  || num == 2 || num == 3 || num == 4 || num == 5 || num == 6 || num == 7 || num == 8 || num == 9
            || num == 10 || num == 18 || num == 19 || num == 20 || num == 21)
        {
            if (num == 0 || num == 5 || num == 8 || num == 18 || num == 19 || num == 20)
            {
                sce = true;
                sci =  false;
                sche = false;
                schi = false;
            }
            else if (num == 1 || num == 2 || num == 3 || num == 4 || num == 6 || num == 7 || num == 9 || num == 10 || num == 21)
            {
                sce = false;
                sci = true;
                sche = false;
                schi = false;
            }

            txtSceSche.text = "SCE";
            txtSciSchi.text = "SCI";
        }
        else if (num == 11 || num == 12 || num == 13 || num == 14 || num == 15 || num == 16 || num == 17 || num == 22 || num == 23)
        {
            if (num == 11 || num == 12 || num == 14 || num == 16 || num == 22)
            {
                sce = false;
                sci = false;
                sche = true;
                schi = false;
            }
            else if (num == 13 || num == 15 || num == 17 || num == 23)
            {
                sce = false;
                sci = false;
                sche = false;
                schi = true;
            }

            txtSceSche.text = "SCHE";
            txtSciSchi.text = "SCHI";
        }
    }
    #endregion

    #region Buttons SceSche and SciSchi
    public void BtnSceSche()
    {
        if (sce)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomImagesh();
            CheckImages();
        }
        else if (sche)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomImagesh();
            CheckImages();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void BtnSciSchi()
    {
        if (sci)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomImagesh();
            CheckImages();
        }
        else if (schi)
        {
            audioSource.PlayOneShot(audioClips[0]);

            RandomImagesh();
            CheckImages();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }
    #endregion

    #region Buttons Return Next and Exit
    public void Return()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(15);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}

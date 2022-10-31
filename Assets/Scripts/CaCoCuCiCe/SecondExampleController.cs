using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondExampleController : MonoBehaviour
{
    #region Variables
    public Text text;

    public Image images;
    public Sprite bandai;
    public Sprite brain;
    public Sprite bascket;
    public Sprite cucumber;
    public Sprite hundred;
    public Sprite smartphone;
    public Sprite deer;
    public Sprite walnut;
    public Sprite sweet;
    public Sprite cross;
    public Sprite zip;
    public Sprite five;
    public Sprite root;
    public Sprite swan;
    public Sprite food;
    public Sprite fleas;
    public Sprite circus;
    public Sprite cylinder;
    public Sprite stork;
    public Sprite boar;
    public Sprite onion;
    public Sprite bike;
    public Sprite enclosure;

    public AudioClip[] audioClips;
    private AudioSource audioSource;

    private string[] words = { "CEROTTO", "CERVELLO", "CESTO", "CETRIOLO", "CENTO", "CELLULARE", "CERVO", "NOCE",
                               "DOLCE", "CROCE", "RADICE", "CERNIERA", "CINQUE", "CIRCO","CIGNO","CIBO","PULCI",
                               "CILINDRO", "CICOGNA","CINGHIALE","CIPOLLA","BICI","RECINTO"};
    private string word;

    private bool CE;
    private bool CI;
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
        if (word == "CEROTTO")
        {
            text.text = "__ROTTO";
            images.sprite = bandai;
        }
        else if (word == "CERVELLO")
        {
            text.text = "__RVELLO";
            images.sprite = brain;
        }
        else if (word == "CESTO")
        {
            text.text = "__STO";
            images.sprite = bascket;
        }
        else if (word == "CETRIOLO")
        {
            text.text = "__TRIOLO";
            images.sprite = cucumber;
        }
        else if (word == "CENTO")
        {
            text.text = "__NTO";
            images.sprite = hundred;
        }
        else if (word == "CELLULARE")
        {
            text.text = "__LLULARE";
            images.sprite = smartphone;
        }
        else if (word == "CERVO")
        {
            text.text = "__RVO";
            images.sprite = deer;
        }
        else if (word == "NOCE")
        {
            text.text = "NO__";
            images.sprite = walnut;
        }
        else if (word == "DOLCE")
        {
            text.text = "DOL__";
            images.sprite = sweet;
        }
        else if (word == "CROCE")
        {
            text.text = "CRO__";
            images.sprite = cross;
        }
        else if (word == "RADICE")
        {
            text.text = "RADI__";
            images.sprite = root;
        }
        else if (word == "CERNIERA")
        {
            text.text = "__RNIERA";
            images.sprite = zip;
        }
        else if (word == "CINQUE")
        {
            text.text = "__NQUE";
            images.sprite = five;
        }
        else if (word == "CIRCO")
        {
            text.text = "__RCO";
            images.sprite = circus;
        }
        else if (word == "CIGNO")
        {
            text.text = "__GNO";
            images.sprite = swan;
        }
        else if (word == "CILINDRO")
        {
            text.text = "__LINDRO";
            images.sprite = cylinder;
        }
        else if (word == "CIBO")
        {
            text.text = "__BO";
            images.sprite = food;
        }
        else if (word == "PULCI")
        {
            text.text = "__LCI";
            images.sprite = fleas;
        }
        else if (word == "CICOGNA")
        {
            text.text = "__COGNA";
            images.sprite = stork;
        }
        else if (word == "CINGHIALE")
        {
            text.text = "__NGHIALE";
            images.sprite = boar;
        }
        else if (word == "BICI")
        {
            text.text = "BI__";
            images.sprite = bike;
        }
        else if (word == "RECINTO")
        {
            text.text = "RE__NTO";
            images.sprite = enclosure;
        }
        else if (word == "CIPOLLA")
        {
            text.text = "__POLLA";
            images.sprite = onion;
        }
        #endregion

        #region Check bool
        if (word == "CEROTTO" || word == "CERVELLO" || word == "CESTO" || word == "CETRIOLO"
            || word == "CENTO" || word == "CELLULARE" || word == "CERVO" || word == "NOCE" || word == "DOLCE"
             || word == "CROCE" || word == "RADICE" || word == "CERNIERA")
        {
            CE = true;

            CI = false;
        }
        else if (word == "CINQUE" || word == "CIRCO" || word == "CIGNO" || word == "CICOGNA" || word == "CILINDRO" 
                 || word == "PULCI" || word == "CIBO" || word == "CINGHIALE" || word == "CIPOLLA" || word == "BICI" || word == "RECINTO")
        {
            CI = true;

            CE = false;
        }
        #endregion
    }

    #region Buttons Answer
    public void FirstBtn()
    {
        if (CE)
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
        if (CI)
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

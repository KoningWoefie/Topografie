using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateOptions : MonoBehaviour
{
    //buttons
    [SerializeField] private GameObject option1;
    public GameObject Option1 { get { return option1; } }
    [SerializeField] private GameObject option2;
    [SerializeField] private GameObject option3;

    private Singleton singleton = Singleton.Instance;

    //positions for the buttons
    [SerializeField]GameObject[] positions = new GameObject[3];

    //list of sprites
    [SerializeField]List<Sprite> countrySprites = new List<Sprite>();
    
    //image for the country
    [SerializeField] private GameObject countryImage;

    public void GenerateTheThingiemcJigs()
    {
        //set the positions of the options
        int pos = 0;
        pos = (int)Random.Range(0, 3);
        option1.transform.position = positions[pos].transform.position;
        option2.transform.position = positions[(pos + 1) % 3].transform.position;
        option3.transform.position = positions[(pos + 2) % 3].transform.position;

        //set the country image
        int countryIndex = (int)(Random.Range(0, 46));
        // countryImage.GetComponent<Image>().sprite = countrySprites[countryIndex];

        //set the options
        int rand = 0;
        int lastRand = 0;
        rand = (int)(Random.Range(0, 46));
        lastRand = rand;
        option1.GetComponent<Button>().SetText(singleton.EUoptions[countryIndex]);
        option1.GetComponent<Button>().isRight = true;
        while (rand == lastRand || countryIndex == rand)
        {
            rand = (int)(Random.Range(0, 46));
        }
        option2.GetComponent<Button>().SetText(singleton.EUoptions[rand]);
        lastRand = rand;
        while (rand == lastRand || countryIndex == rand)
        {
            rand = (int)(Random.Range(0, 46));
        }
        option3.GetComponent<Button>().SetText(singleton.EUoptions[rand]);
    }
}

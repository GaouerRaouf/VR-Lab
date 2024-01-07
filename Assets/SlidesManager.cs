using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlidesManager : MonoBehaviour
{
    [SerializeField] GameObject[] SlidesArray;
    [SerializeField] GameObject[] holograms;
    public int currentPage = 0;

    public GameObject previousButton;
    public GameObject nextButton;

    // Start is called before the first frame update
    void Start()
    {
        ChangelogPage(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayHologram(GameObject go)
    {
        go.SetActive(true);
    }

    public void ChangelogPage(int page)
    {
        HideHolograms();
        SlidesArray[currentPage].SetActive(false);
        currentPage += page;
        if(currentPage == SlidesArray.Length-1)
        {
            nextButton.SetActive(false);
        }
        else
        {
            nextButton.SetActive(true);
        }

        if(currentPage <= 0)
        {
            previousButton.SetActive(false);
        }
        else
        {
            previousButton.SetActive(true);
        }
        SlidesArray[currentPage].SetActive(true);
    }

    public void HideHolograms()
    {
        foreach(GameObject hologram in holograms)
        {
            hologram.SetActive(false);
        }
    }


}

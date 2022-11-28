using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update

    private string oneplayer = "OnePlayerMain";
    private string twoplayer = "TwoPlayerMain";
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnePLayer()
    {
        SceneManager.LoadScene(oneplayer);
    }

    public void TwoPlayer()
    {
        SceneManager.LoadScene(twoplayer);
    }
}

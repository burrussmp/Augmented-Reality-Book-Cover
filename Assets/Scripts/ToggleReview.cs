using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class ToggleReview : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject VirtualButton;
    public GameObject DisplayText, ButtonText;
    private bool info = true;
    private TextMesh myText,buttonText;
    // Start is called before the first frame update
    // comment
    void Start()
    {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        DisplayText = GameObject.Find("DisplayText");
	ButtonText = GameObject.Find("ButtonText");
        myText = DisplayText.GetComponent<TextMesh>();
	buttonText = ButtonText.GetComponent<TextMesh>();
    }
    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (info) {
            myText.text = "Book Information\n\nAuthor: Aaron GoldFarb\nTitle: Hacking Whiskey\nPage Count: 264\nISBN: 978-0-9996612-4-6\nPublication: Sept. 2018";
            myText.fontSize = 9;
	    buttonText.text = "Click For\nReview";
        } else {
            myText.text = "Book Review\n\n\"Aaron has been a prolific writer\nand researcher of all things\nadult beverage. His background\ninto the topic and access to key\nplayers brings a level of\nknowledge second to none.\n\nThe chapters are short and\n to the point. I knew I’d like\n this book as soon as I read\n the section on whisky cubes.\n Great stuff!\"-Anonymous";
            myText.fontSize = 8;
	    buttonText.text = "Click For\nInfo";
        }
        info = !info;
    }

    // Update is called once per frame
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


class StoryBlock
{
    public string story;
    public string option1Text;
    public string option2Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;
    public StoryBlock(string story, string option1Text = "", string option2Text = "", StoryBlock option1Block = null, StoryBlock option2Block = null)
    {
        this.story = story;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
        this.option1Block = option1Block;
        this.option2Block = option2Block;
    }
}


public class GameManager : MonoBehaviour
{

    public Text mainText;
    public Button option1;
    public Button option2;

    StoryBlock currentBlock;

    static StoryBlock block8 = new StoryBlock("You decided to sit here...");
    static StoryBlock block7 = new StoryBlock("You have approached the wooden...");
    static StoryBlock block6 = new StoryBlock("The floor is covered with huge amounts of the small stones. You started to move your hand around them to maybe find something usefull... and there is something! It is a key!", "Try to unlock doors.", "Do nothing.", block7, block8);
    static StoryBlock block5 = new StoryBlock("You started reaching into your pockets, but nothing could be found there.", "Inspect floor.", "Do nothing.", block6, block8);
    static StoryBlock block4 = new StoryBlock("Because you quickly get tired of screaming, you decided to sit down and devise an escape route.", "Inspect floor.", "Check your pockets.", block6, block5);
    static StoryBlock block3 = new StoryBlock("You noticed a big, wooden doors on the opposite side of the room. After quick inspection, it looks like they are closed. But there is a key lock!", "Do nothing.", "Inspect floor.", block8, block6);
    static StoryBlock block2 = new StoryBlock("You started to panic and screamed for help, but it looks like, you are completly alone.", "Sit down.", "Check the doors.", block4, block3);
    static StoryBlock block1 = new StoryBlock("You just woke up in a small, dark cell in an old castle.", "Look for other people.", "Check the doors.", block2, block3);

    void Start()
    {
        DisplayBlocks(block1);
    }

    void DisplayBlocks(StoryBlock block)
    {
        mainText.text = block.story;
        option1.GetComponentInChildren<Text>().text = block.option1Text;
        option2.GetComponentInChildren<Text>().text = block.option2Text;
        currentBlock = block;
    }

    public void Button1Clicked()
    {
        DisplayBlocks(currentBlock.option1Block);
    }

    public void Button2Clicked()
    {
        DisplayBlocks(currentBlock.option2Block);
    }
    
}

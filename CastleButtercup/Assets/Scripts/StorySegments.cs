using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story Segment")]

public class StorySegments : ScriptableObject
{
    [SerializeField] [TextArea(25,14)] public string storyText;
    [SerializeField] public StorySegments[] nextStorySegments;

}

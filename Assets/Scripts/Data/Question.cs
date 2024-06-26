using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Question
{
    public string question {get; set;}
    public List<Answer> answers {get; set;}
    public string background {get; set;}
}

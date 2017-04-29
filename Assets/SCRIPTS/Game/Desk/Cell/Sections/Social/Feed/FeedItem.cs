using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedItem {

    //public Sprite Photo;
    public string Name;
    public string Day;
    public string TimeStamp;
    public string Text;
    public string Likes;
    public string Comments;

    public FeedItem(string name, string day, string timestamp, string text, string likes, string comments) {
        //Photo = photo;
        Name = name;
        Day = day;
        TimeStamp = timestamp;
        Text = text;
        Likes = likes;
        Comments = comments;
    }
}

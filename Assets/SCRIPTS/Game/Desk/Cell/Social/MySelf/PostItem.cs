using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostItem {

    public Sprite Photo;
    public string Name;
    public string Day;
    public string Timestamp;
    public string Text;
    public string Likes;
    public string Comments;

    public PostItem(Sprite photo, string name, string day, string timestamp, string text, string likes, string comments) {
        Photo = photo;
        Name = name;
        Day = day;
        Timestamp = timestamp;
        Text = text;
        Likes = likes;
        Comments = comments;
    }
}

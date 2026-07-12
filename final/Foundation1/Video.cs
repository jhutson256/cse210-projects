using System;
/*
Name: Jacob Hutson
Date: 7/11/2026
Class: CSE 210
Description: This class handles all of the individual video information.
Sources:
1. Gemini Code Advice
2. In Class Notes
*/

public class Video
{
    public string _jphTitle;
    public string _jphAuthor;
    public int _jphLength;
    private List<Comment> _jphComments;

    public Video(string jph_title, string jph_author, int jph_length)
    {
        _jphTitle = jph_title;
        _jphAuthor = jph_author;
        _jphLength = jph_length;
        _jphComments = new List<Comment>();
    }

    public void AddComment(Comment jph_comment)
    {
        _jphComments.Add(jph_comment);
    }

    public int GetCommentCount()
    {
        return _jphComments.Count;
    }

    public List<Comment> GetComments()
    {
        return _jphComments;
    }
}
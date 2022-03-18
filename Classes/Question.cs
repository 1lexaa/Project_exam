using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Text.Json;


namespace Project
{
    public class Question
    {
public string Name;
public int Price;
public bool Result;


private string[] AnswerArray;
private string An = String.Empty;
private int rightAnswer;
private string sym = "abcd";

public Question(string n, int p, int right, params string[] a)
{
    AnswerArray = new string[a.Length];
    a.CopyTo(AnswerArray,0);
    rightAnswer = right - 1;
    Name = n;
    Price = p;
}

public  string GetAnswers()
{
    string endStr = String.Empty;
char[] EndSym = new char[AnswerArray.Length];
    sym.CopyTo(0,EndSym,0,AnswerArray.Length);
    for(int i = 0; i < AnswerArray.Length; i++)
    {
        endStr += EndSym[i] +"-"+AnswerArray[i] + " ";
    }
    return endStr;
}

public int SetAnswers(string s)
{
    int num = sym.IndexOf(s,StringComparison.Ordinal);
    if(num == rightAnswer) 
    {
        return Price;
    }
    else
    {
        return 0;
    }
}

    }
}
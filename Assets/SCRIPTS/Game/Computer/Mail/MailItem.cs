using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailItem {

    public string Sender, Subject, Message, TimeStamp;
    
    public MailItem(string sender, string subject, string message, string timeStamp) {
        Sender = sender;
        Subject = subject;
        Message = message;
        TimeStamp = timeStamp;
    }
}

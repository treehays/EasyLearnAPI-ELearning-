﻿namespace EasyLearn.Models.DTOs.EmailSenderDTOs;

public class EmailSenderDTO
{
    public string ReceiverName { get; set; }
    public string ReceiverEmail { get; set; }
    public string Body { get; set; }
    public string Subject { get; set; }
    public string File { get; set; }
    public string FIleName { get; set; }
}

public class EmailSenderAttachmentDTO
{
    public string ReceiverName { get; set; }
    public string ReceiverEmail { get; set; }
    public string Body { get; set; }
    public string Subject { get; set; }
    public string File { get; set; }
    public string FIleName { get; set; }
}




public class EmailSenderDetails
{
    public string ReceiverName { get; set; }
    public string ReceiverEmail { get; set; }
    public string EmailToken { get; set; }
}


public class EmailSenderNoAttachmentDTO
{
    public string ReceiverName { get; set; }
    public string Body { get; set; }
    public string ReceiverEmail { get; set; }
    public string Subject { get; set; }
}

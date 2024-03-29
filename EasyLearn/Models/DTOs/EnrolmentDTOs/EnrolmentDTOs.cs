﻿using EasyLearn.Models.Enums;

namespace EasyLearn.Models.DTOs.EnrolmentDTOs
{
    public class EnrolmentDTO
    {
        public string Id { get; set; }
        public CompletionStatus CompletionStatus { get; set; }
        public int NumberOfEnrollments { get; set; }
        public string Grade { get; set; }
        public string CertificateNumber { get; set; }
        public DateTime AccessExpiration { get; set; }
        //public PaymentStatus PaymentStatus { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public string StudentName { get; set; }
        public string CourseTitle { get; set; }
        public DateTime CreatedOn { get; set; }

        //public string InstructorFeedBack { get; set; }
        //public string UserFeedBack { get; set; }
    }



    public class CreateEnrolmentRequestModel
    {
        public string CourseId { get; set; }
        public decimal AmountPaid { get; set; }
        public string Coupon { get; set; }
        public string CourseName { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public PaymentMethods PaymentMethods { get; set; }
        //public InitializePaymentRequestModel PaymentRequest { get; set; }

        //public CompletionStatus CompletionStatus { get; set; }
        //public PaymentStatus PaymentStatus { get; set; }
        //public DateTime AccessExpiration { get; set; }
        //public string InstructorFeedBack { get; set; }
        //public string UserFeedBack { get; set; }
    }


    public class UpdateEnrolmentRequestModel
    {
        public string Id { get; set; }
        public CompletionStatus CompletionStatus { get; set; }
        public string Grade { get; set; }
        public string CertificateNumber { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime AccessExpiration { get; set; }
        //public string StudentId { get; set; }
        //public string CourseId { get; set; }
        //public string InstructorFeedBack { get; set; }
        //public string UserFeedBack { get; set; }
    }

    //public class EnrolmentResponseModel : BaseResponse
    //{
    //    public EnrolmentDTO Data { get; set; }
    //}

    //public class EnrolmentsResponseModel : BaseResponse
    //{
    //    public int NumberOfEnrollments { get; set; }
    //    public IEnumerable<EnrolmentDTO> Data { get; set; }

    //}

}

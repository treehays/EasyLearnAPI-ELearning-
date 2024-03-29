﻿namespace EasyLearn.Models.DTOs.ModuleDTOs;

public class ModuleDTO
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Resources { get; set; }
    public string Prerequisites { get; set; }
    public string Objective { get; set; }
    public string ModuleDuration { get; set; }
    public string VideoSequence { get; set; }
    public int SequenceOfModule { get; set; }
    public string VideoPath { get; set; }
    public string CourseId { get; set; }
}


public class CreateModuleRequestModel
{
    //knj
    public string Title { get; set; }
    public string Description { get; set; }
    public string Resources { get; set; }
    public string Prerequisites { get; set; }
    public string Objective { get; set; }
    //public double ModuleDuration { get; set; }
    public int SequenceOfModule { get; set; }
    public List<IFormFile> FormFiles { get; set; }
    public string CourseId { get; set; }
}


public class UpdateModuleRequestModel
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Resources { get; set; }
    public string Prerequisites { get; set; }
    public string Objective { get; set; }
    //public double ModuleDuration { get; set; }
    public IFormFile FormFile { get; set; }
    public int SequenceOfModule { get; set; }
}


//public class ModuleResponseModel : BaseResponse
//{
//    public ModuleDTO Data { get; set; }
//}


public class ModulesResponseModel
{
    public int PageCount { get; set; }
    public int CurrentPageIndex { get; set; }
    public string CourseId { get; set; }
    public IEnumerable<ModuleDTO> Data { get; set; }
}

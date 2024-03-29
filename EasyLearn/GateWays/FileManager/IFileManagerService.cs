﻿using EasyLearn.Models.DTOs;
using EasyLearn.Models.DTOs.FIleManagerDTOs;

namespace EasyLearn.GateWays.FileManager;

public interface IFileManagerService
{
    Task<string> GetFileName(IFormFile file, params string[] docPath);
    //Task<List<string>> GetListOfFileName(List<IFormFile> formFiles, params string[] docPath);
    Task<List<VideoNameAndDurationResponseModel>> GetListOfVideoProperty(List<IFormFile> formFiles, params string[] docPath);
    BaseResponse<CSVFileResponseModel> ReadModuleUploader(string fileName);
    string GenerateModuleUploaderTemplate(ICollection<CSVFileManagerDTO> model);
    TimeSpan GetVideoLenght(string videoPath);
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;

namespace MPACore.PhoneBook.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        [Range(1, 500)]
        public int MaxResultCount { get; set; }
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
        public string Sorting { get; set; }
    }
}

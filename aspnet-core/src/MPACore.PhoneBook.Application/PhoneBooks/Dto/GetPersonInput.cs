using System;
using System.Collections.Generic;
using System.Text;
using Abp;
using Abp.Runtime.Validation;
using MPACore.PhoneBook.Dto;

namespace MPACore.PhoneBook.PhoneBooks.Dto
{
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {
        //ViewModel(视图验证模型)=>dto=>model
        /// <summary>
        /// 模糊查询用
        /// </summary>
        public string FilterText { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}

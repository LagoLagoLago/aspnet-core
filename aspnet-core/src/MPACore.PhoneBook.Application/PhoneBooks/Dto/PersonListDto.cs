using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using MPACore.PhoneBook.PhoneBooks.Persons;

namespace MPACore.PhoneBook.PhoneBooks.Dto
{
    /// <summary>
    /// 查询用
    /// </summary>    
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>       
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>        
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址
        /// </summary>       
        public string Address { get; set; }
    }
}
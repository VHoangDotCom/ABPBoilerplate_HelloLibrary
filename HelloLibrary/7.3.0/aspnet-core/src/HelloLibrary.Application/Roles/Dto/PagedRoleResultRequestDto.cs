using Abp.Application.Services.Dto;

namespace HelloLibrary.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


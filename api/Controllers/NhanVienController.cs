using Application.DTO.NhanVien;
using Application.DTOs.Common;
using Application.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController :BaseController
    {
        public readonly INhanVienService _service;

        public NhanVienController(INhanVienService service)
        {
            _service = service;
        }

        [HttpPost]
        public async  Task<BaseResponseDTO<bool>> Create([FromBody] CreateNhanVienDTO request)
        {
            var model = new BaseRequestDTO<CreateNhanVienDTO>()
            {
                ActionBy = UserId,
                LanguageKey = LanguageKey,
                IsAdmin = IsAdmin,
                Request = request,
            };

            return await HandleException(_service.CreateAsync(model));
        }


    }
}

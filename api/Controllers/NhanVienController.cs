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


        [HttpGet]
        public async Task<BaseResponseDTO<List<NhanVienDTO>>> GetAll([FromQuery] BaseQueryDTO request)
        {
            var model = new QueryDTO()
            {
                ActionBy = UserId,
                LanguageKey = LanguageKey,
                IsAdmin = IsAdmin,
                Page = request.Page,
                PageSize = request.PageSize,
                Keyword = request.Keyword,
            };
            // Gọi service + bắt lỗi bằng HandleException
            var result = await HandleException(_service.GetAllAsync(model));

            // Nếu có metadata thì gán thêm
            result.MetaData = new MetaDataDTO()
            {
                Page = model.Page,
                PageSize = model.PageSize,
                Total = model.Total,
            };

            return result;
        }

    }
}

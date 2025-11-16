using Application.DTO.NhanVien;
using Application.DTOs.Common;
using Application.IRepositories;
using Application.IServices;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Constants.MessageConstant;

namespace Application.Service
{
    public class NhanVienService : INhanVienService
    {
        public readonly INhanVienRepository _repository;

        private readonly ILogger<NhanVienService> _logger;

        public readonly IPhongBanRepository _phongbanRepository;

        public NhanVienService(INhanVienRepository repository, ILogger<NhanVienService> logger, IPhongBanRepository phongbanRepository)
        {
            _repository = repository;
            _logger = logger;
            _phongbanRepository = phongbanRepository;
        }

        public async Task<bool> CreateAsync(BaseRequestDTO<CreateNhanVienDTO> model)
        {
            var dto = model.Request;
            if(dto == null || string.IsNullOrWhiteSpace(dto.Ten))
            {
                throw new ApplicationException(NhanVienMessage.MISSING_PARAM_TEN);
            }
           var pb = await _phongbanRepository.Exist(dto.PhongBan.Id);
            if(pb == false)
            {
                throw new ApplicationException(PhongBanMessage.MISSING_PARAM_PB);
            }

            await  _repository.AddAsync(dto);
            return true;    
        }


        public async Task<List<NhanVienDTO>> GetAllAsync(QueryDTO model)
        {
           if(model.Page <= 0) model.Page = 1;
           if(model.PageSize <= 0) model.PageSize = 10;
           return await _repository.GetAllAsync(model);
        }
    }
}

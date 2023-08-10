using Mango.Web.Models;
using Mango.Web.Services.IService;
using Mango.Web.Utility;

namespace Mango.Web.Services
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService; 
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsnyc(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponByCodeAsnyc(string code)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/GetByCode/" + code
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsnyc(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsnyc(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }
    }
}

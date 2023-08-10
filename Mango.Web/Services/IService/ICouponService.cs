using Mango.Web.Models;
using Microsoft.AspNetCore.SignalR;

namespace Mango.Web.Services.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponByCodeAsnyc(string code);
        Task<ResponseDto?> GetCouponByIdAsnyc(int id);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponAsnyc(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponAsnyc(int id);
    }
}

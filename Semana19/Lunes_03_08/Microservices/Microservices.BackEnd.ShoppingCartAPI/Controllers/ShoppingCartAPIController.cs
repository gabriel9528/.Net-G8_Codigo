using AutoMapper;
using Microservices.BackEnd.ShoppingCartAPI.Data;
using Microservices.BackEnd.ShoppingCartAPI.Models;
using Microservices.BackEnd.ShoppingCartAPI.Models.Dto;
using Microservices.BackEnd.ShoppingCartAPI.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Microservices.BackEnd.ShoppingCartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ResponseDto _responseDto;
        private readonly IMapper _mapper;
        private readonly ICouponService _couponService;
        private readonly IProductService _productService;
        private readonly IConfiguration _configuration;

        public ShoppingCartAPIController(ApplicationDbContext db,
            IMapper mapper,
            ICouponService couponService,
            IProductService productService,
            IConfiguration configuration)
        {
            _db = db;
            _mapper = mapper;
            _couponService = couponService;
            _productService = productService;
            _configuration = configuration;
            _responseDto = new ResponseDto();
        }

        [HttpPost("ApplyCoupon")]
        public ResponseDto? ApplyCoupon([FromBody] CartDto cartDto)
        {
            try
            {
                CartHeader? cartHeaderFromDb = _db.CartHeaders
                    .FirstOrDefault(x => x.UserId == cartDto.CartHeaderDto.UserId && !x.IsDeleted);

                if (cartHeaderFromDb != null)
                {
                    cartHeaderFromDb.CouponCode = cartDto?.CartHeaderDto.CouponCode;

                    _db.CartHeaders.Update(cartHeaderFromDb);
                    _db.SaveChanges();
                }

                _responseDto.Result = true;
                _responseDto.Message = "Cupon aplicado exitosamente";
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = "Ocurrio un error: " + ex.Message;
            }

            return _responseDto;
        }

        [HttpPost("RemoveCoupon")]
        public ResponseDto RemoveCoupon([FromBody] ApplyCouponDto applyCouponDto)
        {
            try
            {
                CartHeader? cartHeaderFromDb = _db.CartHeaders
                    .FirstOrDefault(x => x.UserId == applyCouponDto.UserId && !x.IsDeleted);

                if(cartHeaderFromDb != null)
                {
                    cartHeaderFromDb.CouponCode = "";

                    _db.CartHeaders .Update(cartHeaderFromDb);
                    _db.SaveChanges();
                }

                _responseDto.Result = true;
                _responseDto.Message = "Cupon eliminado exitosamente";
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = "Ocurrio un error: " + ex.Message;
            }

            return _responseDto;
        }

        [HttpPost("UpSert")]
        public ResponseDto UpSertCart(CartDto cartDtoRequest)
        {
            try
            {
                CartHeader? cartHeaderFromDb = _db.CartHeaders
                    .FirstOrDefault(x => x.UserId == cartDtoRequest.CartHeaderDto.UserId && !x.IsDeleted);

                #region POST

                CartHeader newCartHeader = new();
                CartDetails newCartDetails = new CartDetails();

                if(cartHeaderFromDb == null)
                {
                    newCartHeader.UserId = cartDtoRequest.CartHeaderDto.UserId;
                    newCartHeader.CouponCode = cartDtoRequest.CartHeaderDto.CouponCode;
                    newCartHeader.Discount = cartDtoRequest.CartHeaderDto.Discount;
                    newCartHeader.CartTotal = cartDtoRequest.CartHeaderDto.CartTotal;

                    _db.CartHeaders.Add(newCartHeader);
                    _db.SaveChanges();

                    //Relacionar el cartHeader con sus details
                    cartDtoRequest!.cartDetailsDtos!.First().CartHeaderId = newCartHeader.Id;

                    CartDetailsDto? cartDetailsDto = cartDtoRequest?.cartDetailsDtos?.First();
                    newCartDetails.CartHeaderId = newCartHeader.Id;
                    newCartDetails.ProductId = cartDetailsDto!.ProductId;
                    newCartDetails.Count =cartDetailsDto.Count;

                    _db.CartDetails.Add(newCartDetails);
                    _db.SaveChanges();

                    _responseDto.Result = newCartHeader.Id;
                    _responseDto.Message = "Cart creado con exito";
                }
                #endregion
                #region UPDATE
                else
                {
                    //Revisar si los details les corresponde el mismo producto
                    CartDetails? cartDetailsFromDb = _db.CartDetails.AsNoTracking()
                        .FirstOrDefault(x => x.ProductId == cartDtoRequest.cartDetailsDtos
                        .First().ProductId && x.CartHeaderId == cartHeaderFromDb.Id);

                    if(cartDetailsFromDb == null)
                    {
                        CartDetailsDto? cartDetailsDto = cartDtoRequest.cartDetailsDtos
                            .FirstOrDefault();

                        newCartDetails.CartHeaderId = cartDetailsDto.CartHeaderId;
                        newCartDetails.ProductId = cartDetailsDto.ProductId;
                        newCartDetails.Count = cartDetailsDto.Count;

                        _db.CartDetails.Add(newCartDetails);
                        _db.SaveChanges();

                        _responseDto.Result= newCartHeader.Id;
                        _responseDto.Message = "Cartdetails agregados con exito";
                    }
                    else
                    {
                        //Si ecisten los details, los actualizaoms
                        cartDetailsFromDb.Count += cartDtoRequest.cartDetailsDtos.FirstOrDefault().Count;
                        cartDetailsFromDb.CartHeaderId += cartDtoRequest.cartDetailsDtos.FirstOrDefault().CartHeaderId;
                        cartDetailsFromDb.ProductId += cartDtoRequest.cartDetailsDtos.FirstOrDefault().ProductId;

                        _db.CartDetails.Update(cartDetailsFromDb);
                        _db.SaveChanges();

                        _responseDto.Result = true;
                        _responseDto.Message = "CartDetails actualizados con exito";
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = "Ocurrio un error: "+ex.Message;
            }

            return _responseDto;
        }

    }
}

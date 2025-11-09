using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs.Payments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IOrderService _orderService;

        public PaymentsController(IPaymentService paymentService, IOrderService orderService)
        {
            _paymentService = paymentService;
            _orderService = orderService;
        }

        [HttpPost("initiate")]
        [Authorize(AuthenticationSchemes = "Admin")]
        public async Task<IActionResult> InitiatePayment([FromBody] PaymentInitiationRequest request, CancellationToken cancellationToken)
        {
            var response = await _paymentService.InitiateAsync(request, cancellationToken);
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        [HttpPost("confirm")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmPayment([FromBody] PaymentConfirmationRequest request, CancellationToken cancellationToken)
        {
            var response = await _paymentService.ConfirmAsync(request, cancellationToken);
            await _orderService.UpdatePaymentAsync(response);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
    }
}

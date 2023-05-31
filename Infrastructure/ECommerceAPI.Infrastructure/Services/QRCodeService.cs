using ECommerceAPI.Application.Abstractions.Services;
using QRCoder;

namespace ECommerceAPI.Infrastructure.Services
{
    public class QRCodeService : IQRCodeService
    {
        public QRCodeService()
        {

        }

        public byte[] GenerateQRCode(string text)
        {
            QRCodeGenerator generator = new();
            var data = generator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new(data);
            byte[] byteGraphic = qrCode.GetGraphic(10, new byte[] { 84, 99, 71 }, new byte[] { 240, 240, 240 });

            return byteGraphic;
        }
    }
}

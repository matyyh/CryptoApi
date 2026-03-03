using Microsoft.AspNetCore.Mvc;

namespace CryptoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CryptoController : ControllerBase
    {
        private readonly int _shift = 3;

        [HttpGet("encrypt/{text}")]
        public IActionResult Encrypt(string text)
        {
            var result = new string(text.Select(c => (char)(c + _shift)).ToArray());
            return Ok(new { original = text, result = result });
        }

        [HttpGet("decrypt/{text}")]
        public IActionResult Decrypt(string text)
        {
            var result = new string(text.Select(c => (char)(c - _shift)).ToArray());
            return Ok(new { original = text, result = result });
        }
    }
}